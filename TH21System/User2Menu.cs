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
    public partial class User2Menu : Form
    {
        public User2Menu()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            OrderMan orderman = new OrderMan();
            orderman.Show();
            this.Close();

        }
        private void Ranking_Button_Click(object sender, EventArgs e)
        {
            RankingMan rankingman = new RankingMan();
            rankingman.Show();
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
