
namespace WindowsApp
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showPassBtn = new System.Windows.Forms.Button();
            this.warnLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.showPassBtn);
            this.splitContainer1.Panel2.Controls.Add(this.warnLabel);
            this.splitContainer1.Panel2.Controls.Add(this.passLabel);
            this.splitContainer1.Panel2.Controls.Add(this.loginLabel);
            this.splitContainer1.Panel2.Controls.Add(this.passText);
            this.splitContainer1.Panel2.Controls.Add(this.loginText);
            this.splitContainer1.Panel2.Controls.Add(this.authButton);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(496, 241);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsApp.Properties.Resources.gibdd_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Госавтоинспекция\r\nМВД России";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showPassBtn
            // 
            this.showPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPassBtn.Location = new System.Drawing.Point(390, 53);
            this.showPassBtn.Name = "showPassBtn";
            this.showPassBtn.Size = new System.Drawing.Size(94, 27);
            this.showPassBtn.TabIndex = 11;
            this.showPassBtn.Text = "Показать";
            this.showPassBtn.UseVisualStyleBackColor = true;
            this.showPassBtn.MouseLeave += new System.EventHandler(this.showPassBtn_MouseLeave);
            this.showPassBtn.MouseHover += new System.EventHandler(this.showPassBtn_MouseHover);
            // 
            // warnLabel
            // 
            this.warnLabel.AutoSize = true;
            this.warnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warnLabel.Location = new System.Drawing.Point(86, 85);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(0, 13);
            this.warnLabel.TabIndex = 10;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(16, 56);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(67, 20);
            this.passLabel.TabIndex = 9;
            this.passLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(28, 24);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(55, 20);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Логин";
            // 
            // passText
            // 
            this.passText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passText.Location = new System.Drawing.Point(89, 53);
            this.passText.MaxLength = 30;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(295, 26);
            this.passText.TabIndex = 7;
            this.passText.Text = "inspector";
            // 
            // loginText
            // 
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginText.Location = new System.Drawing.Point(89, 21);
            this.loginText.MaxLength = 30;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(395, 26);
            this.loginText.TabIndex = 6;
            this.loginText.Text = "inspector";
            // 
            // authButton
            // 
            this.authButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authButton.Location = new System.Drawing.Point(12, 101);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(472, 36);
            this.authButton.TabIndex = 5;
            this.authButton.Text = "Войти";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 241);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(512, 280);
            this.MinimumSize = new System.Drawing.Size(512, 280);
            this.Name = "Auth";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Авторизация в системе";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Label warnLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button showPassBtn;
    }
}

