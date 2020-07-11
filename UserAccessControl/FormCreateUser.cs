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

namespace UserAccessControl
{
    public partial class FormCreateUser : Form
    {
        public FormCreateUser()
        {
            InitializeComponent();

            LoadRole();

        }


        private static SqlConnection _sqlConnection = new SqlConnection(@"Data Source=SHAKIKUL-PC\SQLEXPRESS; Initial Catalog=UserAccessControlDB; User Id=sa; Password=sa123456789");
        private static SqlCommand _sqlCommand;
        private static SqlDataAdapter _sqlDataAdapter;
        private static SqlDataReader _sqlDataReader;
        private static DataTable _dataTable;
        private DataSet _dataSet;

        private void LoadRole()
        {
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "SELECT *FROM TableUserRole";
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);
            _dataSet = new DataSet();
            _sqlDataAdapter.Fill(_dataSet);

            if (_dataTable.Rows.Count > 0)
            {
                comboBoxUserRole.Items.Clear();
                foreach (DataRow dataRow in _dataTable.Rows)
                {
                    comboBoxUserRole.Items.Add(dataRow["UserRole"]);
                }
            }
            _sqlConnection.Close();
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Database Connection
            _sqlConnection.Open();
            _sqlCommand=new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText="INSERT INTO TableUser (Name, UserName, Password, UserRole)VALUES('"+textBoxName.Text+"', '"+textBoxUserName.Text+"', '"+textBoxPassword.Text+"','"+comboBoxUserRole.Text+"')";
            var isSuccess=_sqlCommand.ExecuteNonQuery();

            // Confirmation Message
            if (isSuccess>0)
            {
                MessageBox.Show("Successfully Insert User...","Success", MessageBoxButtons.OK,MessageBoxIcon.Information);

                //Clear Field
                textBoxName.Clear();
                textBoxUserName.Clear();
                textBoxPassword.Clear();
                comboBoxUserRole.Text = "";
            }
            else
            {
                MessageBox.Show("Plese check information\n or\nDatabase connection...","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

    }
}
