using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms2
{
    public partial class frmlgn : Form
    {
        public frmlgn()
        {
            InitializeComponent();
        }
        private void regbtn_Click(object sender, EventArgs e)
        {
            confpasswordtxt _frmreg = new confpasswordtxt();
            _frmreg.ShowDialog();
        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            string login = lgntxt.Text;
            string password = passtxt.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            string name = Auntification(login, password);
            if (name != null)
            {
                MessageBox.Show($"Авторизация успешна {name}");
                return;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
        }
        private string Auntification(string login, string password)
        {
            using (SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestDataBase;Data Source=(local)"))
            {
                con.Open();
                string query = "SELECT Name FROM Test Where Login = @Login AND Password = @password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Login", login);
                    cmd.Parameters.AddWithValue("@Password", password);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null;
                    }

                }
            }
        }

        private void forgetpassbtn_Click(object sender, EventArgs e)
        {
            frmres _frmres = new frmres();
            _frmres.ShowDialog();
        }
    }
}
