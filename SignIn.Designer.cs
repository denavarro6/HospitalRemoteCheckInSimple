namespace HospitalRemoteCheckInSimple
{
    partial class SignIn
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
            this.adminRButton = new System.Windows.Forms.RadioButton();
            this.patientRbutton = new System.Windows.Forms.RadioButton();
            this.selectionLabal = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.UserLab = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminRButton
            // 
            this.adminRButton.AutoSize = true;
            this.adminRButton.Location = new System.Drawing.Point(89, 35);
            this.adminRButton.Name = "adminRButton";
            this.adminRButton.Size = new System.Drawing.Size(57, 17);
            this.adminRButton.TabIndex = 0;
            this.adminRButton.TabStop = true;
            this.adminRButton.Text = "Doctor";
            this.adminRButton.UseVisualStyleBackColor = true;
            this.adminRButton.CheckedChanged += new System.EventHandler(this.adminRbutton_CheckedChanged);
            // 
            // patientRbutton
            // 
            this.patientRbutton.AutoSize = true;
            this.patientRbutton.Location = new System.Drawing.Point(89, 58);
            this.patientRbutton.Name = "patientRbutton";
            this.patientRbutton.Size = new System.Drawing.Size(58, 17);
            this.patientRbutton.TabIndex = 1;
            this.patientRbutton.TabStop = true;
            this.patientRbutton.Text = "Patient";
            this.patientRbutton.UseVisualStyleBackColor = true;
            // 
            // selectionLabal
            // 
            this.selectionLabal.AutoSize = true;
            this.selectionLabal.Location = new System.Drawing.Point(28, 37);
            this.selectionLabal.Name = "selectionLabal";
            this.selectionLabal.Size = new System.Drawing.Size(55, 13);
            this.selectionLabal.TabIndex = 2;
            this.selectionLabal.Text = "Are you a:";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(89, 116);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 20);
            this.userText.TabIndex = 3;
            this.userText.Visible = false;
            // 
            // UserLab
            // 
            this.UserLab.AutoSize = true;
            this.UserLab.Location = new System.Drawing.Point(28, 119);
            this.UserLab.Name = "UserLab";
            this.UserLab.Size = new System.Drawing.Size(58, 13);
            this.UserLab.TabIndex = 4;
            this.UserLab.Text = "Username:";
            this.UserLab.Visible = false;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(28, 145);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(56, 13);
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Password:";
            this.passLabel.Visible = false;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(89, 142);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(100, 20);
            this.passText.TabIndex = 5;
            this.passText.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(89, 205);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Proceed";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(241, 240);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.UserLab);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.selectionLabal);
            this.Controls.Add(this.patientRbutton);
            this.Controls.Add(this.adminRButton);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton adminRButton;
        private System.Windows.Forms.RadioButton patientRbutton;
        private System.Windows.Forms.Label selectionLabal;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label UserLab;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button submitButton;
    }
}