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
    public partial class frmreg : Form
    {
        SqlConnection _con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestDataBase;Data Source=(local)\r\n");
        DataTable _dt = new DataTable();
        SqlCommandBuilder _cmdBuilder;
        SqlDataAdapter _da;
        public frmreg()
        {
            InitializeComponent();
        }

        void GeneratCommands(string SQLSelectCommand)
        {

            _da = new SqlDataAdapter(SQLSelectCommand, _con);
            _cmdBuilder = new System.Data.SqlClient.SqlCommandBuilder(_da);
            _da.InsertCommand = _cmdBuilder.GetInsertCommand();
        }
        private void tablebtn_Click(object sender, EventArgs e)
        {
            Form1 _frm1= new Form1();
            _frm1.ShowDialog();
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Test(Name, Surname, Gender, Email, NumberPhone, BirthDate, Login, Password)" +
                "VALUES(@Name, @Surname, @Gender, @Email, @NumberPhone, @BirthDate, @Login, @Password)";
            using (SqlCommand command = new SqlCommand(query, _con))
            {
                _con.Open();
                command.Parameters.AddWithValue("@Name", nametxt.Text);
                command.Parameters.AddWithValue("@Surname", surnametxt.Text);
                command.Parameters.AddWithValue("@Gender", gendertxt.Text);
                if (emailtxt.Text.Contains("@") && emailtxt.Text.IndexOf("@") > 0)
                {
                    command.Parameters.AddWithValue("@Email", emailtxt.Text);
                }
                else
                {
                    MessageBox.Show("Введите правильную почту");
                    return;
                }
                if (numberphonetxt.Text.Length >= 11)
                {
                    command.Parameters.AddWithValue("@NumberPhone", numberphonetxt.Text);
                }
                else
                {
                    MessageBox.Show("Введите правильный номер");
                    return;
                }
                command.Parameters.AddWithValue("@BirthDate", birthdaytxt.Text);
                command.Parameters.AddWithValue("@Login", logintxt.Text);
                if (Regex.IsMatch(passwordtxt.Text, "^[A-Za-z0-9]+$") && passwordtxt.TextLength > 8)
                {
                    command.Parameters.AddWithValue("@Password", passwordtxt.Text);
                }
                else
                {
                    MessageBox.Show("Пароль должен иметь больше 8 символов");
                    return;
                }
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Данные сохранились");
                }
            }
        }
    }
}
