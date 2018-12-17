namespace BasicMachineSimulator.Views.Title
{
    partial class title_BMS
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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Simulate = new System.Windows.Forms.Button();
            this.btn_Design = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.Linen;
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.btn_Design);
            this.pnl_Main.Controls.Add(this.btn_Simulate);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.Location = new System.Drawing.Point(8, 8);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_Main.Size = new System.Drawing.Size(218, 295);
            this.pnl_Main.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(70, 15);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(77, 33);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "BMS";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Simulate
            // 
            this.btn_Simulate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Simulate.Location = new System.Drawing.Point(37, 57);
            this.btn_Simulate.Name = "btn_Simulate";
            this.btn_Simulate.Size = new System.Drawing.Size(142, 30);
            this.btn_Simulate.TabIndex = 1;
            this.btn_Simulate.Text = "Simulate";
            this.btn_Simulate.UseVisualStyleBackColor = true;
            this.btn_Simulate.Click += new System.EventHandler(this.btn_Simulate_Click);
            // 
            // btn_Design
            // 
            this.btn_Design.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Design.Location = new System.Drawing.Point(37, 93);
            this.btn_Design.Name = "btn_Design";
            this.btn_Design.Size = new System.Drawing.Size(142, 30);
            this.btn_Design.TabIndex = 2;
            this.btn_Design.Text = "Design";
            this.btn_Design.UseVisualStyleBackColor = true;
            this.btn_Design.Click += new System.EventHandler(this.btn_Design_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(37, 233);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(142, 30);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // title_BMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "title_BMS";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Machine Simulator";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Design;
        private System.Windows.Forms.Button btn_Simulate;
    }
}