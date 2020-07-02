using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRemoteCheckInSimple
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void HideSignIn()
        {
            if (adminRButton.Checked)
            {
                UserLab.Visible = true;
                userText.Visible = true;
                passLabel.Visible = true;
                passText.Visible = true;
            }
            else if (patientRbutton.Checked)
            {
                UserLab.Visible = false;
                userText.Visible = false;
                passLabel.Visible = false;
                passText.Visible = false;
            }
        }

        private void adminRbutton_CheckedChanged(object sender, EventArgs e)
        {
            HideSignIn();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(patientRbutton.Checked == true)
            {
                this.Hide();
                var apptMake = new ApptMaker();
                apptMake.Closed += (s, args) => this.Close();
                apptMake.Show();
            }
            else if(adminRButton.Checked == true)
            {
                this.Hide();
                //create new form to check doctor schedule
            }
        }
    }
    
}
