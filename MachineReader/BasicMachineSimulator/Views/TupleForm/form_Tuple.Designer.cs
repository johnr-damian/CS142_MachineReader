namespace BasicMachineSimulator.Views.TupleForm
{
    partial class form_Tuple
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtAcceptStates = new System.Windows.Forms.TextBox();
            this.lblAcceptStates = new System.Windows.Forms.Label();
            this.txtStartState = new System.Windows.Forms.TextBox();
            this.lblStartState = new System.Windows.Forms.Label();
            this.txtAlphabets = new System.Windows.Forms.TextBox();
            this.lblAlphabets = new System.Windows.Forms.Label();
            this.txtStates = new System.Windows.Forms.TextBox();
            this.lblStates = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Linen;
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnApply);
            this.pnlMain.Controls.Add(this.txtAcceptStates);
            this.pnlMain.Controls.Add(this.lblAcceptStates);
            this.pnlMain.Controls.Add(this.txtStartState);
            this.pnlMain.Controls.Add(this.lblStartState);
            this.pnlMain.Controls.Add(this.txtAlphabets);
            this.pnlMain.Controls.Add(this.lblAlphabets);
            this.pnlMain.Controls.Add(this.txtStates);
            this.pnlMain.Controls.Add(this.lblStates);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(358, 227);
            this.pnlMain.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(163, 201);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(93, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtAcceptStates
            // 
            this.txtAcceptStates.Location = new System.Drawing.Point(15, 142);
            this.txtAcceptStates.Name = "txtAcceptStates";
            this.txtAcceptStates.Size = new System.Drawing.Size(328, 20);
            this.txtAcceptStates.TabIndex = 7;
            // 
            // lblAcceptStates
            // 
            this.lblAcceptStates.AutoSize = true;
            this.lblAcceptStates.Location = new System.Drawing.Point(3, 126);
            this.lblAcceptStates.Name = "lblAcceptStates";
            this.lblAcceptStates.Size = new System.Drawing.Size(77, 13);
            this.lblAcceptStates.TabIndex = 6;
            this.lblAcceptStates.Text = "Accept States:";
            // 
            // txtStartState
            // 
            this.txtStartState.Location = new System.Drawing.Point(15, 103);
            this.txtStartState.Name = "txtStartState";
            this.txtStartState.Size = new System.Drawing.Size(88, 20);
            this.txtStartState.TabIndex = 5;
            // 
            // lblStartState
            // 
            this.lblStartState.AutoSize = true;
            this.lblStartState.Location = new System.Drawing.Point(3, 87);
            this.lblStartState.Name = "lblStartState";
            this.lblStartState.Size = new System.Drawing.Size(60, 13);
            this.lblStartState.TabIndex = 4;
            this.lblStartState.Text = "Start State:";
            // 
            // txtAlphabets
            // 
            this.txtAlphabets.Location = new System.Drawing.Point(15, 64);
            this.txtAlphabets.Name = "txtAlphabets";
            this.txtAlphabets.Size = new System.Drawing.Size(328, 20);
            this.txtAlphabets.TabIndex = 3;
            // 
            // lblAlphabets
            // 
            this.lblAlphabets.AutoSize = true;
            this.lblAlphabets.Location = new System.Drawing.Point(3, 48);
            this.lblAlphabets.Name = "lblAlphabets";
            this.lblAlphabets.Size = new System.Drawing.Size(164, 13);
            this.lblAlphabets.TabIndex = 2;
            this.lblAlphabets.Text = "Alphabets (separated by comma):";
            // 
            // txtStates
            // 
            this.txtStates.Location = new System.Drawing.Point(15, 25);
            this.txtStates.Name = "txtStates";
            this.txtStates.Size = new System.Drawing.Size(328, 20);
            this.txtStates.TabIndex = 1;
            // 
            // lblStates
            // 
            this.lblStates.AutoSize = true;
            this.lblStates.Location = new System.Drawing.Point(3, 9);
            this.lblStates.Name = "lblStates";
            this.lblStates.Size = new System.Drawing.Size(150, 13);
            this.lblStates.TabIndex = 0;
            this.lblStates.Text = "States (separated by comma): ";
            // 
            // form_Tuple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(382, 251);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_Tuple";
            this.Text = "Tuple Definition";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtStates;
        private System.Windows.Forms.Label lblStates;
        private System.Windows.Forms.Label lblAlphabets;
        private System.Windows.Forms.TextBox txtStartState;
        private System.Windows.Forms.Label lblStartState;
        private System.Windows.Forms.TextBox txtAlphabets;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtAcceptStates;
        private System.Windows.Forms.Label lblAcceptStates;
    }
}