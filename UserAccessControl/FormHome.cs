using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UserAccessControl
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            GetByMenu();
        }

        private static SqlConnection _sqlConnection = new SqlConnection(@"Data Source=SHAKIKUL-PC\SQLEXPRESS; Initial Catalog=UserAccessControlDB; User Id=sa; Password=sa123456789");
        private static SqlCommand _sqlCommand;
        private static SqlDataAdapter _sqlDataAdapter;
        private static DataTable _dataTable;
        private DataSet _dataSet;

        private static string _menuId;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateUser formCreateUser = new FormCreateUser();
            formCreateUser.ShowDialog();
        }
        
        private void userPermitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserRolePermition formUserPermition=new FormUserRolePermition();
            formUserPermition.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatus formStatus = new FormStatus();
            formStatus.Show();
        }

        private void GetByMenu()
        {
            labelName.Text = FormLogIn._name;

            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand=new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "SELECT MenuId FROM TableUserRole WHERE UserRole='" + FormLogIn._userRole + "'";
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _dataSet=new DataSet();
            _sqlDataAdapter.Fill(_dataSet);

            _menuId = _dataSet.Tables[0].Rows[0][0].ToString();

            _sqlCommand.CommandText = "SELECT *FROM TableMenuList WHERE id in (" + _menuId + ")";
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            foreach (DataRow dataRow in _dataTable.Rows)
            {
                foreach (ToolStripMenuItem menuItem in menuStripHome.Items)
                {
                    if (dataRow["MenuName"].ToString() == menuItem.Name)
                    {
                        menuItem.Visible = true;
                    }

                    foreach (ToolStripMenuItem dropDownItem in menuItem.DropDownItems)
                    {
                        if (dataRow["MenuName"].ToString()==dropDownItem.Name)
                        {
                            dropDownItem.Visible = true;
                        }
                    }
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn=new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

    }
}
