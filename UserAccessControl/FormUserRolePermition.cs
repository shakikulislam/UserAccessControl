using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UserAccessControl
{
    public partial class FormUserRolePermition : Form
    {
        public FormUserRolePermition()
        {
            InitializeComponent();

            LoadRole();
        }

        private static SqlConnection _sqlConnection= new SqlConnection(@"Data Source=SHAKIKUL-PC\SQLEXPRESS; Initial Catalog=UserAccessControlDB; User Id=sa; Password=sa123456789");
        private static SqlCommand _sqlCommand;
        private static SqlDataAdapter _sqlDataAdapter;
        private static SqlDataReader _sqlDataReader;
        private static DataTable _dataTable;
        private DataSet _dataSet;

        private static int _file;           // Dtabase id 1, List id 0
        private static int _exit;           // Dtabase id 2, List id 1
        private static int _create;         // Dtabase id 3, List id 2
        private static int _user;           // Dtabase id 4, List id 3
        private static int _userPermition;  // Dtabase id 5, List id 4
        private static int _status;         // Dtabase id 6, List id 5

        private string _selectetMenu;

        private static List<int> list;

        private void LoadRole()
        {
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand=new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "SELECT UserRole AS 'User Role' FROM TableUserRole";
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataSet=new DataSet();
            _sqlDataAdapter.Fill(_dataSet);
            if (_dataSet.Tables.Count>0)
            {
                dataGridViewRole.DataSource = _dataSet.Tables[0];
                dataGridViewRole.RowHeadersVisible = false;

                comboBoxRole.Items.Clear();
                foreach (DataRow dataRow in _dataSet.Tables[0].Rows)
                {
                    comboBoxRole.Items.Add(dataRow["User Role"]);
                }

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Load list of menu id
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "SELECT *FROM TableMenuList";
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);
            if (_dataTable.Rows.Count > 0)
            {
                list = new List<int>(_dataTable.Rows.Count);
                foreach (DataRow dataRow in _dataTable.Rows)
                {
                    list.Add((int)dataRow["id"]);
                }
            }

            // Selected menu
            _file = checkBoxFile.Checked ? list[0] : 0;
            _exit = checkBoxExit.Checked ? list[1] : 0;
            _create = checkBoxCreate.Checked ? list[2] : 0;
            _user = checkBoxUser.Checked ? list[3] : 0;
            _userPermition = checkBoxUserPermition.Checked ? list[4] : 0;
            _status = checkBoxStatus.Checked ? list[5] : 0;
            
            _selectetMenu=_file+","+_exit+","+_create+","+_user+","+_userPermition+","+_status;

            // Update menu permition
            _sqlCommand.CommandText="UPDATE TableUserRole SET MenuId='"+_selectetMenu+"' WHERE UserRole='"+comboBoxRole.Text+"'";
            var isSuccess = _sqlCommand.ExecuteNonQuery();
            labelRoleMessage.Text = isSuccess > 0 ? comboBoxRole.Text + " menu permition is success..." : "";

        }
        
        private void labelAddRole_Click(object sender, EventArgs e)
        {
            if (panelAddRole.Visible==false)
            {
                panelAddRole.Visible = true;
            }
            else
            {
                panelAddRole.Visible = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand=new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "SELECT UserRole FROM TableUserRole WHERE UserRole='" + textBoxRole.Text + "'";
            _sqlDataReader = _sqlCommand.ExecuteReader();
            if (_sqlDataReader.Read() || textBoxRole.Text=="")
            {
                MessageBox.Show("This Role Already Exist\n or Field is empty\nPlease try again");
            }
            else
            {
                _sqlDataReader.Close();
                _sqlCommand.CommandText = "INSERT INTO TableUserRole (UserRole)VALUES('" + textBoxRole.Text + "')";
                var isSuccess=_sqlCommand.ExecuteNonQuery();
                if (isSuccess>0)
                {
                    MessageBox.Show("Success...");
                    panelAddRole.Visible = false;
                }
            }

            LoadRole();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxFile.Checked = false;
            checkBoxExit.Checked = false;
            checkBoxCreate.Checked = false;
            checkBoxUser.Checked = false;
            checkBoxUserPermition.Checked = false;
            checkBoxStatus.Checked = false;

            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "SELECT *FROM TableUserRole WHERE UserRole ='" + comboBoxRole.Text + "'";
            _sqlDataReader = _sqlCommand.ExecuteReader();
            if (_sqlDataReader.Read())
            {

                _sqlCommand.CommandText = "SELECT MenuName FROM TableMenuList WHERE id in (" +_sqlDataReader["MenuId"].ToString() + ")";
                _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _dataTable = new DataTable();
                _sqlDataReader.Close();
                _sqlDataAdapter.Fill(_dataTable);

                foreach (DataRow dataRow in _dataTable.Rows)
                {
                    switch (dataRow["MenuName"].ToString())
                    {
                        case "fileToolStripMenuItem":
                            checkBoxFile.Checked = true;
                            break;
                        case "exitToolStripMenuItem":
                            checkBoxExit.Checked = true;
                            break;
                        case "createToolStripMenuItem":
                            checkBoxCreate.Checked = true;
                            break;
                        case "userToolStripMenuItem":
                            checkBoxUser.Checked = true;
                            break;
                        case "userPermitionToolStripMenuItem":
                            checkBoxUserPermition.Checked = true;
                            break;
                        case "statusToolStripMenuItem":
                            checkBoxStatus.Checked = true;
                            break;
                    }
                }

            }

        }

    }
}
