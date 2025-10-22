using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtUserPassword.PasswordChar = '*';
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string userPassword = txtUserPassword.Text;

            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {                
                using (var context = new FinancialCrmDbEntities())
                {
                    var user = context.Users.FirstOrDefault(x => x.Username == userId && x.Password == userPassword);

                    if (user != null)
                    {
                        MessageBox.Show($"Hoş geldiniz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmDashboard anaMenu = new FrmDashboard();
                        anaMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Veritabanı hatası: " + x.Message, "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
