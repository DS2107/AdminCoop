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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(menu);
            bunifuFormDock1.SubscribeControlToDragEvents(avatar_container);

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
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "adminCoopDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.adminCoopDataSet.Users);

        }

      
    }
}
