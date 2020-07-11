using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAccessControl
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }


        private static SqlConnection _sqlConnection = new SqlConnection(@"Data Source=SHAKIKUL-PC\SQLEXPRESS; Initial Catalog=UserAccessControlDB; User Id=sa; Password=sa123456789");
        private static SqlCommand _sqlCommand;
        private static SqlDataAdapter _sqlDataAdapter;
        private static SqlDataReader _sqlDataReader;
        private static DataTable _dataTable;
        private DataSet _dataSet;

        public static string _userName;
        public static string _name;

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            _sqlConnection.Open();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "SELECT *FROM TableUser WHERE UserName='"+textBoxUserName.Text+"' AND Password='"+textBoxPassword.Text+"'";
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _dataSet = new DataSet();
            _sqlDataAdapter.Fill(_dataSet);

            

            //if (_dataSet.Tables[0].Rows.Count > 0)
            //{
            //    _userRole = _dataSet.Tables[0].Rows[0][0].ToString();

            //    FormHome formHome = new FormHome();
            //    this.Close();
            //    formHome.Show();
            //}

            _sqlDataReader = _sqlCommand.ExecuteReader();
            if (_sqlDataReader.Read())
            {
                _userName = _sqlDataReader["UserRole"].ToString();
                _name = _sqlDataReader["Name"].ToString();

                labelLoginMessage.Text = "Login success...";

                FormHome formHome = new FormHome();
                this.Hide();
                formHome.Show();
            }
            else
            {
                labelLoginMessage.Text = "Username or Password incorrect...";
            }




            //if ()
            //{
            //    
            //}
            //else
            //{
                

            //FormHome formHome = new FormHome();
            //formHome.Refresh();
            //this.Hide();
            //}

            _sqlConnection.Close();
            

        }
    }
}
