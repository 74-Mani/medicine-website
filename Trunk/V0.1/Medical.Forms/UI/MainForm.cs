﻿using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using Medical.Data;
using Medical.Forms.Enums;
using Medical.Forms.EventArgs;
using Medical.Forms.Implements;
using Medical.Forms.Interfaces;
using WeifenLuo.WinFormsUI.Docking;


namespace Medical.Forms.UI
{
    public partial class MainForm : Form
    {
        private readonly string _iconPath = Application.StartupPath + "\\Icons";
        private delegate void Method(ProgressiveUpdateArgs arg);

        private TreeMenuGUI _treeMenuGui;

        public IContainerProvider ViewContainer { get; set; }
        public IMessageManager MessageContainer { get; set; }
        public ViewManager ViewManager { get; set; }
        public IContainerProvider ModuleContainer { private get; set; }
        public IMenuManager TopMenu { private get; set; }
        //public IContextManager Context { private get; set; }
        public ILogManager LogManager { private get; set; }

        public MainForm()
        {
            InitializeComponent();
            ExceptionHandler.Instance.ErrorOccur += InstanceErrorOccur;
            MethodExecuter.Instance.MethodExecuteRequestEvent += new EventHandler<ActionArgs>(InstanceMethodExecuteRequestEvent);
            MethodExecuter.Instance.MethodExecuteUpdateProgressEvent += new EventHandler<ProgressiveUpdateArgs>(InstanceMethodExecuteUpdateProgressEvent);


            // Init Tree view
            _treeMenuGui = new TreeMenuGUI
                           {
                               ShowHint = DockState.DockLeft,
                               AllowEndUserDocking = false,
                               CloseButton = false,
                               IsFloat = false,
                               CloseButtonVisible = false
                           };
            _treeMenuGui.Show(dockingPanel);
        }

        public void CommonInitilize() {
            ProgressiveDialogWraper.Instance.Parent = this;
            this.TopMenu.CreateMenuItem( AppContext.LoggedInUser.Role, this._treeMenuGui.TreeViewMenu);
            this.TopMenu.MenuItemClicked += TrivMenuMenuItemClicked;
            // this.TopMenu.CreateToolBar(this.MainToolBar, AppContext.LoggedInUser.Role);

            this.ViewManager = new ViewManager(this.ModuleContainer, this.dockingPanel);
            // ViewManager.OnRequestDialogEventArgs += ViewManagerOnRequestDialogEventArgs;
            // ViewManager.ViewChange += ViewManagerViewChange;
            MessageDialog.Instance.MessageContainer = this.MessageContainer;
            ExceptionHandler.Instance.Log = this.LogManager;

            logViewer.Image = System.Drawing.Image.FromFile(_iconPath + "\\info.png");

            
        }

        private void InstanceMethodExecuteUpdateProgressEvent(object sender, ProgressiveUpdateArgs e)
        {
            Console.WriteLine("Update progress: " + e.Value + " -" + e.Status);
            if (worker.IsBusy)
            {
                worker.ReportProgress(0, e);
            }
            else
            {
                UpdateProgressive(e);
            }
            //this.Invoke(new Method(this.UpdateProgressive), arg);
        }

        private void InstanceMethodExecuteRequestEvent(object sender, ActionArgs e) {
            Console.WriteLine("Request run method: " + e.MethodExecuter.Method.Name);
            if (e.MethodExecuter == null) return;
            this.worker.RunWorkerAsync(e.MethodExecuter);
            ProgressiveDialog.Instance.ShowProgress(this);
        }

        private void InstanceErrorOccur(object sender, System.EventArgs e)
        {
            MessageDialog.Instance.ShowMessage(this, "ERR0001", "Đã có lỗi xảy ra. Xem log để biết thêm chi tiết");
            logViewer.Image = System.Drawing.Image.FromFile(_iconPath + "\\erro_occur.png");
        }

