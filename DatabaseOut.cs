using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_Checkout_System
{
    public class DatabaseOut
    {

        //path connection to the database
        string path = "Server=localhost;Database=equipmentsystem;User ID=root;Password=devry123;Port=3306;";
        int employeeID;
        int empvalue;

        public void dbhammerout(int empid)
        {
            employeeID = empid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");
                    string query = "Select hammer FROM equipment_table";  //read hammer value in database
                    MySqlCommand command = new MySqlCommand(query, conn);
                    int value = Convert.ToInt32(command.ExecuteScalar());  //run query1 command using connection //convert value of ladder read from database to integer
                    int newvalue;

                    if (value > 0)
                    {
                        newvalue = value - 1;   //subtract 1 from value

                        string updatequery = "UPDATE equipment_table SET hammer = " + @newvalue;  //update hammer value with newvalue that is -1

                        MySqlCommand updateCommand = new MySqlCommand(updatequery, conn);
                        updateCommand.ExecuteScalar();  //run update command

                        string query2 = "Select hammer FROM tracking_table where empid = " + empid;  //read hammer value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 + 1;

                        string query1 = "UPDATE tracking_table set hammer = @empvalue, DateTimeOut = now() where empid = " + empid;
                        using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                        {
                            cmd.Parameters.AddWithValue("empvalue", empvalue);
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        newvalue = 0;
                        MessageBox.Show("No Nails remaining");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        public void dbladderout(int empid)
        {
            employeeID = empid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");
                    string query = "Select ladder FROM equipment_table";  //read ladder value in database
                    MySqlCommand command = new MySqlCommand(query, conn);
                    int value = Convert.ToInt32(command.ExecuteScalar());  //run query1 command using connection //convert value of ladder read from database to integer
                    int newvalue;

                    if (value > 0)
                    {
                        newvalue = value - 1;   //subtract 1 from value
                        string updatequery = "UPDATE equipment_table SET ladder = " + @newvalue;  //update ladder value with newvalue that is -1

                        MySqlCommand updateCommand = new MySqlCommand(updatequery, conn);
                        updateCommand.ExecuteScalar();  //run update command

                        string query2 = "Select ladder FROM tracking_table where empid = " + empid;  //read ladder value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 + 1;

                        string query1 = "UPDATE tracking_table set ladder = @empvalue, DateTimeOut = now() where empid = " + empid;
                        using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                        {
                            cmd.Parameters.AddWithValue("empvalue", empvalue);
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        newvalue = 0;
                        MessageBox.Show("No Nails remaining");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        public void dbNailsout(int empid)
        {
            employeeID = empid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");
                    string query = "Select Nails FROM equipment_table";  //read Nails value in database
                    MySqlCommand command = new MySqlCommand(query, conn);
                    int value = Convert.ToInt32(command.ExecuteScalar());  //run query1 command using connection //convert value of Nails read from database to integer
                    int newvalue;

                    if (value > 0)
                    {
                        newvalue = value - 10;   //subtract 10 from value
                        string updatequery = "UPDATE equipment_table SET Nails = " + @newvalue;  //update Nails value with newvalue that is -10

                        MySqlCommand updateCommand = new MySqlCommand(updatequery, conn);
                        updateCommand.ExecuteScalar();  //run update command

                        string query2 = "Select Nails FROM tracking_table where empid = " + empid;  //read Nails value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 + 10;

                        string query1 = "UPDATE tracking_table set Nails = @empvalue, DateTimeOut = now() where empid = " + empid;
                        using(MySqlCommand cmd = new MySqlCommand(query1, conn)) 
                        {
                            cmd.Parameters.AddWithValue("empvalue", empvalue);
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        newvalue = 0;
                        MessageBox.Show("No Nails remaining");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        public void dbScrewDriverout(int empid)
        {
            employeeID = empid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");
                    string query = "Select ScrewDriver FROM equipment_table";  //read ScrewDriver value in database
                    MySqlCommand command = new MySqlCommand(query, conn);
                    int value = Convert.ToInt32(command.ExecuteScalar());  //run query1 command using connection //convert value of ScrewDriver read from database to integer
                    int newvalue;

                    if (value > 0)
                    {
                        newvalue = value - 1;   //subtract 1 from value

                        string updatequery = "UPDATE equipment_table SET ScrewDriver = " + @newvalue;  //update ScrewDriver value with newvalue that is -1

                        MySqlCommand updateCommand = new MySqlCommand(updatequery, conn);
                        updateCommand.ExecuteScalar();  //run update command

                        string query2 = "Select ScrewDriver FROM tracking_table where empid = " + empid;  //read ScrewDriver value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 + 1;

                        string query1 = "UPDATE tracking_table set ScrewDriver = @empvalue, DateTimeOut = now() where empid = " + empid;
                        using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                        {
                            cmd.Parameters.AddWithValue("empvalue", empvalue);
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        newvalue = 0;
                        MessageBox.Show("No Nails remaining");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        public void dbWalkieout(int empid)
        {
            employeeID = empid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");
                    string query = "Select Walkie FROM equipment_table";  //read Walkie value in database
                    MySqlCommand command = new MySqlCommand(query, conn);
                    int value = Convert.ToInt32(command.ExecuteScalar());  //run query1 command using connection //convert value of Walkie read from database to integer
                    int newvalue;


                    if (value > 0)
                    {
                        newvalue = value - 1;   //subtract 1 from value
                        string updatequery = "UPDATE equipment_table SET Walkie = " + @newvalue;  //update Walkie value with newvalue that is -1

                        MySqlCommand updateCommand = new MySqlCommand(updatequery, conn);
                        updateCommand.ExecuteScalar();  //run update command

                        string query2 = "Select Walkie FROM tracking_table where empid = " + empid;  //read Walkie value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 + 1;

                        string query1 = "UPDATE tracking_table set Walkie = @empvalue, DateTimeOut = now() where empid = " + empid;
                        using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                        {
                            cmd.Parameters.AddWithValue("empvalue", empvalue);
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        newvalue = 0;
                        MessageBox.Show("No Nails remaining");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        public void dbWrenchout(int empid)
        {
            employeeID = empid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");
                    string query = "Select Wrench FROM equipment_table";  //read Wrench value in database
                    MySqlCommand command = new MySqlCommand(query, conn);
                    int value = Convert.ToInt32(command.ExecuteScalar());  //run query1 command using connection //convert value of Wrench read from database to integer
                    int newvalue;


                    if (value > 0)
                    {
                        newvalue = value - 1;   //subtract 1 from value
                        string updatequery = "UPDATE equipment_table SET Wrench = " + @newvalue;  //update Wrench value with newvalue that is -1

                        MySqlCommand updateCommand = new MySqlCommand(updatequery, conn);
                        updateCommand.ExecuteScalar();  //run update command

                        string query2 = "Select Wrench FROM tracking_table where empid = " + empid;  //read Wrench value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 + 1;

                        string query1 = "UPDATE tracking_table set Wrench = @empvalue, DateTimeOut = now() where empid = " + empid;
                        using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                        {
                            cmd.Parameters.AddWithValue("empvalue", empvalue);
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        newvalue = 0;
                        MessageBox.Show("No Nails remaining");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}