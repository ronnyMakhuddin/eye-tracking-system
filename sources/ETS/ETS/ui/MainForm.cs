using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Runtime.InteropServices;
using System.Diagnostics;
using ETS.tracker;
using ETS.Properties;
using ETS.ui;
using System.IO;



namespace ETS
{
    public enum NodeType
    {
        Session,
        Trial,
        Template
    }
    public partial class MainForm : Form
    {
        private CaptureManager captureManager;

        private Timer timer;

        public void Init()
        {

            lock (captureImageBox)
            {

                captureManager = CaptureManager.Instance;

                if (!captureManager.Inited)
                {
                    captureManager.OnStartInit += new CaptureManager.StartInitEventHandler(captureManager_OnStartInit);
                    captureManager.OnFinishInit += new CaptureManager.FinishInitEventHandler(captureManager_OnFinishInit);
                    captureManager.OnErrorInit += new CaptureManager.InitErrorEventHandler(captureManager_OnErrorInit);
                    captureManager.Init();
                }
                captureManager.CameraHeight = 240;
                captureManager.CameraWidth = 320;
                timer = new Timer();
                timer.Interval = 200;
                timer.Start();
                RefreshSessionTree();
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            ProcessFrame(null, null);
            if (Session.Instance.Modified)
            {
                Text = "ETS*";
            }
            else
            {
                Text = "ETS";
            }
        }

        void captureManager_OnTracking(Rectangle rect)
        {
            CvInvoke.cvRectangle(captureImageBox.Image.Ptr, rect.Location, new Point(rect.X + rect.Width, rect.Y + rect.Height), new MCvScalar(255), 3, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, 0);

        }

        void captureManager_OnErrorInit(Exception e)
        {
            Util.ShowError(e.Message);
        }

        void captureManager_OnFinishInit()
        {
            lblMessages.Text = Resources.CAPTURE_CREATED;
        }

        void captureManager_OnStartInit()
        {
        }
        DateTime dt = DateTime.Now;
        private void ProcessFrame(object sender, EventArgs arg)
        {
            lock (captureImageBox)
            {
                captureImageBox.Image = CaptureManager.Instance.QueryFrame();
                CaptureManager.Instance.ProcessFrame();
                String text = String.Empty;
                if (Session.Instance.CurrentTrial == null) return;
                foreach (Template t in Session.Instance.CurrentTrial.Templates)
                {

                    text += t.GetLastCoordinate().ToString();
                    text += " ||| ";
                }
                textBox1.Text = "\r\n-====================-\r\n" + text + textBox1.Text;
                long ms = -dt.Ticks + DateTime.Now.Ticks;
                textBox1.Text = "\r\n" + ms + " ms\r\n" + textBox1.Text;
                dt = DateTime.Now;

            }
        }
        public MainForm()
        {
            InitializeComponent();
            Application.Idle += new EventHandler(Application_Idle);

        }

        void Application_Idle(object sender, EventArgs e)
        {
          
            
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            //     captureImageBox.Size = new Size(this.Size.Width / 2, this.Size.Height - 120);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Init();
            if (captureManager != null && captureManager.Inited)
            {
                timer.Tick += new EventHandler(timer_Tick);
            }
        }



        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            captureManager.State = States.ADD_TEMPLATE;
            AddTemplateForm atf = new AddTemplateForm(captureImageBox.Width, captureImageBox.Height);
            if (atf.ShowDialog() == DialogResult.OK)
            {
                Session.Instance.Modified = true;
                RefreshSessionTree();
            }
        }

