using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_Checkout_System
{
    
    internal class DatabaseReturn 
    {
        //path connection to the database
        string path = "Server=localhost;Database=equipmentsystem;User ID=root;Password=devry123;Port=3306;";
        private int empID;
        private int empvalue;
        public void dbhammerin(int eid)
        {
            empID = eid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");

                    string query = "Select hammer FROM equipment_table";  //read hammer value in database
                    MySqlCommand command = new MySqlCommand(query, conn);

                    int value = Convert.ToInt32(command.ExecuteScalar()); //run query1 command using connection  //convert value of hammer read from database to integer
                    int newvalue;

                    if (value < 10)
                    {
                        newvalue = value + 1;                              //Add 1 from value
                        string updatequery1 = "UPDATE equipment_table SET hammer = " + @newvalue;  //update hammer value with newvalue that is -1

                        MySqlCommand updateCommand1 = new MySqlCommand(updatequery1, conn);
                        updateCommand1.ExecuteScalar();  //run update command

                        string query2 = "Select hammer FROM tracking_table where empid = " + eid;  //read hammer value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 - 1;

                        string query1 = "UPDATE tracking_table set hammer = " + empvalue + ", DateTimeIn = now() where empid = " + eid;
                        MySqlCommand cmd = new MySqlCommand(query1, conn);
                        cmd.ExecuteReader();

                    }
                    else
                    {
                        newvalue = 100;
                        MessageBox.Show("maximun hammer already in stock");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        public void dbLadderin(int eid)
        {
            empID = eid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");

                    string query = "Select Ladder FROM equipment_table";  //read Ladder value in database
                    MySqlCommand command = new MySqlCommand(query, conn);

                    int value = Convert.ToInt32(command.ExecuteScalar()); //run query1 command using connection  //convert value of Ladder read from database to integer
                    int newvalue;

                    if (value < 10)
                    {
                        newvalue = value + 1;                              //Add 1 from value
                        string updatequery1 = "UPDATE equipment_table SET Ladder = " + @newvalue;  //update Ladder value with newvalue that is -1

                        MySqlCommand updateCommand1 = new MySqlCommand(updatequery1, conn);
                        updateCommand1.ExecuteScalar();  //run update command

                        string query2 = "Select Ladder FROM tracking_table where empid = " + eid;  //read Ladder value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 - 1;

                        string query1 = "UPDATE tracking_table set Ladder = " + empvalue + ", DateTimeIn = now() where empid = " + eid;
                        MySqlCommand cmd = new MySqlCommand(query1, conn);
                        cmd.ExecuteReader();

                    }
                    else
                    {
                        newvalue = 100;
                        MessageBox.Show("maximun Ladder already in stock");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        public void dbNailsin(int eid)
        {
            empID = eid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");

                    string query = "Select Nails FROM equipment_table";  //read Nails value in database
                    MySqlCommand command = new MySqlCommand(query, conn);

                    int value = Convert.ToInt32(command.ExecuteScalar()); //run query1 command using connection  //convert value of Nails read from database to integer
                    int newvalue;

                    if (value < 100)
                    {
                        newvalue = value + 10;                              //Add 1 from value
                        string updatequery1 = "UPDATE equipment_table SET Nails = " + @newvalue;  //update Nails value with newvalue that is -1

                        MySqlCommand updateCommand1 = new MySqlCommand(updatequery1, conn);
                        updateCommand1.ExecuteScalar();  //run update command

                        string query2 = "Select Nails FROM tracking_table where empid = " + eid;  //read Nails value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 - 10;

                        string query1 = "UPDATE tracking_table set Nails = " + empvalue + ", DateTimeIn = now() where empid = " + eid;
                        MySqlCommand cmd = new MySqlCommand(query1, conn);
                        cmd.ExecuteReader();
                        
                    }
                    else
                    {
                        newvalue = 100;
                        MessageBox.Show("maximun Nails already in stock");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        public void dbScrewDriverin(int eid)
        {
            empID = eid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");

                    string query = "Select ScrewDriver FROM equipment_table";  //read ScrewDriver value in database
                    MySqlCommand command = new MySqlCommand(query, conn);

                    int value = Convert.ToInt32(command.ExecuteScalar()); //run query1 command using connection  //convert value of ScrewDriver read from database to integer
                    int newvalue;

                    if (value < 10)
                    {
                        newvalue = value + 1;                              //Add 1 from value
                        string updatequery1 = "UPDATE equipment_table SET ScrewDriver = " + @newvalue;  //update ScrewDriver value with newvalue that is -1

                        MySqlCommand updateCommand1 = new MySqlCommand(updatequery1, conn);
                        updateCommand1.ExecuteScalar();  //run update command

                        string query2 = "Select ScrewDriver FROM tracking_table where empid = " + eid;  //read ScrewDriver value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 - 1;

                        string query1 = "UPDATE tracking_table set ScrewDriver = " + empvalue + ", DateTimeIn = now() where empid = " + eid;
                        MySqlCommand cmd = new MySqlCommand(query1, conn);
                        cmd.ExecuteReader();

                    }
                    else
                    {
                        newvalue = 100;
                        MessageBox.Show("maximun ScrewDriver already in stock");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        public void dbWalkiein(int eid)
        {
            empID = eid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");

                    string query = "Select Walkie FROM equipment_table";  //read Walkie value in database
                    MySqlCommand command = new MySqlCommand(query, conn);

                    int value = Convert.ToInt32(command.ExecuteScalar()); //run query1 command using connection  //convert value of Walkie read from database to integer
                    int newvalue;

                    if (value < 10)
                    {
                        newvalue = value + 1;                              //Add 1 from value
                        string updatequery1 = "UPDATE equipment_table SET Walkie = " + @newvalue;  //update Walkie value with newvalue that is -1

                        MySqlCommand updateCommand1 = new MySqlCommand(updatequery1, conn);
                        updateCommand1.ExecuteScalar();  //run update command

                        string query2 = "Select Walkie FROM tracking_table where empid = " + eid;  //read Walkie value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 - 1;

                        string query1 = "UPDATE tracking_table set Walkie = " + empvalue + ", DateTimeIn = now() where empid = " + eid;
                        MySqlCommand cmd = new MySqlCommand(query1, conn);
                        cmd.ExecuteReader();

                    }
                    else
                    {
                        newvalue = 100;
                        MessageBox.Show("maximun Walkie already in stock");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
 
        public void dbWrenchin(int eid)
        {
            empID = eid;
            //form connection
            using (MySqlConnection conn = new MySqlConnection(path)) //using path to server on localhost and database named equipmentsystem
            {
                try
                {
                    conn.Open();  //open connection
                    MessageBox.Show("Connection successful!");

                    string query = "Select Wrench FROM equipment_table";  //read Wrench value in database
                    MySqlCommand command = new MySqlCommand(query, conn);

                    int value = Convert.ToInt32(command.ExecuteScalar()); //run query1 command using connection  //convert value of Wrench read from database to integer
                    int newvalue;

                    if (value < 10)
                    {
                        newvalue = value + 1;                              //Add 1 from value
                        string updatequery1 = "UPDATE equipment_table SET Wrench = " + @newvalue;  //update Wrench value with newvalue that is -1

                        MySqlCommand updateCommand1 = new MySqlCommand(updatequery1, conn);
                        updateCommand1.ExecuteScalar();  //run update command

                        string query2 = "Select Wrench FROM tracking_table where empid = " + eid;  //read Wrench value in database
                        MySqlCommand command1 = new MySqlCommand(query2, conn);
                        int value2 = Convert.ToInt32(command1.ExecuteScalar());

                        empvalue = value2 - 1;

                        string query1 = "UPDATE tracking_table set Wrench = " + empvalue + ", DateTimeIn = now() where empid = " + eid;
                        MySqlCommand cmd = new MySqlCommand(query1, conn);
                        cmd.ExecuteReader();

                    }
                    else
                    {
                        newvalue = 100;
                        MessageBox.Show("maximun Wrench already in stock");
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
    