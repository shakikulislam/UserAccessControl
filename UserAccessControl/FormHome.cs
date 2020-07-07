using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAccessControl
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateUser formCreateUser = new FormCreateUser();
            formCreateUser.ShowDialog();
        }

        private void userPermitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserPermition formUserPermition=new FormUserPermition();
            formUserPermition.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatus formStatus=new FormStatus();
            formStatus.ShowDialog();
        }
    }
}
