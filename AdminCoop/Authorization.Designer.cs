namespace AdminCoop
{
    partial class Authorization
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
            this.components = new System.ComponentModel.Container();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.panel_password = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.pb_password = new System.Windows.Forms.PictureBox();
            this.button_authorization = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_login
            // 
            this.pb_login.BackgroundImage = global::AdminCoop.Properties.Resources.user_noActive;
            this.pb_login.Location = new System.Drawing.Point(40, 186);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(32, 32);
            this.pb_login.TabIndex = 0;
            this.pb_login.TabStop = false;
            // 
            // tb_login
            // 
            this.tb_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tb_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_login.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.ForeColor = System.Drawing.Color.White;
            this.tb_login.HideSelection = false;
            this.tb_login.Location = new System.Drawing.Point(91, 191);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(289, 27);
            this.tb_login.TabIndex = 2;
            this.tb_login.TabStop = false;
            this.tb_login.Text = "Логин";
            this.tb_login.Click += new System.EventHandler(this.tb_login_Click);
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.White;
            this.panel_login.Location = new System.Drawing.Point(40, 224);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(342, 1);
            this.panel_login.TabIndex = 4;
            // 
            // panel_password
            // 
            this.panel_password.BackColor = System.Drawing.Color.White;
            this.panel_password.Location = new System.Drawing.Point(40, 318);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(342, 1);
            this.panel_password.TabIndex = 7;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.ForeColor = System.Drawing.Color.White;
            this.tb_password.HideSelection = false;
            this.tb_password.Location = new System.Drawing.Point(91, 285);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(289, 27);
            this.tb_password.TabIndex = 6;
            this.tb_password.TabStop = false;
            this.tb_password.Text = "Пароль";
            this.tb_password.Click += new System.EventHandler(this.tb_password_Click);
            // 
            // pb_password
            // 
            this.pb_password.BackgroundImage = global::AdminCoop.Properties.Resources.Lock_noActive;
            this.pb_password.Location = new System.Drawing.Point(40, 280);
            this.pb_password.Name = "pb_password";
            this.pb_password.Size = new System.Drawing.Size(32, 32);
            this.pb_password.TabIndex = 5;
            this.pb_password.TabStop = false;
            // 
            // button_authorization
            // 
            this.button_authorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(69)))));
            this.button_authorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_authorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_authorization.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_authorization.ForeColor = System.Drawing.Color.White;
            this.button_authorization.Location = new System.Drawing.Point(120, 367);
            this.button_authorization.Name = "button_authorization";
            this.button_authorization.Size = new System.Drawing.Size(170, 52);
            this.button_authorization.TabIndex = 8;
            this.button_authorization.Text = "Авторизация";
            this.button_authorization.UseVisualStyleBackColor = false;
            this.button_authorization.Click += new System.EventHandler(this.button_authorization_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(435, 565);
            this.Controls.Add(this.button_authorization);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.pb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.pb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authorization";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.PictureBox pb_password;
        private System.Windows.Forms.Button button_authorization;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

