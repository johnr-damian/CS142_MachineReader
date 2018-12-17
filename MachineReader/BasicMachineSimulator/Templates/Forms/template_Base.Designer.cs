namespace BasicMachineSimulator.Templates.Forms
{
    public partial class template_Base
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
            this.mnu_Main = new System.Windows.Forms.MenuStrip();
            this.sub_File = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.sts_Main = new System.Windows.Forms.StatusStrip();
            this.mnu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_Main
            // 
            this.mnu_Main.Font = new System.Drawing.Font("Calibri", 9F);
            this.mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_File,
            this.sub_Edit,
            this.sub_Help});
            this.mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.mnu_Main.Name = "mnu_Main";
            this.mnu_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnu_Main.Size = new System.Drawing.Size(734, 24);
            this.mnu_Main.TabIndex = 0;
            // 
            // sub_File
            // 
            this.sub_File.Name = "sub_File";
            this.sub_File.Size = new System.Drawing.Size(40, 20);
            this.sub_File.Text = "&File";
            // 
            // sub_Edit
            // 
            this.sub_Edit.Name = "sub_Edit";
            this.sub_Edit.Size = new System.Drawing.Size(40, 20);
            this.sub_Edit.Text = "&Edit";
            // 
            // sub_Help
            // 
            this.sub_Help.Name = "sub_Help";
            this.sub_Help.Size = new System.Drawing.Size(45, 20);
            this.sub_Help.Text = "&Help";
            // 
            // sts_Main
            // 
            this.sts_Main.Font = new System.Drawing.Font("Calibri", 9F);
            this.sts_Main.Location = new System.Drawing.Point(0, 439);
            this.sts_Main.Name = "sts_Main";
            this.sts_Main.Size = new System.Drawing.Size(734, 22);
            this.sts_Main.SizingGrip = false;
            this.sts_Main.TabIndex = 1;
            // 
            // template_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.sts_Main);
            this.Controls.Add(this.mnu_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.mnu_Main;
            this.MaximizeBox = false;
            this.Name = "template_Base";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Basic Machine Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.template_Base_FormClosing);
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        protected System.Windows.Forms.ToolStripMenuItem sub_File;
        protected System.Windows.Forms.ToolStripMenuItem sub_Edit;
        protected System.Windows.Forms.ToolStripMenuItem sub_Help;
        protected System.Windows.Forms.MenuStrip mnu_Main;
        protected System.Windows.Forms.StatusStrip sts_Main;
    }
}