        private void ViewManagerViewChange(object sender, ViewChangeEventArgs e)
        {
            switch (e.Status)
            {
                case ViewChangeStatus.Change:
                    // Show waiting dialog
                    this.Enabled = false;
                    this.toolStripStatus.Text = "Loading ...";
                    this.toolStripProgressBar.Visible = true;
                    this.toolStripProgressBar.Style = ProgressBarStyle.Continuous;
                    this.toolStripProgressBar.Maximum = 100;
                    this.toolStripProgressBar.Minimum = 0;
                    this.toolStripProgressBar.Value = 30;
                    
                    this.Update();
                    break;
                case ViewChangeStatus.Changing:
                    if (!e.IsInDialogMode)
                    {
                        // Attach UI to the view
                        // this.pnlMainPanel.Controls.Clear();
                        // pnlMainPanel.Controls.Add(this.ViewManager.CurrentView.UI);
                        // this.Text = this.ViewManager.CurrentView.Name;
                        // this.ViewManager.CurrentView.UI.Dock = DockStyle.Fill;
                        this.Update();
                        this.toolStripProgressBar.Value = 80;
                    } else {
                        // TODO Attach screen when it's needed to show in dialog
                        var viewDialog = new ViewDialog();
                        // viewDialog.AttachToView(this.ViewManager.CurrentView);
                        viewDialog.Closed += new EventHandler(ViewDialogClosed);
                        viewDialog.ShowDialog(this);
                    }
                    break;
                case ViewChangeStatus.Changed:
                    // Close waiting dialog
                    this.toolStripProgressBar.Value = 100;
                    this.Update();
                    this.toolStripStatus.Text = "Ready";
                    this.Enabled = true;
                    this.toolStripProgressBar.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void ViewDialogClosed(object sender, System.EventArgs e)
        {
            // this.ViewManager.Back();
        }

        private void ViewManagerOnRequestDialogEventArgs(object sender, RequestDialogFromEventArgs e)
        {
            switch (e.DialogMode)
            {
                case DialogMode.Message:
                    MessageDialog.Instance.ShowMessage(this, e.MessageId, e.Parameters);
                    break;
                case DialogMode.FileChooser:
                    openFileDialog.Filter = e.FileFilter;
                    openFileDialog.Multiselect = false;
                    var result = openFileDialog.ShowDialog(this);
                    if (result == DialogResult.OK) e.Result = openFileDialog.FileName;
                    break;
                case DialogMode.FolderChooser:
                    var openFileDialogResult = folderBrowserDialog.ShowDialog(this);
                    if (openFileDialogResult == DialogResult.OK) e.Result = folderBrowserDialog.SelectedPath;
                    break;
                case DialogMode.SaveFile:
                    saveFileDialog.Filter = e.FileFilter;
                    var saveFileResult = saveFileDialog.ShowDialog(this);
                    if (saveFileResult == DialogResult.OK) e.Result = saveFileDialog.FileName;
                    break;
                case DialogMode.LockScreen:
                    this.Enabled = false;
                    break;
                case DialogMode.UnlockScreen:
                    this.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void MainFormLoad(object sender, System.EventArgs e)
        {
            // Console.WriteLine("Hello");
        }

        /// <summary>
        /// Trivs the menu menu item clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MenuItemClickedEventArgs"/> instance containing the event data.</param>
        private void TrivMenuMenuItemClicked(object sender, MenuItemClickedEventArgs e)
        {
            //var item = (ToolStripMenuItem) sender;
            //if (item == null) return;
            //var menuItem = (TopMenuItem) item.Tag;
            //if (menuItem == null) return;

            if (!string.IsNullOrEmpty(e.Key)) {
                this.ViewManager.ShowDocument(e.Key);
                return; ;
            }

            if (!string.IsNullOrEmpty(e.InvokeKey))
            {
                switch (e.InvokeKey)
                {
                    case "SysmteExit":
                        DialogResult result = MessageDialog.Instance.ShowMessage(this, "MSG0002");
                        if (result == DialogResult.Yes) Application.Exit();
                        break;;
                    default:
                        break;
                }
            }
        }

        private void LogViewerClick(object sender, System.EventArgs e)
        {
            logViewer.Image = System.Drawing.Image.FromFile(_iconPath + "\\info.png");
            var dialog = new LogViewerDialog();
            dialog.ShowDialog(this);
        }

        private void WorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Console.WriteLine(">>>> Run method");
            var a = e.Argument as Action;
            if (a != null) a.Invoke();
        }

        private void WorkerProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.toolStripProgressBar.Value = e.ProgressPercentage;
            
            if (e.ProgressPercentage == 0) this.toolStripProgressBar.Visible = true;
            var arg = e.UserState as String;
            if (arg == null) return;
            this.toolStripStatus.Text = arg;
            ProgressiveDialog.Instance.UpdateStatus(arg);
            this.Update();
            // UpdateProgressive(arg);
            //this.Invoke(new Method(this.UpdateProgressive), arg);
        }

        private void WorkerRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ProcessEndWorker(e.Error);
        }

        private void ProcessEndWorker(Exception error)
        {
            ProgressiveDialog.Instance.CloseProgress();
            ProgressiveDialog.Instance.Close();

            if (error == null)
            {
                // MessageDialog.Instance.ShowMessage(this, "MSG0001");
                this.toolStripProgressBar.Visible = false;
                this.toolStripStatus.Text = "Đồng bộ dữ liệu thành công lúc " + DateTime.Now.ToString("HH:mm");
            }
            else
            {
                ExceptionHandler.Instance.HandlerException(error);
                //MessageDialog.Instance.ShowMessage(this, "ERR0001", error.Message);
                this.toolStripProgressBar.Visible = false;
                this.toolStripStatus.Text = "Error: " + error.Message;
                logViewer.Image = System.Drawing.Image.FromFile(_iconPath + "\\erro_occur.png");
            }
        }

        public void UpdateProgressive(ProgressiveUpdateArgs arg)
        {
            switch (arg.Mode)
            {
                case ProgressUpdateMode.Reset:
                    if (this.worker.IsBusy) ProgressiveDialog.Instance.Initialize(0, arg.Maximum);
                    this.toolStripProgressBar.Maximum = arg.Maximum;
                    this.toolStripProgressBar.Value = 0;
                    this.toolStripStatus.Text = string.Empty;
                    this.toolStripProgressBar.Visible = true;
                    break;
                case ProgressUpdateMode.Update:
                    if (arg.Value != 0 && !String.IsNullOrEmpty(arg.Status))
                    {
                        if (this.worker.IsBusy) ProgressiveDialog.Instance.UpdateProgress(arg.Status, arg.Value);
                        this.toolStripStatus.Text = arg.Status;
                        this.toolStripProgressBar.Value = arg.Value;
                    }
                    else if (arg.Value != 0)
                    {
                        if (this.worker.IsBusy) ProgressiveDialog.Instance.UpdateProgress(arg.Value);
                        this.toolStripProgressBar.Value = arg.Value;
                    }
                    else if (!String.IsNullOrEmpty(arg.Status))
                    {
                        if (this.worker.IsBusy) ProgressiveDialog.Instance.UpdateStatus(arg.Status);
                        this.toolStripStatus.Text = arg.Status;
                    }
                    break;
                case ProgressUpdateMode.AddProgress:
                    if (arg.Value != 0 && !String.IsNullOrEmpty(arg.Status))
                    {
                        if (this.worker.IsBusy) ProgressiveDialog.Instance.AddProgress(arg.Status, arg.Value);
                        this.toolStripStatus.Text = arg.Status;
                        this.toolStripProgressBar.Value += arg.Value;
                    }
                    else if (arg.Value != 0)
                    {
                        if (this.worker.IsBusy) ProgressiveDialog.Instance.AddProgress(arg.Value);
                        this.toolStripProgressBar.Value += arg.Value;
                    }
                    break;
                case ProgressUpdateMode.Finish:
                    this.toolStripStatus.Text = "Ready";
                    this.toolStripProgressBar.Value = this.toolStripProgressBar.Maximum;
                    this.toolStripProgressBar.Visible = false; 
                    break;
                default:
                    break;
            }
        }

        private void MainFormShown(object sender, System.EventArgs e)
        {

            Boolean isFirstRun = Boolean.Parse(ConfigurationManager.AppSettings.Get("FirstRun"));
            if (isFirstRun)
            {
                var selectClinic = new ClinicSelection();
                selectClinic.ShowDialog(this);
            }

            var login = new Login();
            login.ShowDialog(this);

            if (AppContext.Authenticated)
            {
                this.txtLoggedIn.Text = String.Format("{0}:{1}", AppContext.LoggedInUser.RoleName, AppContext.LoggedInUser.UserName);
                this.txtClinic.Text = String.Format("Phòng khám: {0}", AppContext.CurrentClinic.Name);
                this.mnuLogout.Enabled = true;
                this.mnuLogin.Enabled = false;
            }
            else
            {
                this.mnuLogout.Enabled = false;
                this.mnuLogin.Enabled = true;
            }
            this.CommonInitilize();
        }

        private void OpenToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            var login = new Login();
            login.ShowDialog(this);

            if (AppContext.Authenticated)
            {
                this.txtLoggedIn.Text = AppContext.LoggedInUser.UserName;
                this.txtClinic.Text = AppContext.CurrentClinic.Name;
                this.mnuLogout.Enabled = true;
                this.mnuLogin.Enabled = false;
            } else
            {
                this.mnuLogout.Enabled = false;
                this.mnuLogin.Enabled = true;
            }
            this.CommonInitilize();
        }

