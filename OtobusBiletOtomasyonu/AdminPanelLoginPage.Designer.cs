namespace OtobusBiletOtomasyonu
{
    partial class AdminPanelLoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginBttn = new System.Windows.Forms.Button();
            this.aboutBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBttn = new System.Windows.Forms.Button();
            this.usernameTxtBos = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // loginBttn
            // 
            this.loginBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBttn.Location = new System.Drawing.Point(256, 228);
            this.loginBttn.Name = "loginBttn";
            this.loginBttn.Size = new System.Drawing.Size(84, 63);
            this.loginBttn.TabIndex = 2;
            this.loginBttn.Text = "LOGIN";
            this.loginBttn.UseVisualStyleBackColor = true;
            this.loginBttn.Click += new System.EventHandler(this.loginBttn_Click);
            // 
            // aboutBttn
            // 
            this.aboutBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBttn.Location = new System.Drawing.Point(45, 342);
            this.aboutBttn.Name = "aboutBttn";
            this.aboutBttn.Size = new System.Drawing.Size(95, 39);
            this.aboutBttn.TabIndex = 4;
            this.aboutBttn.Text = "ABOUT";
            this.aboutBttn.UseVisualStyleBackColor = true;
            this.aboutBttn.Click += new System.EventHandler(this.aboutBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola :";
            // 
            // exitBttn
            // 
            this.exitBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBttn.Location = new System.Drawing.Point(447, 342);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(95, 39);
            this.exitBttn.TabIndex = 5;
            this.exitBttn.Text = "EXIT";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // usernameTxtBos
            // 
            this.usernameTxtBos.Location = new System.Drawing.Point(296, 107);
            this.usernameTxtBos.Name = "usernameTxtBos";
            this.usernameTxtBos.Size = new System.Drawing.Size(138, 19);
            this.usernameTxtBos.TabIndex = 6;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(296, 157);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(138, 19);
            this.passwordTxtBox.TabIndex = 7;
            // 
            // AdminPanelLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 417);
            this.ControlBox = false;
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBos);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.aboutBttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBttn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminPanelLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBttn;
        private System.Windows.Forms.Button aboutBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.TextBox usernameTxtBos;
        private System.Windows.Forms.TextBox passwordTxtBox;
    }
}