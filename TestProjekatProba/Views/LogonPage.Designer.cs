
namespace TestProjekatProba.Views
{
    partial class LogonPage
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.paswordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnLogin.Location = new System.Drawing.Point(398, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(183, 47);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtBoxPass.Location = new System.Drawing.Point(398, 190);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(185, 35);
            this.txtBoxPass.TabIndex = 13;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtBoxUsername.Location = new System.Drawing.Point(398, 128);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(185, 35);
            this.txtBoxUsername.TabIndex = 12;
            // 
            // paswordLabel
            // 
            this.paswordLabel.AutoSize = true;
            this.paswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.paswordLabel.Location = new System.Drawing.Point(217, 193);
            this.paswordLabel.Name = "paswordLabel";
            this.paswordLabel.Size = new System.Drawing.Size(124, 29);
            this.paswordLabel.TabIndex = 11;
            this.paswordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.usernameLabel.Location = new System.Drawing.Point(217, 135);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(130, 29);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Username";
            // 
            // LogonPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.paswordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "LogonPage";
            this.Text = "LogonPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label paswordLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}