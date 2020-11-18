using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace AdminCoop
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            
        }
       
       
        MainForm main = new MainForm();
        private void tb_login_Click(object sender, EventArgs e)
        {
            tb_login.Clear();
            pb_login.BackgroundImage = Properties.Resources.User_Profile_Green;
            panel_login.BackColor = Color.FromArgb(23, 114, 69);
            tb_login.ForeColor = Color.FromArgb(23, 114, 69);

            pb_password.BackgroundImage = Properties.Resources.Lock_gray;
            panel_password.BackColor = Color.White;
            tb_password.ForeColor = Color.White;
        } // tb_login_Click

        private void tb_password_Click(object sender, EventArgs e)
        {
            tb_password.Clear();
            tb_password.PasswordChar = '*';
            pb_password.BackgroundImage = Properties.Resources.Lock_Green;
            panel_password.BackColor = Color.FromArgb(23, 114, 69);
            tb_password.ForeColor = Color.FromArgb(23, 114, 69);

            pb_login.BackgroundImage = Properties.Resources.User_Profile_Gray;
            panel_login.BackColor = Color.White;
            tb_login.ForeColor = Color.White;
        } // tb_password_Click

        private void button_authorization_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            main.Left += 10;
            if (main.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
               // main.TopMost = true;
                timer2.Tick += new EventHandler(timer_opacity_mainForm);
                timer2.Start();
            } // if
        }

        private void timer_opacity_mainForm(object sender, EventArgs e)
        {
            main.Opacity = main.Opacity + 0.038;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            main.Left -= 10;
        

            if (main.Left <=325)
            {
                
                timer2.Stop();
            }
        }

        private void timer_opacity_authorization(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - 0.04;
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            main.Opacity = 0;
            
            main.Show();
           
        }

        private void button_authorization1_Click(object sender, EventArgs e)
        {
            AdminCoopEntities adminCoopEntities = new AdminCoopEntities();
            var object_users = adminCoopEntities.Users;

            foreach (var one_user in object_users)
            {
                if (one_user.unique_name == tb_login.Text && one_user.password == tb_password.Text)
                {
                    timer1.Tick += new EventHandler(timer_opacity_authorization);
                    main.label_account.Text = tb_login.Text;
                    timer1.Start();

                    break;
                } // if
                
               

            }
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
