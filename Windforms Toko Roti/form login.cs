using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windforms_Toko_Roti
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            string pesan;

            if (DatabaseConnection.TestConnection(out pesan))
            {
                MessageBox.Show(pesan);
            }
            else
            {
                MessageBox.Show(pesan);
            }
        }
    }
}
