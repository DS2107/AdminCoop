namespace AdminCoop
{
    partial class New_worker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_worker));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_phone = new System.Windows.Forms.Panel();
            this.panel_fio = new System.Windows.Forms.Panel();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_FIO = new System.Windows.Forms.TextBox();
            this.panel_pos = new System.Windows.Forms.Panel();
            this.TB_position = new System.Windows.Forms.TextBox();
            this.panel_salary = new System.Windows.Forms.Panel();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_salary = new System.Windows.Forms.PictureBox();
            this.pb_pos = new System.Windows.Forms.PictureBox();
            this.pb_phone = new System.Windows.Forms.PictureBox();
            this.pb_fio = new System.Windows.Forms.PictureBox();
            this.Button_accept = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Button_close = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.picture_new_user = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_new_user)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_phone
            // 
            this.panel_phone.BackColor = System.Drawing.Color.White;
            this.panel_phone.Location = new System.Drawing.Point(458, 183);
            this.panel_phone.Name = "panel_phone";
            this.panel_phone.Size = new System.Drawing.Size(342, 1);
            this.panel_phone.TabIndex = 18;
            // 
            // panel_fio
            // 
            this.panel_fio.BackColor = System.Drawing.Color.White;
            this.panel_fio.Location = new System.Drawing.Point(458, 109);
            this.panel_fio.Name = "panel_fio";
            this.panel_fio.Size = new System.Drawing.Size(342, 1);
            this.panel_fio.TabIndex = 15;
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tb_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Phone.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Phone.ForeColor = System.Drawing.Color.White;
            this.tb_Phone.HideSelection = false;
            this.tb_Phone.Location = new System.Drawing.Point(509, 150);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(289, 27);
            this.tb_Phone.TabIndex = 17;
            this.tb_Phone.TabStop = false;
            this.tb_Phone.Text = "Телефон";
            this.tb_Phone.Click += new System.EventHandler(this.tb_Phone_Click);
            // 
            // tb_FIO
            // 
            this.tb_FIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tb_FIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_FIO.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_FIO.ForeColor = System.Drawing.Color.White;
            this.tb_FIO.HideSelection = false;
            this.tb_FIO.Location = new System.Drawing.Point(509, 76);
            this.tb_FIO.Name = "tb_FIO";
            this.tb_FIO.Size = new System.Drawing.Size(289, 27);
            this.tb_FIO.TabIndex = 14;
            this.tb_FIO.TabStop = false;
            this.tb_FIO.Text = "Ф.И.О";
            this.tb_FIO.Click += new System.EventHandler(this.tb_FIO_Click);
            // 
            // panel_pos
            // 
            this.panel_pos.BackColor = System.Drawing.Color.White;
            this.panel_pos.Location = new System.Drawing.Point(460, 266);
            this.panel_pos.Name = "panel_pos";
            this.panel_pos.Size = new System.Drawing.Size(342, 1);
            this.panel_pos.TabIndex = 21;
            // 
            // TB_position
            // 
            this.TB_position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.TB_position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_position.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_position.ForeColor = System.Drawing.Color.White;
            this.TB_position.HideSelection = false;
            this.TB_position.Location = new System.Drawing.Point(511, 233);
            this.TB_position.Name = "TB_position";
            this.TB_position.Size = new System.Drawing.Size(289, 27);
            this.TB_position.TabIndex = 20;
            this.TB_position.TabStop = false;
            this.TB_position.Text = "Должность";
            this.TB_position.Click += new System.EventHandler(this.TB_position_Click);
            // 
            // panel_salary
            // 
            this.panel_salary.BackColor = System.Drawing.Color.White;
            this.panel_salary.Location = new System.Drawing.Point(460, 343);
            this.panel_salary.Name = "panel_salary";
            this.panel_salary.Size = new System.Drawing.Size(342, 1);
            this.panel_salary.TabIndex = 24;
            // 
            // tb_salary
            // 
            this.tb_salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tb_salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_salary.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_salary.ForeColor = System.Drawing.Color.White;
            this.tb_salary.HideSelection = false;
            this.tb_salary.Location = new System.Drawing.Point(511, 310);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(289, 27);
            this.tb_salary.TabIndex = 23;
            this.tb_salary.TabStop = false;
            this.tb_salary.Text = "Зарплата";
            this.tb_salary.Click += new System.EventHandler(this.tb_salary_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(351, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 635);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(208)))), ((int)(((byte)(168)))));
            this.panel4.Location = new System.Drawing.Point(67, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Фото сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 156);
            this.label2.TabIndex = 30;
            this.label2.Text = "Новая \r\nкарточка \r\nсотрудника";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_salary
            // 
            this.pb_salary.BackgroundImage = global::AdminCoop.Properties.Resources.salary;
            this.pb_salary.Location = new System.Drawing.Point(460, 305);
            this.pb_salary.Name = "pb_salary";
            this.pb_salary.Size = new System.Drawing.Size(32, 32);
            this.pb_salary.TabIndex = 22;
            this.pb_salary.TabStop = false;
            // 
            // pb_pos
            // 
            this.pb_pos.BackgroundImage = global::AdminCoop.Properties.Resources.podium;
            this.pb_pos.Location = new System.Drawing.Point(460, 228);
            this.pb_pos.Name = "pb_pos";
            this.pb_pos.Size = new System.Drawing.Size(32, 32);
            this.pb_pos.TabIndex = 19;
            this.pb_pos.TabStop = false;
            // 
            // pb_phone
            // 
            this.pb_phone.BackgroundImage = global::AdminCoop.Properties.Resources.call;
            this.pb_phone.ErrorImage = global::AdminCoop.Properties.Resources.call;
            this.pb_phone.Location = new System.Drawing.Point(458, 145);
            this.pb_phone.Name = "pb_phone";
            this.pb_phone.Size = new System.Drawing.Size(32, 32);
            this.pb_phone.TabIndex = 16;
            this.pb_phone.TabStop = false;
            // 
            // pb_fio
            // 
            this.pb_fio.BackgroundImage = global::AdminCoop.Properties.Resources.User_Profile_Gray;
            this.pb_fio.Location = new System.Drawing.Point(458, 71);
            this.pb_fio.Name = "pb_fio";
            this.pb_fio.Size = new System.Drawing.Size(32, 32);
            this.pb_fio.TabIndex = 13;
            this.pb_fio.TabStop = false;
            // 
            // Button_accept
            // 
            this.Button_accept.AllowToggling = false;
            this.Button_accept.AnimationSpeed = 200;
            this.Button_accept.AutoGenerateColors = false;
            this.Button_accept.BackColor = System.Drawing.Color.Transparent;
            this.Button_accept.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Button_accept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_accept.BackgroundImage")));
            this.Button_accept.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_accept.ButtonText = "Добавить";
            this.Button_accept.ButtonTextMarginLeft = 0;
            this.Button_accept.ColorContrastOnClick = 45;
            this.Button_accept.ColorContrastOnHover = 45;
            this.Button_accept.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Button_accept.CustomizableEdges = borderEdges3;
            this.Button_accept.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_accept.DisabledBorderColor = System.Drawing.Color.Empty;
            this.Button_accept.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_accept.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_accept.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_accept.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Button_accept.ForeColor = System.Drawing.Color.White;
            this.Button_accept.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Button_accept.IconMarginLeft = 11;
            this.Button_accept.IconPadding = 10;
            this.Button_accept.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Button_accept.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Button_accept.IdleBorderRadius = 35;
            this.Button_accept.IdleBorderThickness = 1;
            this.Button_accept.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Button_accept.IdleIconLeftImage = null;
            this.Button_accept.IdleIconRightImage = null;
            this.Button_accept.IndicateFocus = false;
            this.Button_accept.Location = new System.Drawing.Point(509, 436);
            this.Button_accept.Name = "Button_accept";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 35;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.Button_accept.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 35;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.Button_accept.OnPressedState = stateProperties6;
            this.Button_accept.Size = new System.Drawing.Size(266, 37);
            this.Button_accept.TabIndex = 12;
            this.Button_accept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_accept.TextMarginLeft = 0;
            this.Button_accept.UseDefaultRadiusAndThickness = true;
            this.Button_accept.Click += new System.EventHandler(this.Button_accept_Click);
            // 
            // Button_close
            // 
            this.Button_close.AllowToggling = false;
            this.Button_close.AnimationSpeed = 200;
            this.Button_close.AutoGenerateColors = false;
            this.Button_close.BackColor = System.Drawing.Color.Transparent;
            this.Button_close.BackColor1 = System.Drawing.Color.Firebrick;
            this.Button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_close.BackgroundImage")));
            this.Button_close.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_close.ButtonText = "Отмена";
            this.Button_close.ButtonTextMarginLeft = 0;
            this.Button_close.ColorContrastOnClick = 45;
            this.Button_close.ColorContrastOnHover = 45;
            this.Button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.Button_close.CustomizableEdges = borderEdges4;
            this.Button_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_close.DisabledBorderColor = System.Drawing.Color.Empty;
            this.Button_close.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_close.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_close.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_close.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Button_close.ForeColor = System.Drawing.Color.White;
            this.Button_close.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Button_close.IconMarginLeft = 11;
            this.Button_close.IconPadding = 10;
            this.Button_close.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Button_close.IdleBorderColor = System.Drawing.Color.Firebrick;
            this.Button_close.IdleBorderRadius = 35;
            this.Button_close.IdleBorderThickness = 1;
            this.Button_close.IdleFillColor = System.Drawing.Color.Firebrick;
            this.Button_close.IdleIconLeftImage = null;
            this.Button_close.IdleIconRightImage = null;
            this.Button_close.IndicateFocus = false;
            this.Button_close.Location = new System.Drawing.Point(509, 509);
            this.Button_close.Name = "Button_close";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            stateProperties7.BorderRadius = 35;
            stateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(70)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.Button_close.onHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties8.BorderRadius = 35;
            stateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.Button_close.OnPressedState = stateProperties8;
            this.Button_close.Size = new System.Drawing.Size(266, 37);
            this.Button_close.TabIndex = 11;
            this.Button_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_close.TextMarginLeft = 0;
            this.Button_close.UseDefaultRadiusAndThickness = true;
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // picture_new_user
            // 
            this.picture_new_user.AllowFocused = false;
            this.picture_new_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture_new_user.BorderRadius = 50;
            this.picture_new_user.Image = global::AdminCoop.Properties.Resources.user;
            this.picture_new_user.IsCircle = true;
            this.picture_new_user.Location = new System.Drawing.Point(119, 71);
            this.picture_new_user.Name = "picture_new_user";
            this.picture_new_user.Size = new System.Drawing.Size(100, 100);
            this.picture_new_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_new_user.TabIndex = 0;
            this.picture_new_user.TabStop = false;
            this.picture_new_user.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.picture_new_user.Click += new System.EventHandler(this.picture_new_user_Click);
            // 
            // New_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(840, 638);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_salary);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.pb_salary);
            this.Controls.Add(this.panel_pos);
            this.Controls.Add(this.TB_position);
            this.Controls.Add(this.pb_pos);
            this.Controls.Add(this.panel_phone);
            this.Controls.Add(this.panel_fio);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.pb_phone);
            this.Controls.Add(this.tb_FIO);
            this.Controls.Add(this.pb_fio);
            this.Controls.Add(this.Button_accept);
            this.Controls.Add(this.Button_close);
            this.Controls.Add(this.picture_new_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_worker";
            this.Text = "New_worker";
            ((System.ComponentModel.ISupportInitialize)(this.pb_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_new_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox picture_new_user;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_close;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_accept;
        private System.Windows.Forms.Panel panel_phone;
        private System.Windows.Forms.Panel panel_fio;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.PictureBox pb_phone;
        private System.Windows.Forms.TextBox tb_FIO;
        private System.Windows.Forms.PictureBox pb_fio;
        private System.Windows.Forms.Panel panel_salary;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.PictureBox pb_salary;
        private System.Windows.Forms.Panel panel_pos;
        private System.Windows.Forms.TextBox TB_position;
        private System.Windows.Forms.PictureBox pb_pos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}