        private void DoiMatKhauToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            ChangePassword changePass = new ChangePassword(AppContext.LoggedInUser);
            changePass.ShowDialog(this);

            
        }

        private void ThoatToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            var dialogResult = MessageDialog.Instance.ShowMessage(this, "Q010", "");
            if (dialogResult == DialogResult.No) return;
            else Environment.Exit(0);
        }

        private void DongBoHoaDuLieuToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            if (this.worker.IsBusy)
            {
                MessageDialog.Instance.ShowMessage(this, "MSG0005", "Tiến trình đồng bộ hóa đang được thực hiện");
                return;
            }
            var action = new Action(Sync);
            this.worker.RunWorkerAsync(action);
            ProgressiveDialog.Instance.ShowProgress(this);

            // Sync.Sync sync = new Sync.Sync();
            // MessageBox.Show(this,sync.Test());
            //frmSynchr frmSynchr = new frmSynchr();
            //frmSynchr.ShowDialog(this);
        }

        private void Sync()
        {
            //var sync = new Sync.Sync { Worker = this.worker };
            //try
            //{
            //    sync.DoSyncMaster();
            //    sync.DoSync(AppContext.CurrentClinicId);
            //    sync.DoRemove(AppContext.CurrentClinicId);
            //}
            //finally
            //{
            //    sync.UpdateSyncResult(AppContext.CurrentClinicId);
            //}

            //HieuNK - fix synchronize
            Medical.Synchronization.Synchronize synservice = new Medical.Synchronization.Synchronize();
            synservice.SendingCompleted += synservice_SendingCompleted;
            synservice.SendAll(AppContext.CurrentClinicId.ToString()); 
        }

        private void synservice_SendingCompleted(object sender, System.EventArgs e)
        {
            //MessageDialog.Instance.ShowMessage(this, "MSG0005", "Tiến trình đồng bộ hóa được thực hiện thành công");
            MessageBox.Show("Tiến trình đồng bộ hóa được thực hiện thành công", "MSG0005");
        }

        private void MnuServerClick(object sender, System.EventArgs e)
        {
            var serverForm = new Database();
            serverForm.ShowDialog();
        }

        private void MnuHelpClick(object sender, System.EventArgs e)
        {

        }

        private void MnuCheckingClick(object sender, System.EventArgs e)
        {
            var form = new CheckingConnectionForm();
            form.ShowDialog(this);
        }
    }
}
