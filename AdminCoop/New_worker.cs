using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminCoop
{
    public partial class New_worker : Form
    {
        public New_worker()
        {
            InitializeComponent();
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_FIO_Click(object sender, EventArgs e)
        {
            tb_FIO.Clear();
            tb_FIO.ForeColor = Color.FromArgb(23, 114, 69);
            pb_fio.BackgroundImage = Properties.Resources.User_Profile_Green;
            panel_fio.BackColor = Color.FromArgb(23, 114, 69);
           

            pb_phone.BackgroundImage = Properties.Resources.call;
            panel_phone.BackColor = Color.White;

            pb_salary.BackgroundImage = Properties.Resources.salary;
            panel_salary.BackColor = Color.White;

            pb_pos.BackgroundImage = Properties.Resources.podium;
            panel_pos.BackColor = Color.White;

        }

        private void tb_Phone_Click(object sender, EventArgs e)
        {
            tb_Phone.Clear();
            tb_Phone.ForeColor = Color.FromArgb(23, 114, 69);
            pb_phone.BackgroundImage = Properties.Resources.call_active;
            panel_phone.BackColor = Color.FromArgb(23, 114, 69);


            pb_fio.BackgroundImage = Properties.Resources.User_Profile_Gray;
            panel_fio.BackColor = Color.White;

            pb_salary.BackgroundImage = Properties.Resources.salary;
            panel_salary.BackColor = Color.White;

            pb_pos.BackgroundImage = Properties.Resources.podium;
            panel_pos.BackColor = Color.White;
        }

        private void TB_position_Click(object sender, EventArgs e)
        {
            TB_position.Clear();
            TB_position.ForeColor = Color.FromArgb(23, 114, 69);
            pb_pos.BackgroundImage = Properties.Resources.podium_active;
            panel_pos.BackColor = Color.FromArgb(23, 114, 69);


            pb_fio.BackgroundImage = Properties.Resources.User_Profile_Gray;
            panel_fio.BackColor = Color.White;

            pb_salary.BackgroundImage = Properties.Resources.salary;
            panel_salary.BackColor = Color.White;

            pb_phone.BackgroundImage = Properties.Resources.call;
            panel_phone.BackColor = Color.White;
        }

        private void tb_salary_Click(object sender, EventArgs e)
        {
            tb_salary.Clear();
            tb_salary.ForeColor = Color.FromArgb(23, 114, 69);
            pb_salary.BackgroundImage = Properties.Resources.salary_active;
            panel_salary.BackColor = Color.FromArgb(23, 114, 69);


            pb_fio.BackgroundImage = Properties.Resources.User_Profile_Gray;
            panel_fio.BackColor = Color.White;

            pb_pos.BackgroundImage = Properties.Resources.podium;
            panel_pos.BackColor = Color.White;

            pb_phone.BackgroundImage = Properties.Resources.call;
            panel_phone.BackColor = Color.White;
        }

        private void Button_accept_Click(object sender, EventArgs e)
        {
            AdminCoopEntities db = new AdminCoopEntities();
            Account account = new Account();
            account.Full_name = tb_FIO.Text;
            account.Appointment = TB_position.Text;
            account.Network_status = 0;
            account.Phone = tb_Phone.Text;
            account.Salary = tb_salary.Text;

            if(picture_new_user.Image != Properties.Resources.user)
            {
                Bitmap BM = new Bitmap(picture_new_user.Image);
                System.IO.MemoryStream MS = new System.IO.MemoryStream();
                BM.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] B = MS.ToArray();
                account.Photo = B;
            }
            db = new AdminCoopEntities();
            db.Accounts.Add(account);
            db.SaveChanges();
            tb_FIO.Text = "Ф.И.О";
            tb_FIO.ForeColor = Color.White;
            panel_fio.BackColor = Color.White;

            tb_Phone.Text = "Телефон";
            tb_Phone.ForeColor = Color.White;
            panel_phone.BackColor = Color.White;


            TB_position.Text = "Должность";
            TB_position.ForeColor = Color.White;
            panel_pos.BackColor = Color.White;


            tb_salary.Text = "Зарплата";
            tb_salary.ForeColor = Color.White;
            panel_salary.BackColor = Color.White;

            picture_new_user.Image = Properties.Resources.user;

        }

        private void picture_new_user_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files (*.jpg)|*.jpg";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file to encrypt.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(dialog.FileName);
                picture_new_user.Image = img;
            }
        }
    }
}
