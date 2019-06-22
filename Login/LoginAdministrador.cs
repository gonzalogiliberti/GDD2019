using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCrucero.Util;

namespace FrbaCrucero.Login
{
    public partial class LoginAdministrador : Form
    {
        public LoginAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = sha256(textBox2.Text);
            DatabaseController controller = DatabaseController.getInstance();
            SqlConnection conn = controller.getConnectionString();
            SqlCommand query = new SqlCommand("Select login_admin(@user, @pass)", conn);
            SqlParameter param1 = new SqlParameter("@user", SqlDbType.NVarChar);
            param1.Value = user;
            SqlParameter param2 = new SqlParameter("@pass", SqlDbType.NVarChar);
            param2.Value = pass;
        }

        static string sha256(string pasword)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(pasword));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
