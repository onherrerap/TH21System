using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TH21System
{
    public partial class User3Menu : Form
    {
        public User3Menu()
        {
            InitializeComponent();
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            StoreMan storeman = new StoreMan();
            storeman.Show();
            this.Close();

        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            OrderMan2 orderman2 = new OrderMan2();
            orderman2.Show();
            this.Close();

        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            LogMan logman = new LogMan();
            logman.Show();
            this.Close();

        }
        private void Logout_Button_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }
    }
}
