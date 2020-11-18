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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.panel_password = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pb_password = new System.Windows.Forms.PictureBox();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.button_authorization1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.B_Close = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
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
            // pb_password
            // 
            this.pb_password.BackgroundImage = global::AdminCoop.Properties.Resources.Lock_gray;
            this.pb_password.Location = new System.Drawing.Point(40, 280);
            this.pb_password.Name = "pb_password";
            this.pb_password.Size = new System.Drawing.Size(32, 32);
            this.pb_password.TabIndex = 5;
            this.pb_password.TabStop = false;
            // 
            // pb_login
            // 
            this.pb_login.BackgroundImage = global::AdminCoop.Properties.Resources.User_Profile_Gray;
            this.pb_login.Location = new System.Drawing.Point(40, 186);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(32, 32);
            this.pb_login.TabIndex = 0;
            this.pb_login.TabStop = false;
            // 
            // button_authorization1
            // 
            this.button_authorization1.AllowToggling = false;
            this.button_authorization1.AnimationSpeed = 200;
            this.button_authorization1.AutoGenerateColors = false;
            this.button_authorization1.BackColor = System.Drawing.Color.Transparent;
            this.button_authorization1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.button_authorization1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_authorization1.BackgroundImage")));
            this.button_authorization1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_authorization1.ButtonText = "Авторизация";
            this.button_authorization1.ButtonTextMarginLeft = 0;
            this.button_authorization1.ColorContrastOnClick = 45;
            this.button_authorization1.ColorContrastOnHover = 45;
            this.button_authorization1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.button_authorization1.CustomizableEdges = borderEdges1;
            this.button_authorization1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_authorization1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.button_authorization1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_authorization1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_authorization1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button_authorization1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.button_authorization1.ForeColor = System.Drawing.Color.White;
            this.button_authorization1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.button_authorization1.IconMarginLeft = 11;
            this.button_authorization1.IconPadding = 10;
            this.button_authorization1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.button_authorization1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.button_authorization1.IdleBorderRadius = 3;
            this.button_authorization1.IdleBorderThickness = 1;
            this.button_authorization1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.button_authorization1.IdleIconLeftImage = null;
            this.button_authorization1.IdleIconRightImage = null;
            this.button_authorization1.IndicateFocus = false;
            this.button_authorization1.Location = new System.Drawing.Point(119, 359);
            this.button_authorization1.Name = "button_authorization1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.button_authorization1.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.button_authorization1.OnPressedState = stateProperties2;
            this.button_authorization1.Size = new System.Drawing.Size(192, 45);
            this.button_authorization1.TabIndex = 9;
            this.button_authorization1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_authorization1.TextMarginLeft = 0;
            this.button_authorization1.UseDefaultRadiusAndThickness = true;
            this.button_authorization1.Click += new System.EventHandler(this.button_authorization1_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.bunifuLabel1.Location = new System.Drawing.Point(119, 39);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(192, 43);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "AdminCoop  ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // B_Close
            // 
            this.B_Close.AllowToggling = false;
            this.B_Close.AnimationSpeed = 200;
            this.B_Close.AutoGenerateColors = false;
            this.B_Close.BackColor = System.Drawing.Color.Transparent;
            this.B_Close.BackColor1 = System.Drawing.Color.Firebrick;
            this.B_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_Close.BackgroundImage")));
            this.B_Close.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.B_Close.ButtonText = "X";
            this.B_Close.ButtonTextMarginLeft = 0;
            this.B_Close.ColorContrastOnClick = 45;
            this.B_Close.ColorContrastOnHover = 45;
            this.B_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.B_Close.CustomizableEdges = borderEdges2;
            this.B_Close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.B_Close.DisabledBorderColor = System.Drawing.Color.Empty;
            this.B_Close.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.B_Close.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.B_Close.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.B_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.B_Close.ForeColor = System.Drawing.Color.White;
            this.B_Close.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.B_Close.IconMarginLeft = 11;
            this.B_Close.IconPadding = 10;
            this.B_Close.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.B_Close.IdleBorderColor = System.Drawing.Color.Firebrick;
            this.B_Close.IdleBorderRadius = 3;
            this.B_Close.IdleBorderThickness = 1;
            this.B_Close.IdleFillColor = System.Drawing.Color.Firebrick;
            this.B_Close.IdleIconLeftImage = null;
            this.B_Close.IdleIconRightImage = null;
            this.B_Close.IndicateFocus = false;
            this.B_Close.Location = new System.Drawing.Point(396, 12);
            this.B_Close.Name = "B_Close";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.B_Close.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.B_Close.OnPressedState = stateProperties4;
            this.B_Close.Size = new System.Drawing.Size(27, 27);
            this.B_Close.TabIndex = 12;
            this.B_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_Close.TextMarginLeft = 0;
            this.B_Close.UseDefaultRadiusAndThickness = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(435, 565);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.button_authorization1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_authorization1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton B_Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

