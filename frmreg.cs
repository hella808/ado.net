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
using System.Text.RegularExpressions;
namespace WinForms2
{
    public partial class confpasswordtxt : Form
    {
        public confpasswordtxt()
        {
            InitializeComponent();
        }
        private void tablebtn_Click(object sender, EventArgs e)
        {
            Form1 _frm1= new Form1();
            _frm1.ShowDialog();
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestDataBase;Data Source=(local)"))
            {
                con.Open();
                string query = "INSERT INTO Test(Name, Surname, Gender, Email, NumberPhone, BirthDate, Login, Password)" +
                "VALUES(@Name, @Surname, @Gender, @Email, @NumberPhone, @BirthDate, @Login, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                    cmd.Parameters.AddWithValue("@Surname", surnametxt.Text);
                    if (genderbox.SelectedItem == null)
                    {
                        MessageBox.Show("Укажите пол");
                        return;
                    }
                    else
                    {
                        int genderValue = genderbox.SelectedItem.ToString() == "Мужской" ? 1 : 0;
                        cmd.Parameters.AddWithValue("@Gender", genderValue);
                    }
                    if (emailtxt.Text.Contains("@") && emailtxt.Text.IndexOf("@") > 0)
                    {
                        cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
                    }
                    else
                    {
                        MessageBox.Show("Введите правильную почту");
                        return;
                    }
                    if (numberphonetxt.Text.Length == 11)
                    {
                        cmd.Parameters.AddWithValue("@NumberPhone", numberphonetxt.Text);
                    }
                    else
                    {
                        MessageBox.Show("Введите правильный номер");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@BirthDate", birthdaytxt.Text);
                    cmd.Parameters.AddWithValue("@Login", logintxt.Text);
                    if (Regex.IsMatch(passwordtxt.Text, "^[A-Za-z0-9]+$") && passwordtxt.TextLength > 8)
                    {
                        cmd.Parameters.AddWithValue("@Password", passwordtxt.Text);
                    }
                    else
                    {
                        MessageBox.Show("Пароль должен иметь буквы латинского алфавита, заглавную букву, цифру и должен быть больше 8 символов");
                        return;
                    }
                    if(comfpasswordtxt.Text != passwordtxt.Text)
                    {
                        MessageBox.Show("Пароли должны быть одинаковые");
                        return;
                    }
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Данные сохранились");
                    }
                }
            }
        }
    }
}
