using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Adoption
{
    public partial class EmployeeLoginForm : Form
    {
        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        private void EmployeeLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeLogInButton_Click(object sender, EventArgs e)
        {
            LandingPage shelterEmployeeForm = new LandingPage();
            shelterEmployeeForm.Show();
            this.Hide();
        }

        private void EmployeeLogInLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