        private void btnClearTemplates_Click(object sender, EventArgs e)
        {
            Session.Instance.CurrentTrial.ClearTemplates();
            RefreshSessionTree();
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            Save(true);
        }
        public void Save(bool saveAs)
        {
            if (trvSession.SelectedNode == null)
            {
                return;
            }
            switch ((NodeType)trvSession.SelectedNode.Tag)
            {
                case NodeType.Session:
                    SaveSession(saveAs);
                    break;
                case NodeType.Trial:
                    Trial target = (Trial)Session.Instance.Trials[trvSession.SelectedNode.Index];
                    SaveTrial(target, saveAs);
                    break;
                case NodeType.Template:
                    Trial tgt = (Trial)Session.Instance.Trials[trvSession.SelectedNode.Parent.Index];
                    SaveTrial(tgt, saveAs);
                    break;
            }
            RefreshSessionTree();
           
        }
        private void SaveTrial(Trial target, bool saveAs)
        {
            string fileName = string.Empty;
            if (target.WasSaved && !saveAs)
            {
                fileName = target.FileName;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = Resources.SaveTrialAs;
                sfd.Filter = Resources.TrialFileFilter;
                sfd.FileName = target.Name;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fileName = sfd.FileName;
                    target.Name = Path.GetFileNameWithoutExtension(fileName);
                }
            }
            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                target.FileName = fileName;
                target.Save(sw,fileName);
            }
        }
        public void SaveSession(bool saveAs)
        {
            foreach (Trial t in Session.Instance.Trials)
            {
                SaveTrial(t, saveAs);
            }

            string fileName = string.Empty;
            if (Session.Instance.WasSaved && !saveAs)
            {
                fileName = Session.Instance.FileName;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = Resources.SaveSessionAs;
                sfd.Filter = Resources.SessionFileFilter;
                sfd.FileName = Session.Instance.Name;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fileName = sfd.FileName;
                }
            }
            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                Session.Instance.FileName = fileName;
                Session.Instance.Name = Path.GetFileNameWithoutExtension(                                fileName);
                Session.Instance.Save(sw);
            }
        }

        public void RefreshSessionTree()
        {
            if (trvSession.Nodes.Count != 0)
            {
                trvSession.Nodes.Clear();
            }
            TreeNode topNode = new TreeNode(Session.Instance.Name);
            topNode.Tag = NodeType.Session;
            trvSession.Nodes.Add(topNode);
            trvSession.TopNode = topNode;
            for (int i = 0; i < Session.Instance.Trials.Count; i++)
            {
                Trial t = (Trial)Session.Instance.Trials[i];
                TreeNode trialNode = new TreeNode(t.Name);
                trialNode.Tag = NodeType.Trial;
                topNode.Nodes.Add(trialNode);
                for (int j = 0; j < t.Templates.Count; j++)
                {
                    Template tp = (Template)t.Templates[j];
                    TreeNode templateNode = new TreeNode(tp.Name);
                    templateNode.Tag = NodeType.Template;
                    trialNode.Nodes.Add(templateNode);
                }
            }
            trvSession.ExpandAll();
            if (Session.Instance.CurrentTrial != null)
            {
                trvSession.SelectedNode = trvSession.TopNode.Nodes[Session.Instance.CurrentTrialIndex];
            }
        }

        private void trvSession_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Label))
            {
                Util.ShowError(Resources.EmptyNameError);
            }
            else
            {
                switch ((NodeType)e.Node.Tag)
                {
                    case NodeType.Session:
                        Session.Instance.Name = e.Label;
                        trvSession.TopNode.Text = Session.Instance.Name;
                        break;
                    case NodeType.Trial:
                        Trial target = (Trial)Session.Instance.Trials[e.Node.Index];
                        target.Name = e.Label;
                        e.Node.Text = target.Name;
                        break;
                    case NodeType.Template:
                        Trial tgt = (Trial)Session.Instance.Trials[e.Node.Parent.Index];
                        Template template = (Template)tgt.Templates[e.Node.Index];
                        template.Name = e.Label;
                        e.Node.Text = template.Name;
                        break;
                }


            }

            e.CancelEdit = true;
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            captureManager.StartRecording();
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            captureManager.StopRecording();
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            Save(false);
        }

        private void openSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = Resources.OpenSession;
            ofd.Filter = Resources.SessionFileFilter;
        
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    try
                    {
                        Session.Instance.Clear();
                        Session.Instance.Load(sr);
                    }
                    catch (Exception ex)
                    {
                        Util.ShowError(ex.Message);
                        Session.Instance.Clear();
                    }
                    RefreshSessionTree();
                }
            }
        }






    }
}
