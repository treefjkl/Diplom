using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonGoDelete_Click(object sender, EventArgs e)
        {
            AdmDeleteUser adm1 = new AdmDeleteUser();
            adm1.Show();
        }

        private void buttonGoChangeAccess_Click(object sender, EventArgs e)
        {
            AdmChangeAccess adm2 = new AdmChangeAccess();
            adm2.Show();
        }

        private void buttonUserList_Click(object sender, EventArgs e)
        {
            AdmUserList adm3 = new AdmUserList();
            adm3.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonUnAuth_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Hide();
        }
    }
}
