namespace MachineReader
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.stsmImportMachine = new System.Windows.Forms.ToolStripMenuItem();
            this.stsmExportMachine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.stsmChangeMachine = new System.Windows.Forms.ToolStripMenuItem();
            this.stsmChangeString = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.stsmMachine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.tslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbMain = new System.Windows.Forms.ToolStripProgressBar();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.grpSystemFunctions = new System.Windows.Forms.GroupBox();
            this.btnResetState = new System.Windows.Forms.Button();
            this.btnReadMachine = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangeString = new System.Windows.Forms.Button();
            this.grpMachineFunctions = new System.Windows.Forms.GroupBox();
            this.lblRejectState = new System.Windows.Forms.Label();
            this.lblSeperator4 = new System.Windows.Forms.Label();
            this.lblHaltState = new System.Windows.Forms.Label();
            this.lblSeperator3 = new System.Windows.Forms.Label();
            this.lblAcceptState = new System.Windows.Forms.Label();
            this.lblSeperator2 = new System.Windows.Forms.Label();
            this.lblNoStates = new System.Windows.Forms.Label();
            this.lblMachineDetails = new System.Windows.Forms.Label();
            this.btnEnterString = new System.Windows.Forms.Button();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.lblInputString = new System.Windows.Forms.Label();
            this.btnImportMachine = new System.Windows.Forms.Button();
            this.txtInputMachine = new System.Windows.Forms.TextBox();
            this.lblInputMachine = new System.Windows.Forms.Label();
            this.spcConsole = new System.Windows.Forms.SplitContainer();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txtResultConsole = new System.Windows.Forms.TextBox();
            this.txtLogConsole = new System.Windows.Forms.TextBox();
            this.spcSimulate = new System.Windows.Forms.SplitContainer();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblTape = new System.Windows.Forms.Label();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.sfdMain = new System.Windows.Forms.SaveFileDialog();
            this.tm_Progress = new System.Windows.Forms.Timer(this.components);
            this.mnuMain.SuspendLayout();
            this.stsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.grpSystemFunctions.SuspendLayout();
            this.grpMachineFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcConsole)).BeginInit();
            this.spcConsole.Panel1.SuspendLayout();
            this.spcConsole.Panel2.SuspendLayout();
            this.spcConsole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcSimulate)).BeginInit();
            this.spcSimulate.Panel1.SuspendLayout();
            this.spcSimulate.Panel2.SuspendLayout();
            this.spcSimulate.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmEdit,
            this.tsmView,
            this.tsmHelp});
            this.mnuMain.Location = new System.Drawing.Point(5, 5);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(661, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mnuMain";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsmImportMachine,
            this.stsmExportMachine,
            this.toolStripSeparator2,
            this.stsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmFile.Text = "&File";
            // 
            // stsmImportMachine
            // 
            this.stsmImportMachine.Name = "stsmImportMachine";
            this.stsmImportMachine.Size = new System.Drawing.Size(180, 22);
            this.stsmImportMachine.Text = "Import &Machine";
            this.stsmImportMachine.Click += new System.EventHandler(this.ImportMachine);
            // 
            // stsmExportMachine
            // 
            this.stsmExportMachine.Enabled = false;
            this.stsmExportMachine.Name = "stsmExportMachine";
            this.stsmExportMachine.Size = new System.Drawing.Size(180, 22);
            this.stsmExportMachine.Text = "Export &Machine";
            this.stsmExportMachine.Click += new System.EventHandler(this.ExportMachine);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // stsmExit
            // 
            this.stsmExit.Name = "stsmExit";
            this.stsmExit.Size = new System.Drawing.Size(180, 22);
            this.stsmExit.Text = "E&xit";
            this.stsmExit.Click += new System.EventHandler(this.ExitApplication);
            // 
            // tsmEdit
            // 
            this.tsmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsmChangeMachine,
            this.stsmChangeString});
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(39, 20);
            this.tsmEdit.Text = "&Edit";
            // 
            // stsmChangeMachine
            // 
            this.stsmChangeMachine.Enabled = false;
            this.stsmChangeMachine.Name = "stsmChangeMachine";
            this.stsmChangeMachine.Size = new System.Drawing.Size(180, 22);
            this.stsmChangeMachine.Text = "Change &Machine";
            this.stsmChangeMachine.Click += new System.EventHandler(this.ChangeMachine);
            // 
            // stsmChangeString
            // 
            this.stsmChangeString.Enabled = false;
            this.stsmChangeString.Name = "stsmChangeString";
            this.stsmChangeString.Size = new System.Drawing.Size(180, 22);
            this.stsmChangeString.Text = "Change &String";
            this.stsmChangeString.Click += new System.EventHandler(this.ChangeString);
            // 
            // tsmView
            // 
            this.tsmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsmMachine});
            this.tsmView.Name = "tsmView";
            this.tsmView.Size = new System.Drawing.Size(44, 20);
            this.tsmView.Text = "&View";
            // 
            // stsmMachine
            // 
            this.stsmMachine.Name = "stsmMachine";
            this.stsmMachine.Size = new System.Drawing.Size(180, 22);
            this.stsmMachine.Text = "&Machine";
            this.stsmMachine.Click += new System.EventHandler(this.ViewMachine);
            // 
            // tsmHelp
            // 
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmHelp.Text = "&Help";
            // 
            // stsMain
            // 
            this.stsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblStatus,
            this.tspbMain,
            this.tsStatus});
            this.stsMain.Location = new System.Drawing.Point(5, 374);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(661, 22);
            this.stsMain.SizingGrip = false;
            this.stsMain.TabIndex = 1;
            this.stsMain.Text = "stsMain";
            // 
            // tslblStatus
            // 
            this.tslblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tslblStatus.Name = "tslblStatus";
            this.tslblStatus.Size = new System.Drawing.Size(42, 17);
            this.tslblStatus.Text = "Status:";
            // 
            // tspbMain
            // 
            this.tspbMain.Name = "tspbMain";
            this.tspbMain.Size = new System.Drawing.Size(100, 16);
            this.tspbMain.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tsStatus
            // 
            this.tsStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(47, 17);
            this.tsStatus.Text = "[Status]";
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(5, 29);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.grpSystemFunctions);
            this.spcMain.Panel1.Controls.Add(this.grpMachineFunctions);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcConsole);
            this.spcMain.Panel2.Controls.Add(this.spcSimulate);
            this.spcMain.Size = new System.Drawing.Size(661, 345);
            this.spcMain.SplitterDistance = 107;
            this.spcMain.TabIndex = 2;
            // 
            // grpSystemFunctions
            // 
            this.grpSystemFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpSystemFunctions.Controls.Add(this.btnResetState);
            this.grpSystemFunctions.Controls.Add(this.btnReadMachine);
            this.grpSystemFunctions.Controls.Add(this.btnExit);
            this.grpSystemFunctions.Controls.Add(this.btnChangeString);
            this.grpSystemFunctions.Location = new System.Drawing.Point(483, 5);
            this.grpSystemFunctions.Name = "grpSystemFunctions";
            this.grpSystemFunctions.Size = new System.Drawing.Size(175, 100);
            this.grpSystemFunctions.TabIndex = 1;
            this.grpSystemFunctions.TabStop = false;
            this.grpSystemFunctions.Text = "System Functions:";
            // 
            // btnResetState
            // 
            this.btnResetState.BackColor = System.Drawing.Color.Teal;
            this.btnResetState.Enabled = false;
            this.btnResetState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResetState.Location = new System.Drawing.Point(36, 71);
            this.btnResetState.Name = "btnResetState";
            this.btnResetState.Size = new System.Drawing.Size(103, 23);
            this.btnResetState.TabIndex = 3;
            this.btnResetState.Text = "Reset State";
            this.btnResetState.UseVisualStyleBackColor = false;
            // 
            // btnReadMachine
            // 
            this.btnReadMachine.BackColor = System.Drawing.Color.Teal;
            this.btnReadMachine.Enabled = false;
            this.btnReadMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReadMachine.Location = new System.Drawing.Point(36, 44);
            this.btnReadMachine.Name = "btnReadMachine";
            this.btnReadMachine.Size = new System.Drawing.Size(102, 23);
            this.btnReadMachine.TabIndex = 2;
            this.btnReadMachine.Text = "Read Machine";
            this.btnReadMachine.UseVisualStyleBackColor = false;
            this.btnReadMachine.Click += new System.EventHandler(this.btnReadMachine_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.Location = new System.Drawing.Point(118, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.ExitApplication);
            // 
            // btnChangeString
            // 
            this.btnChangeString.BackColor = System.Drawing.Color.Teal;
            this.btnChangeString.Enabled = false;
            this.btnChangeString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChangeString.Location = new System.Drawing.Point(6, 17);
            this.btnChangeString.Name = "btnChangeString";
            this.btnChangeString.Size = new System.Drawing.Size(106, 23);
            this.btnChangeString.TabIndex = 0;
            this.btnChangeString.Text = "Change String";
            this.btnChangeString.UseVisualStyleBackColor = false;
            this.btnChangeString.Click += new System.EventHandler(this.ChangeString);
            // 
            // grpMachineFunctions
            // 
            this.grpMachineFunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpMachineFunctions.Controls.Add(this.lblRejectState);
            this.grpMachineFunctions.Controls.Add(this.lblSeperator4);
            this.grpMachineFunctions.Controls.Add(this.lblHaltState);
            this.grpMachineFunctions.Controls.Add(this.lblSeperator3);
            this.grpMachineFunctions.Controls.Add(this.lblAcceptState);
            this.grpMachineFunctions.Controls.Add(this.lblSeperator2);
            this.grpMachineFunctions.Controls.Add(this.lblNoStates);
            this.grpMachineFunctions.Controls.Add(this.lblMachineDetails);
            this.grpMachineFunctions.Controls.Add(this.btnEnterString);
            this.grpMachineFunctions.Controls.Add(this.txtInputString);
            this.grpMachineFunctions.Controls.Add(this.lblInputString);
            this.grpMachineFunctions.Controls.Add(this.btnImportMachine);
            this.grpMachineFunctions.Controls.Add(this.txtInputMachine);
            this.grpMachineFunctions.Controls.Add(this.lblInputMachine);
            this.grpMachineFunctions.Location = new System.Drawing.Point(3, 5);
            this.grpMachineFunctions.Name = "grpMachineFunctions";
            this.grpMachineFunctions.Size = new System.Drawing.Size(474, 100);
            this.grpMachineFunctions.TabIndex = 0;
            this.grpMachineFunctions.TabStop = false;
            this.grpMachineFunctions.Text = "Machine Functions:";
            // 
            // lblRejectState
            // 
            this.lblRejectState.AutoSize = true;
            this.lblRejectState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRejectState.Location = new System.Drawing.Point(348, 81);
            this.lblRejectState.Name = "lblRejectState";
            this.lblRejectState.Size = new System.Drawing.Size(72, 13);
            this.lblRejectState.TabIndex = 15;
            this.lblRejectState.Text = "[Reject State]";
            // 
            // lblSeperator4
            // 
            this.lblSeperator4.AutoSize = true;
            this.lblSeperator4.Location = new System.Drawing.Point(333, 81);
            this.lblSeperator4.Name = "lblSeperator4";
            this.lblSeperator4.Size = new System.Drawing.Size(9, 13);
            this.lblSeperator4.TabIndex = 14;
            this.lblSeperator4.Text = "|";
            // 
            // lblHaltState
            // 
            this.lblHaltState.AutoSize = true;
            this.lblHaltState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHaltState.Location = new System.Drawing.Point(267, 81);
            this.lblHaltState.Name = "lblHaltState";
            this.lblHaltState.Size = new System.Drawing.Size(60, 13);
            this.lblHaltState.TabIndex = 13;
            this.lblHaltState.Text = "[Halt State]";
            // 
            // lblSeperator3
            // 
            this.lblSeperator3.AutoSize = true;
            this.lblSeperator3.Location = new System.Drawing.Point(252, 81);
            this.lblSeperator3.Name = "lblSeperator3";
            this.lblSeperator3.Size = new System.Drawing.Size(9, 13);
            this.lblSeperator3.TabIndex = 12;
            this.lblSeperator3.Text = "|";
            // 
            // lblAcceptState
            // 
            this.lblAcceptState.AutoSize = true;
            this.lblAcceptState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAcceptState.Location = new System.Drawing.Point(171, 81);
            this.lblAcceptState.Name = "lblAcceptState";
            this.lblAcceptState.Size = new System.Drawing.Size(75, 13);
            this.lblAcceptState.TabIndex = 11;
            this.lblAcceptState.Text = "[Accept State]";
            // 
            // lblSeperator2
            // 
            this.lblSeperator2.AutoSize = true;
            this.lblSeperator2.Location = new System.Drawing.Point(156, 81);
            this.lblSeperator2.Name = "lblSeperator2";
            this.lblSeperator2.Size = new System.Drawing.Size(9, 13);
            this.lblSeperator2.TabIndex = 10;
            this.lblSeperator2.Text = "|";
            // 
            // lblNoStates
            // 
            this.lblNoStates.AutoSize = true;
            this.lblNoStates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNoStates.Location = new System.Drawing.Point(97, 81);
            this.lblNoStates.Name = "lblNoStates";
            this.lblNoStates.Size = new System.Drawing.Size(53, 13);
            this.lblNoStates.TabIndex = 9;
            this.lblNoStates.Text = "[# States]";
            // 
            // lblMachineDetails
            // 
            this.lblMachineDetails.AutoSize = true;
            this.lblMachineDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMachineDetails.Location = new System.Drawing.Point(5, 81);
            this.lblMachineDetails.Name = "lblMachineDetails";
            this.lblMachineDetails.Size = new System.Drawing.Size(86, 13);
            this.lblMachineDetails.TabIndex = 8;
            this.lblMachineDetails.Text = "Machine Details:";
            // 
            // btnEnterString
            // 
            this.btnEnterString.BackColor = System.Drawing.Color.Teal;
            this.btnEnterString.Enabled = false;
            this.btnEnterString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnterString.Location = new System.Drawing.Point(335, 43);
            this.btnEnterString.Name = "btnEnterString";
            this.btnEnterString.Size = new System.Drawing.Size(133, 23);
            this.btnEnterString.TabIndex = 6;
            this.btnEnterString.Text = "Enter String";
            this.btnEnterString.UseVisualStyleBackColor = false;
            this.btnEnterString.Click += new System.EventHandler(this.EnterInput);
            // 
            // txtInputString
            // 
            this.txtInputString.Enabled = false;
            this.txtInputString.Location = new System.Drawing.Point(90, 45);
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.Size = new System.Drawing.Size(231, 20);
            this.txtInputString.TabIndex = 4;
            this.txtInputString.TextChanged += new System.EventHandler(this.ValidateInput);
            // 
            // lblInputString
            // 
            this.lblInputString.AutoSize = true;
            this.lblInputString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInputString.Location = new System.Drawing.Point(20, 48);
            this.lblInputString.Name = "lblInputString";
            this.lblInputString.Size = new System.Drawing.Size(64, 13);
            this.lblInputString.TabIndex = 3;
            this.lblInputString.Text = "Input String:";
            // 
            // btnImportMachine
            // 
            this.btnImportMachine.BackColor = System.Drawing.Color.Teal;
            this.btnImportMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnImportMachine.Location = new System.Drawing.Point(335, 17);
            this.btnImportMachine.Name = "btnImportMachine";
            this.btnImportMachine.Size = new System.Drawing.Size(133, 23);
            this.btnImportMachine.TabIndex = 2;
            this.btnImportMachine.Text = "Import Machine";
            this.btnImportMachine.UseVisualStyleBackColor = false;
            this.btnImportMachine.Click += new System.EventHandler(this.ImportMachine);
            // 
            // txtInputMachine
            // 
            this.txtInputMachine.Location = new System.Drawing.Point(90, 19);
            this.txtInputMachine.Name = "txtInputMachine";
            this.txtInputMachine.Size = new System.Drawing.Size(231, 20);
            this.txtInputMachine.TabIndex = 1;
            // 
            // lblInputMachine
            // 
            this.lblInputMachine.AutoSize = true;
            this.lblInputMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInputMachine.Location = new System.Drawing.Point(6, 22);
            this.lblInputMachine.Name = "lblInputMachine";
            this.lblInputMachine.Size = new System.Drawing.Size(78, 13);
            this.lblInputMachine.TabIndex = 0;
            this.lblInputMachine.Text = "Input Machine:";
            // 
            // spcConsole
            // 
            this.spcConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcConsole.Location = new System.Drawing.Point(440, 0);
            this.spcConsole.Margin = new System.Windows.Forms.Padding(2);
            this.spcConsole.Name = "spcConsole";
            this.spcConsole.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcConsole.Panel1
            // 
            this.spcConsole.Panel1.Controls.Add(this.lbl_result);
            this.spcConsole.Panel1.Controls.Add(this.txtResultConsole);
            // 
            // spcConsole.Panel2
            // 
            this.spcConsole.Panel2.Controls.Add(this.txtLogConsole);
            this.spcConsole.Size = new System.Drawing.Size(221, 234);
            this.spcConsole.SplitterDistance = 72;
            this.spcConsole.SplitterWidth = 3;
            this.spcConsole.TabIndex = 1;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_result.Location = new System.Drawing.Point(39, 3);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(35, 13);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "label1";
            // 
            // txtResultConsole
            // 
            this.txtResultConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtResultConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResultConsole.Location = new System.Drawing.Point(0, 0);
            this.txtResultConsole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtResultConsole.Multiline = true;
            this.txtResultConsole.Name = "txtResultConsole";
            this.txtResultConsole.Size = new System.Drawing.Size(219, 70);
            this.txtResultConsole.TabIndex = 0;
            this.txtResultConsole.Text = "Result:";
            // 
            // txtLogConsole
            // 
            this.txtLogConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLogConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogConsole.Location = new System.Drawing.Point(0, 0);
            this.txtLogConsole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLogConsole.Multiline = true;
            this.txtLogConsole.Name = "txtLogConsole";
            this.txtLogConsole.Size = new System.Drawing.Size(219, 157);
            this.txtLogConsole.TabIndex = 0;
            this.txtLogConsole.Text = "Log:";
            // 
            // spcSimulate
            // 
            this.spcSimulate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcSimulate.Dock = System.Windows.Forms.DockStyle.Left;
            this.spcSimulate.Location = new System.Drawing.Point(0, 0);
            this.spcSimulate.Name = "spcSimulate";
            this.spcSimulate.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcSimulate.Panel1
            // 
            this.spcSimulate.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.spcSimulate.Panel1.Controls.Add(this.lblMachine);
            this.spcSimulate.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Machine_Paint);
            // 
            // spcSimulate.Panel2
            // 
            this.spcSimulate.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.spcSimulate.Panel2.Controls.Add(this.lblTape);
            this.spcSimulate.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Tape_Paint);
            this.spcSimulate.Size = new System.Drawing.Size(440, 234);
            this.spcSimulate.SplitterDistance = 120;
            this.spcSimulate.TabIndex = 0;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMachine.Location = new System.Drawing.Point(9, 9);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(51, 13);
            this.lblMachine.TabIndex = 0;
            this.lblMachine.Text = "Machine:";
            // 
            // lblTape
            // 
            this.lblTape.AutoSize = true;
            this.lblTape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTape.Location = new System.Drawing.Point(6, 9);
            this.lblTape.Name = "lblTape";
            this.lblTape.Size = new System.Drawing.Size(35, 13);
            this.lblTape.TabIndex = 0;
            this.lblTape.Text = "Tape:";
            // 
            // ofdMain
            // 
            this.ofdMain.Filter = "XML files|*.xml|Text files|*.txt";
            this.ofdMain.Title = "Open Machine File";
            // 
            // sfdMain
            // 
            this.sfdMain.Filter = "XML files|*.xml|Text files|*.txt";
            this.sfdMain.Title = "\"Save Machine File\"";
            // 
            // tm_Progress
            // 
            this.tm_Progress.Tick += new System.EventHandler(this.UpdateProgress);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(671, 401);
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Machine Readinator";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.grpSystemFunctions.ResumeLayout(false);
            this.grpMachineFunctions.ResumeLayout(false);
            this.grpMachineFunctions.PerformLayout();
            this.spcConsole.Panel1.ResumeLayout(false);
            this.spcConsole.Panel1.PerformLayout();
            this.spcConsole.Panel2.ResumeLayout(false);
            this.spcConsole.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcConsole)).EndInit();
            this.spcConsole.ResumeLayout(false);
            this.spcSimulate.Panel1.ResumeLayout(false);
            this.spcSimulate.Panel1.PerformLayout();
            this.spcSimulate.Panel2.ResumeLayout(false);
            this.spcSimulate.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcSimulate)).EndInit();
            this.spcSimulate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmView;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel tslblStatus;
        private System.Windows.Forms.ToolStripProgressBar tspbMain;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.GroupBox grpSystemFunctions;
        private System.Windows.Forms.GroupBox grpMachineFunctions;
        private System.Windows.Forms.Label lblRejectState;
        private System.Windows.Forms.Label lblSeperator4;
        private System.Windows.Forms.Label lblHaltState;
        private System.Windows.Forms.Label lblSeperator3;
        private System.Windows.Forms.Label lblAcceptState;
        private System.Windows.Forms.Label lblSeperator2;
        private System.Windows.Forms.Label lblNoStates;
        private System.Windows.Forms.Label lblMachineDetails;
        private System.Windows.Forms.Button btnEnterString;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Label lblInputString;
        private System.Windows.Forms.Button btnImportMachine;
        private System.Windows.Forms.TextBox txtInputMachine;
        private System.Windows.Forms.Label lblInputMachine;
        private System.Windows.Forms.Button btnResetState;
        private System.Windows.Forms.Button btnReadMachine;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangeString;
        private System.Windows.Forms.ToolStripMenuItem stsmImportMachine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stsmExit;
        private System.Windows.Forms.ToolStripMenuItem stsmChangeMachine;
        private System.Windows.Forms.ToolStripMenuItem stsmChangeString;
        private System.Windows.Forms.ToolStripMenuItem stsmMachine;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.SaveFileDialog sfdMain;
        private System.Windows.Forms.SplitContainer spcSimulate;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblTape;
        private System.Windows.Forms.SplitContainer spcConsole;
        private System.Windows.Forms.TextBox txtResultConsole;
        private System.Windows.Forms.TextBox txtLogConsole;
        private System.Windows.Forms.ToolStripMenuItem stsmExportMachine;
        private System.Windows.Forms.Timer tm_Progress;
        private System.Windows.Forms.Label lbl_result;
    }
}

