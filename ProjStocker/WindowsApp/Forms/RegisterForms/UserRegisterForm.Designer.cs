namespace WindowsApp.Forms
{
    partial class UserRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegisterForm));
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbRemove = new System.Windows.Forms.Button();
            this.txbCancel = new System.Windows.Forms.Button();
            this.lblRegistroInform = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(89, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "NOME:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(89, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 23);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(89, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "SENHA:";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbName.Location = new System.Drawing.Point(210, 117);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(440, 22);
            this.txbName.TabIndex = 4;
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEmail.Location = new System.Drawing.Point(210, 148);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(440, 22);
            this.txbEmail.TabIndex = 5;
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassword.Location = new System.Drawing.Point(210, 178);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(440, 22);
            this.txbPassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(325, 210);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 36);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(673, 264);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txbRemove
            // 
            this.txbRemove.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbRemove.Location = new System.Drawing.Point(125, 210);
            this.txbRemove.Name = "txbRemove";
            this.txbRemove.Size = new System.Drawing.Size(111, 36);
            this.txbRemove.TabIndex = 12;
            this.txbRemove.Text = "Remover";
            this.txbRemove.UseVisualStyleBackColor = true;
            this.txbRemove.Click += new System.EventHandler(this.txbRemove_Click);
            // 
            // txbCancel
            // 
            this.txbCancel.Enabled = false;
            this.txbCancel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCancel.Location = new System.Drawing.Point(520, 210);
            this.txbCancel.Name = "txbCancel";
            this.txbCancel.Size = new System.Drawing.Size(111, 36);
            this.txbCancel.TabIndex = 13;
            this.txbCancel.Text = "Cancelar";
            this.txbCancel.UseVisualStyleBackColor = true;
            // 
            // lblRegistroInform
            // 
            this.lblRegistroInform.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblRegistroInform.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistroInform.Location = new System.Drawing.Point(207, 26);
            this.lblRegistroInform.Name = "lblRegistroInform";
            this.lblRegistroInform.Size = new System.Drawing.Size(327, 48);
            this.lblRegistroInform.TabIndex = 14;
            this.lblRegistroInform.Text = "REGISTRO";
            this.lblRegistroInform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 528);
            this.Controls.Add(this.lblRegistroInform);
            this.Controls.Add(this.txbCancel);
            this.Controls.Add(this.txbRemove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocker - REGISTRO";
            this.Shown += new System.EventHandler(this.UserRegisterForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txbName;
        private TextBox txbEmail;
        private TextBox txbPassword;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button txbRemove;
        private Button txbCancel;
        private Label lblRegistroInform;
    }
}