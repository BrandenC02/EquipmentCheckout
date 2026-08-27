using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_Checkout_System
{
    public partial class CheckOutForm : Form
    {
        public int employeeID;
        

        public CheckOutForm(int empID)
        {
            InitializeComponent();

            employeeID = empID;
            
        }

        
        private void btnChkOutSub_Click(object sender, EventArgs e)
        {
            DatabaseOut db = new DatabaseOut();

            if (ckbHammerOut.Checked)
            {
                db.dbhammerout(employeeID);
            }
            if(ckbLadderOut.Checked)
            {
                db.dbladderout(employeeID);
            }
            if(ckbNailsOut.Checked)
            {
                db.dbNailsout(employeeID);
            }
            if(ckbScrewDriverOut.Checked)
            {
                db.dbScrewDriverout(employeeID);
            }
            if(ckbWalkieOut.Checked)
            {
                db.dbWalkieout(employeeID);
            }
            if(ckbWrenchOut.Checked)
            {
                db.dbWrenchout(employeeID);
            }
        }

        private void btnChkBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            DialogResult = log.ShowDialog();
        }
    }
}
