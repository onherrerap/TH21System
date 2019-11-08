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
    public partial class User1Menu : Form
    {
        public User1Menu()
        {
            InitializeComponent();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ProductMan prodman = new ProductMan();
            prodman.Show();
            this.Close();

        }
        private void ClientButton_Click(object sender, EventArgs e)
        {
            ClientMan clientman = new ClientMan();
            clientman.Show();
            this.Close();

        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            UserMan userman = new UserMan();
            userman.Show();
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
