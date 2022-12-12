namespace WindowsApp.Forms.RegisterForms
{
    partial class UserSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSearchForm));
            this.dgvSearchUserForm = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegistroInform = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchUserForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchUserForm
            // 
            this.dgvSearchUserForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchUserForm.Location = new System.Drawing.Point(9, 117);
            this.dgvSearchUserForm.Name = "dgvSearchUserForm";
            this.dgvSearchUserForm.RowTemplate.Height = 25;
            this.dgvSearchUserForm.Size = new System.Drawing.Size(501, 266);
            this.dgvSearchUserForm.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblRegistroInform
            // 
            this.lblRegistroInform.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblRegistroInform.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistroInform.Location = new System.Drawing.Point(59, 33);
            this.lblRegistroInform.Name = "lblRegistroInform";
            this.lblRegistroInform.Size = new System.Drawing.Size(410, 48);
            this.lblRegistroInform.TabIndex = 15;
            this.lblRegistroInform.Text = "LISTAGEM - USUÁRIOS";
            this.lblRegistroInform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 388);
            this.Controls.Add(this.lblRegistroInform);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSearchUserForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search User";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchUserForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvSearchUserForm;
        private PictureBox pictureBox1;
        private Label lblRegistroInform;
    }
}