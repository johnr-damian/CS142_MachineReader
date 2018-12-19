using System;
using System.Reflection;
using System.Windows.Forms;

namespace BasicMachineSimulator.Views.Design
{
    partial class design_BMS
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

        /// <summary>
        /// Hard coded of adding submenu items for File menu item because menustrip
        /// can't be merged to the parent
        /// </summary>
        private void InitializeMenuStrip()
        {
            var file_itemcollection = new ToolStripItem[8];
            var edit_itemcollection = new ToolStripItem[3];

            //File
            var file_itemcollectionlength = file_itemcollection.Length;
            for(int iterator = 0, separator = 1; iterator < file_itemcollectionlength; iterator++)
            {
                switch (iterator)
                {
                    case 0:
                        file_itemcollection[iterator] = new ToolStripMenuItem("&New", null, filesub_New_Click);
                        file_itemcollection[iterator].Name = "filesub_New";
                        break;
                    case 1:
                        file_itemcollection[iterator] = new ToolStripMenuItem("&Open", null, filesub_Open_Click);
                        file_itemcollection[iterator].Name = "filesub_Open";
                        break;
                    case 3:
                        file_itemcollection[iterator] = new ToolStripMenuItem("&Save", null, filesub_Save_Click);
                        file_itemcollection[iterator].Name = "filesub_Save";
                        break;
                    case 4:
                        file_itemcollection[iterator] = new ToolStripMenuItem("Save &As...", null, filesub_SaveAs_Click);
                        file_itemcollection[iterator].Name = "filesub_SaveAs";
                        break;
                    case 6:
                        file_itemcollection[iterator] = new ToolStripMenuItem("&Close", null, (sender, e) => Close());
                        file_itemcollection[iterator].Name = "filesub_Close";
                        break;
                    case 7:
                        file_itemcollection[iterator] = new ToolStripMenuItem("&Exit", null, (sender, e) => Application.Exit());
                        file_itemcollection[iterator].Name = "filesub_Exit";
                        break;
                    default:
                        file_itemcollection[iterator] = new ToolStripSeparator();
                        file_itemcollection[iterator].Name = $"filesub_sp{separator}";
                        separator++;
                        break;
                }
            }

            //Edit
            var edit_itemcollectionlength = edit_itemcollection.Length;
            for(int iterator = 0; iterator < edit_itemcollectionlength; iterator++)
            {
                switch (iterator)
                {
                    case 0:
                        edit_itemcollection[iterator] = new ToolStripMenuItem("Clear &All", null, editsub_ClearAll_Click);
                        edit_itemcollection[iterator].Name = "editsub_ClearAll";
                        break;
                    case 1:
                        edit_itemcollection[iterator] = new ToolStripMenuItem("Clear &State", null, editsub_ClearStates_Click);
                        edit_itemcollection[iterator].Name = "editsub_ClearStates";
                        break;
                    case 2:
                        edit_itemcollection[iterator] = new ToolStripMenuItem("Clear &Transition", null, editsub_ClearTransitions_Click);
                        edit_itemcollection[iterator].Name = "editsub_ClearTransitions";
                        break;
                }
            }

            sub_File.DropDownItems.AddRange(file_itemcollection);
            sub_Edit.DropDownItems.AddRange(edit_itemcollection);
        }

