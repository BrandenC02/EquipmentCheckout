using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_Checkout_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //path connection to the database
        string path = "Server=localhost;Database=equipmentsystem;User ID=root;Password=devry123;Port=3306;";
        string employpass;
        string data;
        ArrayList array = new ArrayList();

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text != "" && txtPassword.Text != "")
            {
                EmployeeClass emp = new EmployeeClass();
                using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
                {
                    conn.Open();
                    
                    try
                    {
                        int eid = int.Parse(txtEmpID.Text);
                        emp.EmployeeID = eid;
                        emp.Password = txtPassword.Text;
                        try
                        {
                            string query = "SELECT emppass FROM employee_table where employeeid = " + eid;
                            MySqlCommand command = new MySqlCommand(query, conn);
                            
                            MySqlDataReader reader1 = command.ExecuteReader();
                            reader1.Read();
                            employpass = reader1["emppass"].ToString();
                            reader1.Close();

                            if (employpass == "" || employpass == "N/A")
                            {
                                string query1 = "UPDATE employee_table set emppass = @emppass where employeeid = " + eid;
                                using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                                {
                                    cmd.Parameters.AddWithValue("@emppass", emp.Password);
                                    cmd.ExecuteReader();
                                }
                                MessageBox.Show("Connection Successful");
                                this.Hide();
                                CheckOutForm checkout = new CheckOutForm(eid);
                                checkout.Show();
                            }
                            if (employpass == emp.Password)
                            {
                                this.Hide();
                                CheckOutForm checkout = new CheckOutForm(eid);
                                checkout.Show();
                            }
                            else
                            {
                                MessageBox.Show("incorrect password");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: ID not found");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ID must contain only numbers");
                    }
                }
            }
            else
            {
                MessageBox.Show("Both Fields Required");
            }
        }
    

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text != "" && txtPassword.Text != "")
            {
                EmployeeClass emp = new EmployeeClass();
                int eid = int.Parse(txtEmpID.Text);
                emp.EmployeeID = eid;
                emp.Password = txtPassword.Text;
                using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
                {
                    try
                    {
                        conn.Open();  //open connection
                        string query = "SELECT emppass FROM employee_table where employeeid = " + eid;
                        MySqlCommand command = new MySqlCommand(query, conn);

                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        employpass = reader["emppass"].ToString();
                        reader.Close();

                        if (employpass == "" || employpass == "N/A")
                        {
                            string query1 = "UPDATE employee_table set emppass = @emppass where employeeid = " + eid;
                            using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                            {
                                cmd.Parameters.AddWithValue("@emppass", emp.Password);
                                cmd.ExecuteReader();
                            }
                            MessageBox.Show("Connection Successful");
                            this.Hide();
                            ReturnForm returnform = new ReturnForm(eid);
                            returnform.ShowDialog();
                        }
                        if (employpass == emp.Password)
                        {
                            this.Hide();
                            ReturnForm returnform = new ReturnForm(eid);
                            returnform.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("incorrect password");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }

                }
            }
            else
            {
                MessageBox.Show("Both Fields Required");
            }
        }
    }
}
