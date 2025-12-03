using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataAdapter = System.Data.SqlClient.SqlDataAdapter;
namespace WinForms2
{
    public partial class Form1 : Form
    {
        #region Feilds
        DataTable _dt;
        SqlConnection _con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School_db;Data Source=(local)\r\n");
        SqlCommand _cmdSelect;
        SqlDataAdapter _da;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            _cmdSelect = new SqlCommand("Select * from Students");
            _da = new SqlDataAdapter(_cmdSelect.CommandText, _con);
            _dt = new DataTable();
            _da.Fill(_dt);
            dgvData.DataSource = _dt;
            
        }
    }
}
