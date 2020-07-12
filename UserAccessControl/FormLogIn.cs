using System;
using System.Data;
using System.Data.SqlClient;
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
        private static SqlDataReader _sqlDataReader;

        public static string _userRole;
        public static string _userName;
        public static string _name;

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "SELECT *FROM TableUser WHERE UserName='"+textBoxUserName.Text+"' AND Password='"+textBoxPassword.Text+"'";
            _sqlDataReader = _sqlCommand.ExecuteReader();

            if (_sqlDataReader.Read())
            {
                _userRole = _sqlDataReader["UserRole"].ToString();
                _userName = _sqlDataReader["UserName"].ToString();
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
        }
    }
}
