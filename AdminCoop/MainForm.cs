using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuButton.Transitions;

namespace AdminCoop
{
    public partial class MainForm : Form
    {
        AdminCoopEntities db;

        public string users_log;
        public MainForm()
        {
           
            InitializeComponent();
           /* Bitmap BM = new Bitmap(bunifuPictureBox2.Image);
            System.IO.MemoryStream MS = new System.IO.MemoryStream();
            BM.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] B = MS.ToArray();*/


          /*  Account account = new Account();
            account.Full_name = "2";
            account.Appointment = "we";
            account.Network_status = 1;
            account.Phone = "333333";
            account.Salary = 3333;
            account.Photo = B;
            db = new AdminCoopEntities();
            db.Accounts.Add(account);
            db.SaveChanges();*/

          /*  Image img = Image.FromFile(@"D:\1.png");
            MemoryStream stream = new MemoryStream();
            img.Save(stream, ImageFormat.Jpeg);
            byte[] array = stream.ToArray();
            stream.Dispose();
            Account account = new Account();
            account.Full_name = "музыка";
            account.Appointment = "we";
            account.Network_status = 1;
            account.Phone = "333333";
            account.Salary = 3333;
            account.Photo = array;
            db = new AdminCoopEntities();
            db.Accounts.Add(account);
            db.SaveChanges();*/

            //bunifuFormDock1.SubscribeControlToDragEvents(menu);
            //bunifuFormDock1.SubscribeControlToDragEvents(avatar_container);

        }

        private void Button_Statistics_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Статистика");
        }

        private void Button_staff_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Сотрудники");
            db = new AdminCoopEntities();
            db.Accounts.Load();
            var list_account = db.Accounts.Local.ToBindingList();
            foreach (var info in list_account)
            {
                string[] infostring = { info.Full_name, info.Phone, info.Appointment };
                DGcust.Rows.Add(infostring);
            }
        }

        private void Button_Tenants_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Арендаторы");
        }

        private void Button_Stock_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Склад");
        }

        private void Button_help_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Помощь");
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
         
            indicator.Top = ((Control)sender).Top;
            Application.Exit();
            this.Close();
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "adminCoopDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.adminCoopDataSet.Users);
          
        }

        private void DGcust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DGcust["name", e.RowIndex].Value;
            label_appointment.Text = DGcust["appointment", e.RowIndex].Value.ToString();
            label_number.Text = DGcust["number", e.RowIndex].Value.ToString();
            var list_account = db.Accounts.Local.ToBindingList();
            foreach (var info in list_account)
            {
              if(info.Full_name == DGcust["name", e.RowIndex].Value.ToString())
                {
                    label_zp.Text = info.Salary.ToString();
                    label_name.Text = info.Full_name.ToString();
                    MemoryStream stream = new MemoryStream();
                    Image img;
                    if (info.Photo != null)
                    {
                        stream = new MemoryStream(info.Photo);
                        img = Image.FromStream(stream);
                        image_user_account.Image = img;
                    }
                    else
                    {
                        image_user_account.Image = Properties.Resources.user;
                     
                    }
                   
                }
            }

            //MessageBox.Show(DGcust["name", e.RowIndex].Value.ToString());
            //MessageBox.Show(DGcust["number", e.RowIndex].Value.ToString());
            //MessageBox.Show(DGcust["appointment", e.RowIndex].Value.ToString());

        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            New_worker new_Worker = new New_worker();
            new_Worker.ShowDialog();
            TopMost = false;
            new_Worker.TopMost = true;
        }
    }
}
