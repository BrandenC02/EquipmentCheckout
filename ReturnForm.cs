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
    public partial class ReturnForm : Form
    {
        private int employeeID;
        public ReturnForm(int empID)
        {
            InitializeComponent();
            employeeID = empID;
        }

        private void btnRtnSub_Click(object sender, EventArgs e)
        {
            
            DatabaseReturn db = new DatabaseReturn();
            if (ckbHammerIn.Checked)
            {
                db.dbhammerin(employeeID);
            }
            if(ckbLadderIn.Checked)
            {
                db.dbLadderin(employeeID);
            }
            if(ckbNailsIn.Checked)
            {
                db.dbNailsin(employeeID);
            }
            if(ckbScrewDriverIn.Checked)
            {
                db.dbScrewDriverin(employeeID);
            }
            if(ckbWalkieIn.Checked)
            {
                db.dbWalkiein(employeeID);
            }
            if(ckbWrenchIn.Checked)
            {
                db.dbWrenchin(employeeID);
            }

        }

        private void btnRtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }
    }
}
