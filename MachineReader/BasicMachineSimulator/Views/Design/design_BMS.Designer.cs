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
            this.ts_Main = new System.Windows.Forms.ToolStrip();
            this.spc_Main = new System.Windows.Forms.SplitContainer();
            this.tsb_CreateState = new System.Windows.Forms.ToolStripButton();
            this.tsb_CreateTransition = new System.Windows.Forms.ToolStripButton();
            this.ts_sp1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_DeleteState = new System.Windows.Forms.ToolStripButton();
            this.tsb_DeleteTransition = new System.Windows.Forms.ToolStripButton();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.tsc_Main.ContentPanel.SuspendLayout();
            this.tsc_Main.TopToolStripPanel.SuspendLayout();
            this.tsc_Main.SuspendLayout();
            this.ts_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Main)).BeginInit();
            this.spc_Main.Panel1.SuspendLayout();
            this.spc_Main.Panel2.SuspendLayout();
            this.spc_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsc_Main
            // 
            // 
            // tsc_Main.tspnl_Bottom
            // 
            this.tsc_Main.BottomToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // tsc_Main.ContentPanel
            // 
            this.tsc_Main.ContentPanel.Controls.Add(this.spc_Main);
            this.tsc_Main.ContentPanel.Size = new System.Drawing.Size(734, 390);
            this.tsc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // tsc_Main.tspnl_Left
            // 
            this.tsc_Main.LeftToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsc_Main.Location = new System.Drawing.Point(0, 24);
            this.tsc_Main.Name = "tsc_Main";
            // 
            // tsc_Main.tspnl_Right
            // 
            this.tsc_Main.RightToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsc_Main.Size = new System.Drawing.Size(734, 415);
            this.tsc_Main.TabIndex = 2;
            this.tsc_Main.Text = "toolStripContainer1";
            // 
            // tsc_Main.tspnl_Top
            // 
            this.tsc_Main.TopToolStripPanel.Controls.Add(this.ts_Main);
            this.tsc_Main.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
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
            // spc_Main
            // 
            this.spc_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.Linen;
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(5, 5);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(184, 378);
            this.pnlDescription.TabIndex = 0;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.Linen;
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(5, 5);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(522, 378);
            this.pnlCanvas.TabIndex = 0;
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
            this.ts_Main.ResumeLayout(false);
            this.ts_Main.PerformLayout();
            this.spc_Main.Panel1.ResumeLayout(false);
            this.spc_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Main)).EndInit();
            this.spc_Main.ResumeLayout(false);
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
    }
}
