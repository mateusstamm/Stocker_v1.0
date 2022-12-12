namespace WindowsApp.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInform1 = new System.Windows.Forms.Label();
            this.lblInform2 = new System.Windows.Forms.Label();
            this.lblInform3 = new System.Windows.Forms.Label();
            this.lblInform4 = new System.Windows.Forms.Label();
            this.lblInform5 = new System.Windows.Forms.Label();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(24, 239);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(129, 39);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(24, 299);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(128, 39);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "SENHA:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEmail.Location = new System.Drawing.Point(168, 239);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(360, 41);
            this.txbEmail.TabIndex = 2;
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassword.Location = new System.Drawing.Point(168, 299);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(360, 41);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(309, 386);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 68);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Logar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(91, 386);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(157, 68);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblInform1
            // 
            this.lblInform1.AutoSize = true;
            this.lblInform1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInform1.Location = new System.Drawing.Point(13, 51);
            this.lblInform1.Name = "lblInform1";
            this.lblInform1.Size = new System.Drawing.Size(155, 25);
            this.lblInform1.TabIndex = 8;
            this.lblInform1.Text = "Stocker System";
            // 
            // lblInform2
            // 
            this.lblInform2.AutoSize = true;
            this.lblInform2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInform2.Location = new System.Drawing.Point(22, 94);
            this.lblInform2.Name = "lblInform2";
            this.lblInform2.Size = new System.Drawing.Size(136, 25);
            this.lblInform2.TabIndex = 9;
            this.lblInform2.Text = "UTFPR/2022";
            // 
            // lblInform3
            // 
            this.lblInform3.AutoSize = true;
            this.lblInform3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInform3.Location = new System.Drawing.Point(30, 134);
            this.lblInform3.Name = "lblInform3";
            this.lblInform3.Size = new System.Drawing.Size(111, 25);
            this.lblInform3.TabIndex = 10;
            this.lblInform3.Text = "POO - CC";
            // 
            // lblInform4
            // 
            this.lblInform4.AutoSize = true;
            this.lblInform4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInform4.Location = new System.Drawing.Point(438, 67);
            this.lblInform4.Name = "lblInform4";
            this.lblInform4.Size = new System.Drawing.Size(103, 25);
            this.lblInform4.TabIndex = 11;
            this.lblInform4.Text = "MATEUS";
            // 
            // lblInform5
            // 
            this.lblInform5.AutoSize = true;
            this.lblInform5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInform5.Location = new System.Drawing.Point(442, 99);
            this.lblInform5.Name = "lblInform5";
            this.lblInform5.Size = new System.Drawing.Size(92, 25);
            this.lblInform5.TabIndex = 12;
            this.lblInform5.Text = "STAMM";
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPassword.Location = new System.Drawing.Point(165, 346);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(112, 21);
            this.checkBoxPassword.TabIndex = 13;
            this.checkBoxPassword.Text = "Mostrar Senha";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 479);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.lblInform5);
            this.Controls.Add(this.lblInform4);
            this.Controls.Add(this.lblInform3);
            this.Controls.Add(this.lblInform2);
            this.Controls.Add(this.lblInform1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocker - LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private TextBox txbEmail;
        private TextBox txbPassword;
        private Button btnLogin;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Label lblInform1;
        private Label lblInform2;
        private Label lblInform3;
        private Label lblInform4;
        private Label lblInform5;
        private CheckBox checkBoxPassword;
    }
}