        private void InitializeStatusStrip()
        {

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(design_BMS));
            this.tsc_Main = new System.Windows.Forms.ToolStripContainer();
            this.spc_Main = new System.Windows.Forms.SplitContainer();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.grpTuple = new System.Windows.Forms.GroupBox();
            this.btnValidateTuple = new System.Windows.Forms.Button();
            this.btnDefineRules = new System.Windows.Forms.Button();
            this.btnDefineTuple = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnValidateDetails = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.ts_Main = new System.Windows.Forms.ToolStrip();
            this.tsb_CreateState = new System.Windows.Forms.ToolStripButton();
            this.tsb_CreateTransition = new System.Windows.Forms.ToolStripButton();
            this.ts_sp1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_DeleteState = new System.Windows.Forms.ToolStripButton();
            this.tsb_DeleteTransition = new System.Windows.Forms.ToolStripButton();
            this.tsc_Main.ContentPanel.SuspendLayout();
            this.tsc_Main.TopToolStripPanel.SuspendLayout();
            this.tsc_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Main)).BeginInit();
            this.spc_Main.Panel1.SuspendLayout();
            this.spc_Main.Panel2.SuspendLayout();
            this.spc_Main.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.grpTuple.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.ts_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsc_Main
            // 
            // 
            // tsc_Main.BottomToolStripPanel
            // 
            this.tsc_Main.BottomToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // tsc_Main.ContentPanel
            // 
            this.tsc_Main.ContentPanel.Controls.Add(this.spc_Main);
            this.tsc_Main.ContentPanel.Size = new System.Drawing.Size(734, 390);
            this.tsc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // tsc_Main.LeftToolStripPanel
            // 
            this.tsc_Main.LeftToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsc_Main.Location = new System.Drawing.Point(0, 24);
            this.tsc_Main.Name = "tsc_Main";
            // 
            // tsc_Main.RightToolStripPanel
            // 
            this.tsc_Main.RightToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsc_Main.Size = new System.Drawing.Size(734, 415);
            this.tsc_Main.TabIndex = 2;
            this.tsc_Main.Text = "toolStripContainer1";
            // 
            // tsc_Main.TopToolStripPanel
            // 
            this.tsc_Main.TopToolStripPanel.Controls.Add(this.ts_Main);
            this.tsc_Main.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // spc_Main
            // 
            this.spc_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spc_Main.IsSplitterFixed = true;
            this.spc_Main.Location = new System.Drawing.Point(0, 0);
            this.spc_Main.Name = "spc_Main";
            // 
            // spc_Main.Panel1
            // 
            this.spc_Main.Panel1.Controls.Add(this.pnlDescription);
            this.spc_Main.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // spc_Main.Panel2
            // 
            this.spc_Main.Panel2.Controls.Add(this.pnlCanvas);
            this.spc_Main.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.spc_Main.Size = new System.Drawing.Size(734, 390);
            this.spc_Main.SplitterDistance = 196;
            this.spc_Main.TabIndex = 0;
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.Linen;
            this.pnlDescription.Controls.Add(this.grpTuple);
            this.pnlDescription.Controls.Add(this.grpDetails);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(5, 5);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(184, 378);
            this.pnlDescription.TabIndex = 0;
            // 
            // grpTuple
            // 
            this.grpTuple.Controls.Add(this.btnValidateTuple);
            this.grpTuple.Controls.Add(this.btnDefineRules);
            this.grpTuple.Controls.Add(this.btnDefineTuple);
            this.grpTuple.Enabled = false;
            this.grpTuple.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTuple.Location = new System.Drawing.Point(6, 268);
            this.grpTuple.Name = "grpTuple";
            this.grpTuple.Size = new System.Drawing.Size(175, 107);
            this.grpTuple.TabIndex = 1;
            this.grpTuple.TabStop = false;
            this.grpTuple.Text = "Tuple:";
            // 
            // btnValidateTuple
            // 
            this.btnValidateTuple.Enabled = false;
            this.btnValidateTuple.Location = new System.Drawing.Point(57, 79);
            this.btnValidateTuple.Name = "btnValidateTuple";
            this.btnValidateTuple.Size = new System.Drawing.Size(112, 23);
            this.btnValidateTuple.TabIndex = 2;
            this.btnValidateTuple.Text = "Validate";
            this.btnValidateTuple.UseVisualStyleBackColor = true;
            this.btnValidateTuple.Click += new System.EventHandler(this.btnValidateTuple_Click);
            // 
            // btnDefineRules
            // 
            this.btnDefineRules.Enabled = false;
            this.btnDefineRules.Location = new System.Drawing.Point(6, 50);
            this.btnDefineRules.Name = "btnDefineRules";
            this.btnDefineRules.Size = new System.Drawing.Size(163, 23);
            this.btnDefineRules.TabIndex = 1;
            this.btnDefineRules.Text = "Define Rules";
            this.btnDefineRules.UseVisualStyleBackColor = true;
            this.btnDefineRules.Click += new System.EventHandler(this.btnDefineRules_Click);
            // 
            // btnDefineTuple
            // 
            this.btnDefineTuple.Location = new System.Drawing.Point(6, 21);
            this.btnDefineTuple.Name = "btnDefineTuple";
            this.btnDefineTuple.Size = new System.Drawing.Size(163, 23);
            this.btnDefineTuple.TabIndex = 0;
            this.btnDefineTuple.Text = "Define Tuple";
            this.btnDefineTuple.UseVisualStyleBackColor = true;
            this.btnDefineTuple.Click += new System.EventHandler(this.btnDefineTuple_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.btnValidateDetails);
            this.grpDetails.Controls.Add(this.txtAuthor);
            this.grpDetails.Controls.Add(this.lblAuthor);
            this.grpDetails.Controls.Add(this.txtDescription);
            this.grpDetails.Controls.Add(this.lblDescription);
            this.grpDetails.Controls.Add(this.txtLanguage);
            this.grpDetails.Controls.Add(this.lblLanguage);
            this.grpDetails.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(6, 3);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(175, 259);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details:";
            // 
            // btnValidateDetails
            // 
            this.btnValidateDetails.Location = new System.Drawing.Point(57, 230);
            this.btnValidateDetails.Name = "btnValidateDetails";
            this.btnValidateDetails.Size = new System.Drawing.Size(112, 23);
            this.btnValidateDetails.TabIndex = 6;
            this.btnValidateDetails.Text = "Validate";
            this.btnValidateDetails.UseVisualStyleBackColor = true;
            this.btnValidateDetails.Click += new System.EventHandler(this.btnValidateDetails_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(9, 188);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(160, 22);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(6, 171);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 14);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 77);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(160, 91);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 14);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(9, 35);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(160, 22);
            this.txtLanguage.TabIndex = 1;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(6, 18);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(112, 14);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Machine Language:";
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.Linen;
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(5, 5);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(522, 378);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // ts_Main
            // 
            this.ts_Main.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_Main.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_CreateState,
            this.tsb_CreateTransition,
            this.ts_sp1,
            this.tsb_DeleteState,
            this.tsb_DeleteTransition});
            this.ts_Main.Location = new System.Drawing.Point(0, 0);
            this.ts_Main.Name = "ts_Main";
            this.ts_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_Main.Size = new System.Drawing.Size(734, 25);
            this.ts_Main.Stretch = true;
            this.ts_Main.TabIndex = 0;
            // 
            // tsb_CreateState
            // 
            this.tsb_CreateState.Image = ((System.Drawing.Image)(resources.GetObject("tsb_CreateState.Image")));
            this.tsb_CreateState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_CreateState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_CreateState.Name = "tsb_CreateState";
            this.tsb_CreateState.Size = new System.Drawing.Size(93, 22);
            this.tsb_CreateState.Text = "Create State";
            // 
            // tsb_CreateTransition
            // 
            this.tsb_CreateTransition.Image = ((System.Drawing.Image)(resources.GetObject("tsb_CreateTransition.Image")));
            this.tsb_CreateTransition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_CreateTransition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_CreateTransition.Name = "tsb_CreateTransition";
            this.tsb_CreateTransition.Size = new System.Drawing.Size(119, 22);
            this.tsb_CreateTransition.Text = "Create Transition";
            // 
            // ts_sp1
            // 
            this.ts_sp1.Name = "ts_sp1";
            this.ts_sp1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_DeleteState
            // 
            this.tsb_DeleteState.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DeleteState.Image")));
            this.tsb_DeleteState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_DeleteState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DeleteState.Name = "tsb_DeleteState";
            this.tsb_DeleteState.Size = new System.Drawing.Size(95, 22);
            this.tsb_DeleteState.Text = "Delete State";
            // 
            // tsb_DeleteTransition
            // 
            this.tsb_DeleteTransition.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DeleteTransition.Image")));
            this.tsb_DeleteTransition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsb_DeleteTransition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DeleteTransition.Name = "tsb_DeleteTransition";
            this.tsb_DeleteTransition.Size = new System.Drawing.Size(121, 22);
            this.tsb_DeleteTransition.Text = "Delete Transition";
            // 
            // design_BMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.tsc_Main);
            this.Name = "design_BMS";
            this.Controls.SetChildIndex(this.tsc_Main, 0);
            this.tsc_Main.ContentPanel.ResumeLayout(false);
            this.tsc_Main.TopToolStripPanel.ResumeLayout(false);
            this.tsc_Main.TopToolStripPanel.PerformLayout();
            this.tsc_Main.ResumeLayout(false);
            this.tsc_Main.PerformLayout();
            this.spc_Main.Panel1.ResumeLayout(false);
            this.spc_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Main)).EndInit();
            this.spc_Main.ResumeLayout(false);
            this.pnlDescription.ResumeLayout(false);
            this.grpTuple.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ts_Main.ResumeLayout(false);
            this.ts_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripContainer tsc_Main;
        private SplitContainer spc_Main;
        private ToolStrip ts_Main;
        private ToolStripButton tsb_CreateState;
        private ToolStripButton tsb_CreateTransition;
        private ToolStripSeparator ts_sp1;
        private ToolStripButton tsb_DeleteState;
        private ToolStripButton tsb_DeleteTransition;
        private Panel pnlDescription;
        private Panel pnlCanvas;
        private GroupBox grpDetails;
        private Label lblLanguage;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtLanguage;
        private TextBox txtAuthor;
        private Label lblAuthor;
        private Button btnValidateDetails;
        private GroupBox grpTuple;
        private Button btnValidateTuple;
        private Button btnDefineRules;
        private Button btnDefineTuple;
    }
}
