namespace BasicMachineSimulator.Views.RuleForm
{
    partial class form_Rule
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
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.txtCurrentState = new System.Windows.Forms.TextBox();
            this.lblOnRead = new System.Windows.Forms.Label();
            this.txtOnRead = new System.Windows.Forms.TextBox();
            this.lblThenWrite = new System.Windows.Forms.Label();
            this.txtThenWrite = new System.Windows.Forms.TextBox();
            this.lblTapeDirection = new System.Windows.Forms.Label();
            this.cmbTapeDirection = new System.Windows.Forms.ComboBox();
            this.lblNextState = new System.Windows.Forms.Label();
            this.txtNextState = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.Location = new System.Drawing.Point(12, 15);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(75, 13);
            this.lblCurrentState.TabIndex = 0;
            this.lblCurrentState.Text = "Rule for State:";
            // 
            // txtCurrentState
            // 
            this.txtCurrentState.Location = new System.Drawing.Point(93, 12);
            this.txtCurrentState.Name = "txtCurrentState";
            this.txtCurrentState.Size = new System.Drawing.Size(90, 20);
            this.txtCurrentState.TabIndex = 1;
            // 
            // lblOnRead
            // 
            this.lblOnRead.AutoSize = true;
            this.lblOnRead.Location = new System.Drawing.Point(34, 41);
            this.lblOnRead.Name = "lblOnRead";
            this.lblOnRead.Size = new System.Drawing.Size(53, 13);
            this.lblOnRead.TabIndex = 2;
            this.lblOnRead.Text = "On Read:";
            // 
            // txtOnRead
            // 
            this.txtOnRead.Location = new System.Drawing.Point(93, 38);
            this.txtOnRead.Name = "txtOnRead";
            this.txtOnRead.Size = new System.Drawing.Size(90, 20);
            this.txtOnRead.TabIndex = 3;
            // 
            // lblThenWrite
            // 
            this.lblThenWrite.AutoSize = true;
            this.lblThenWrite.Location = new System.Drawing.Point(24, 67);
            this.lblThenWrite.Name = "lblThenWrite";
            this.lblThenWrite.Size = new System.Drawing.Size(63, 13);
            this.lblThenWrite.TabIndex = 4;
            this.lblThenWrite.Text = "Then Write:";
            // 
            // txtThenWrite
            // 
            this.txtThenWrite.Location = new System.Drawing.Point(93, 64);
            this.txtThenWrite.Name = "txtThenWrite";
            this.txtThenWrite.Size = new System.Drawing.Size(90, 20);
            this.txtThenWrite.TabIndex = 5;
            // 
            // lblTapeDirection
            // 
            this.lblTapeDirection.AutoSize = true;
            this.lblTapeDirection.Location = new System.Drawing.Point(7, 93);
            this.lblTapeDirection.Name = "lblTapeDirection";
            this.lblTapeDirection.Size = new System.Drawing.Size(80, 13);
            this.lblTapeDirection.TabIndex = 6;
            this.lblTapeDirection.Text = "Tape Direction:";
            // 
            // cmbTapeDirection
            // 
            this.cmbTapeDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTapeDirection.FormattingEnabled = true;
            this.cmbTapeDirection.Items.AddRange(new object[] {
            "L",
            "R"});
            this.cmbTapeDirection.Location = new System.Drawing.Point(93, 90);
            this.cmbTapeDirection.Name = "cmbTapeDirection";
            this.cmbTapeDirection.Size = new System.Drawing.Size(90, 21);
            this.cmbTapeDirection.TabIndex = 7;
            // 
            // lblNextState
            // 
            this.lblNextState.AutoSize = true;
            this.lblNextState.Location = new System.Drawing.Point(27, 120);
            this.lblNextState.Name = "lblNextState";
            this.lblNextState.Size = new System.Drawing.Size(60, 13);
            this.lblNextState.TabIndex = 8;
            this.lblNextState.Text = "Next State:";
            // 
            // txtNextState
            // 
            this.txtNextState.Location = new System.Drawing.Point(93, 117);
            this.txtNextState.Name = "txtNextState";
            this.txtNextState.Size = new System.Drawing.Size(90, 20);
            this.txtNextState.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnComplete.Location = new System.Drawing.Point(36, 178);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 11;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(117, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "button2";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // form_Rule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(204, 213);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNextState);
            this.Controls.Add(this.lblNextState);
            this.Controls.Add(this.cmbTapeDirection);
            this.Controls.Add(this.lblTapeDirection);
            this.Controls.Add(this.txtThenWrite);
            this.Controls.Add(this.lblThenWrite);
            this.Controls.Add(this.txtOnRead);
            this.Controls.Add(this.lblOnRead);
            this.Controls.Add(this.txtCurrentState);
            this.Controls.Add(this.lblCurrentState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_Rule";
            this.Text = "Rule Definition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.TextBox txtCurrentState;
        private System.Windows.Forms.Label lblOnRead;
        private System.Windows.Forms.TextBox txtOnRead;
        private System.Windows.Forms.Label lblThenWrite;
        private System.Windows.Forms.TextBox txtThenWrite;
        private System.Windows.Forms.Label lblTapeDirection;
        private System.Windows.Forms.ComboBox cmbTapeDirection;
        private System.Windows.Forms.Label lblNextState;
        private System.Windows.Forms.TextBox txtNextState;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancel;
    }
}