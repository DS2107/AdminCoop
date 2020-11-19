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
        AdminCoopEntities db = new AdminCoopEntities();

        public string users_log;

        string FullName;
        public MainForm()
        {
           
            InitializeComponent();
       

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
            FullName = DGcust["name", e.RowIndex].Value.ToString();
            tb_appointment.Text = DGcust["appointment", e.RowIndex].Value.ToString();
            tb_number.Text = DGcust["number", e.RowIndex].Value.ToString();
            var list_account = db.Accounts.Local.ToBindingList();
            foreach (var info in list_account)
            {
              if(info.Full_name == DGcust["name", e.RowIndex].Value.ToString())
                {
                    tb_zp.Text = info.Salary.ToString();
                    tb_name.Text = info.Full_name.ToString();
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
            DGcust.Rows.Clear();
            db.Accounts.Load();
            var list_account = db.Accounts.Local.ToBindingList();
            foreach (var info in list_account)
            {
                string[] infostring = { info.Full_name, info.Phone, info.Appointment };
                DGcust.Rows.Add(infostring);
            }
            TopMost = false;
            new_Worker.TopMost = true;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            Account account = db.Accounts.Where(o => o.Full_name == tb_name.Text).FirstOrDefault();
            db.Accounts.Remove(account);
            db.SaveChanges();
            DGcust.Rows.Clear();
            db.Accounts.Load();
            var list_account = db.Accounts.Local.ToBindingList();
            foreach (var info in list_account)
            {
                string[] infostring = { info.Full_name, info.Phone, info.Appointment };
                DGcust.Rows.Add(infostring);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            DGcust.Rows.Clear();
            db.Accounts.Load();
            var list_account = db.Accounts.Local.ToBindingList();
            foreach (var info in list_account)
            {
                string[] infostring = { info.Full_name, info.Phone, info.Appointment };
                DGcust.Rows.Add(infostring);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(FullName != null)
            {
                var account_update = db.Accounts.Where(c => c.Full_name == FullName).FirstOrDefault();
                account_update.Full_name = tb_name.Text;
                account_update.Salary = tb_zp.Text;
                account_update.Appointment = tb_appointment.Text;
                account_update.Phone = tb_number.Text;

                Bitmap BM = new Bitmap(image_user_account.Image);
                System.IO.MemoryStream MS = new System.IO.MemoryStream();
                BM.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] B = MS.ToArray();
                account_update.Photo = B;

                db.SaveChanges();


            }
        }
    }
}
