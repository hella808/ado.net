using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlDataAdapter = System.Data.SqlClient.SqlDataAdapter;
using System.Data.SqlClient;
namespace WinForms2
{
    public partial class Form1 : Form
    {
        #region Feilds      
        SqlConnection _con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestDataBase;Data Source=(local)\r\n");

        DataTable _dt=new DataTable(); 
        SqlDataAdapter _da;
        System.Data.SqlClient.SqlCommandBuilder _cmdBuilder;
         #endregion
        public Form1()
        {
            InitializeComponent();

        }
        void GeneratCommands(string SQLSelectCommand) 
        {

            _da = new SqlDataAdapter(SQLSelectCommand, _con); 
            _cmdBuilder = new System.Data.SqlClient.SqlCommandBuilder(_da);
            _da.DeleteCommand = _cmdBuilder.GetDeleteCommand();
            _da.UpdateCommand= _cmdBuilder.GetUpdateCommand();
            _da.InsertCommand= _cmdBuilder.GetInsertCommand();  
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
         
            _da.Update(_dt);
            _dt.AcceptChanges();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            GeneratCommands("Select * from Test");
            _dt.Clear();
           _da.Fill(_dt);
           dgvData.DataSource = _dt;
        }
    }
}
