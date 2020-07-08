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
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Database Connection
            SqlConnection sqlConnection=new SqlConnection(@"Data Source=SHAKIKUL-PC\SQLEXPRESS; Initial Catalog=UserAccessControlDB; User Id=sa; Password=sa123456789");
            sqlConnection.Open();
            SqlCommand sqlCommand=new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText="INSERT INTO TableUser (Name, UserName, Password, UserType)VALUES('"+textBoxName.Text+"', '"+textBoxUserName.Text+"', '"+textBoxPassword.Text+"','"+comboBoxUserType.Text+"')";
            var isSuccess=sqlCommand.ExecuteNonQuery();

            // Confirmation Message
            if (isSuccess>0)
            {
                MessageBox.Show("Successfully Insert User...","Success", MessageBoxButtons.OK,MessageBoxIcon.Information);

                //Clear Field
                textBoxName.Clear();
                textBoxUserName.Clear();
                textBoxPassword.Clear();
                comboBoxUserType.Text = "";
            }
            else
            {
                MessageBox.Show("Plese check information\n or\nDatabase connection...","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

    }
}
