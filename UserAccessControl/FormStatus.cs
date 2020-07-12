using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UserAccessControl
{
    public partial class FormStatus : Form
    {
        public FormStatus()
        {
            InitializeComponent();

            LoadUserInformation();
        }

        private static SqlConnection _sqlConnection = new SqlConnection(@"Data Source=SHAKIKUL-PC\SQLEXPRESS; Initial Catalog=UserAccessControlDB; User Id=sa; Password=sa123456789");
        private static SqlCommand _sqlCommand;
        private static SqlDataReader _sqlDataReader;

        private void buttonUpdate_Click(object sender, System.EventArgs e)
        {
            var isSuccess = 0;
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            if (MessageBox.Show("Are you sure\nUpdate your information","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                if (checkBoxChangePassword.Checked==true)
                {
                    _sqlCommand.CommandText = "UPDATE TableUser SET Name='" + textBoxName.Text + "', Password='" + textBoxConfirmPassword.Text + "' WHERE UserName='" + textBoxUserName.Text + "' AND Password='" + textBoxCurrentPassword.Text + "'";
                }
                else
                {
                    _sqlCommand.CommandText = "UPDATE TableUser SET Name='" + textBoxName.Text + "' WHERE UserName='" + textBoxUserName.Text + "' AND Password='" + textBoxCurrentPassword.Text + "'";
                }
                isSuccess=_sqlCommand.ExecuteNonQuery();
            }

            labelUpdateMessage.Text = isSuccess > 0 ? "User Information Update Success..." : "Update Failed...";
        }

        public void LoadUserInformation()
        {
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand=new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandText = "SELECT *FROM TableUser WHERE UserName='" + FormLogIn._userName + "'";
            _sqlDataReader = _sqlCommand.ExecuteReader();
            if (_sqlDataReader.Read())
            {
                textBoxName.Text = _sqlDataReader["Name"].ToString();
                textBoxUserName.Text = _sqlDataReader["UserName"].ToString();
                labelUserRole.Text = _sqlDataReader["UserRole"].ToString();

                
            }
            
        }

        private void textBoxConfirmPassword_TextChanged(object sender, System.EventArgs e)
        {
            if (textBoxNewPassword.Text==textBoxConfirmPassword.Text)
            {
                labelConfirmPassword.ForeColor = Color.Green;
                labelConfirmPassword.Text = "Password match";
            }
            else
            {
                labelConfirmPassword.ForeColor = Color.Red;
                labelConfirmPassword.Text = "Password don't match";
            }
        }

        private void checkBoxChangePassword_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxChangePassword.Checked==true)
            {
                textBoxNewPassword.ReadOnly = false;
                textBoxConfirmPassword.ReadOnly = false;
            }
            else
            {
                textBoxNewPassword.ReadOnly = true;
                textBoxConfirmPassword.ReadOnly = true;
            }
        }
    }
}
