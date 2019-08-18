using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Manager : Form
    {
       
        FileManager fm = new FileManager();
        public Manager()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDBDataSet);

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet.cafe' table. You can move, or remove it, as needed.
            this.cafeTableAdapter.Fill(this.testDBDataSet.cafe);
            // TODO: This line of code loads data into the 'testDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.testDBDataSet.Student);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, "Do you want to login out?", "Quit", buttons);

            if(result == DialogResult.Yes)
            {
                this.Hide();
                Form1 NewForm = new Form1();
                NewForm.ShowDialog();
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            // The query to run
            // Notice the '@'- these are parameter and will be replaced by values during run time


            String query = "INSERT INTO cafe VALUES (@ID, @Type, @price)";


            SqlCommand cmd = fm.query(query);

            //Here you are creating a SQLParameter variable and adding the parameters to it which 
            //you created earlier

            SqlParameter ID = cmd.Parameters.Add("@ID", SqlDbType.Int);
            SqlParameter Type = cmd.Parameters.Add("@Type", SqlDbType.NChar);
            SqlParameter price = cmd.Parameters.Add("@price", SqlDbType.Decimal);

            //Get the values of the SQLParameter variables from the text boxes as user input

            // insert opertion in Db
            ID.Value = int.Parse(textBox5.Text);
            Type.Value = textBox6.Text;
            price.Value = decimal.Parse(textBox7.Text);
   
            // Read the executed query 
            //  SqlDataReader reader = cmd.ExecuteReader();

            int indicator = cmd.ExecuteNonQuery();

            if (indicator > 0)
            {
                MessageBox.Show("Saved!");

            }

            else
            {
                MessageBox.Show("Error, Not Saved!");
            }



            fm.close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            // The query to run
            // Notice the '@'- these are parameter and will be replaced by values during run time


            String query = "update cafe set no=@no, Type=@Type, price=@price where no=@no";

            

            // Run the sql query and replace the parameters with the following data
            SqlCommand cmd = fm.query(query);

            //Here you are creating a SQLParameter variable and adding the parameters to it which 
            //you created earlier

            SqlParameter no = cmd.Parameters.Add("@no", SqlDbType.Int);
            SqlParameter Type = cmd.Parameters.Add("@Type", SqlDbType.NChar);
            SqlParameter price = cmd.Parameters.Add("@price", SqlDbType.Decimal);

            //Get the values of the SQLParameter variables from the text boxes as user input

            // insert opertion in Db
            no.Value = int.Parse(noTextBox.Text);
            Type.Value = typeTextBox.Text;
            price.Value = decimal.Parse(priceTextBox.Text);

            // Read the executed query 
            //  SqlDataReader reader = cmd.ExecuteReader();

            int indicator = cmd.ExecuteNonQuery();

            if (indicator > 0)
            {
                MessageBox.Show("Updated");

            }

            else
            {
                MessageBox.Show("Error, Not updated!");
            }

            fm.close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            // The query to run
            // Notice the '@'- these are parameter and will be replaced by values during run time


            String query = "delete cafe where no=@no";



            // Run the sql query and replace the parameters with the following data
            SqlCommand cmd = fm.query(query);

            //Here you are creating a SQLParameter variable and adding the parameters to it which 
            //you created earlier

            SqlParameter no = cmd.Parameters.Add("@no", SqlDbType.Int);
           

            //Get the values of the SQLParameter variables from the text boxes as user input

            // insert opertion in Db
            no.Value = int.Parse(textBox4.Text);
         

            // Read the executed query 
            //  SqlDataReader reader = cmd.ExecuteReader();

            int indicator = cmd.ExecuteNonQuery();
            if (indicator > 0)
            {
                MessageBox.Show("Delete date successfully!");

            }
             
            else
            {
                MessageBox.Show("Not Deleted!");
            }
            fm.close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string patternPassword = @"^(?=.*[a-z])(?=.*[A-Z]).{4,8}$";


            try
            {


                String query = "update Student set Password=@pass where Id=1";



                // Run the sql query and replace the parameters with the following data
                SqlCommand cmd = fm.query(query);

                //Here you are creating a SQLParameter variable and adding the parameters to it which 
                //you created earlier

                //SqlParameter UserName = cmd.Parameters.Add("@user", SqlDbType.NChar);
                SqlParameter Password = cmd.Parameters.Add("@pass", SqlDbType.VarChar);

                Password.Value = passwordTextBox.Text;

                if (!Regex.IsMatch(passwordTextBox.Text , patternPassword))
                {
                    MessageBox.Show("Password must be at least 4 characters, no more than 8 characters, and must include at least one upper case letter, one lower case letter, and one numeric digit.", "Update Failed");
                    
                }

                else
                {

                    // Read the executed query 
                    //  SqlDataReader reader = cmd.ExecuteReader();

                    int indicator = cmd.ExecuteNonQuery();



                    if (indicator > 0)
                    {
                        MessageBox.Show("Updated");

                    }                 
                }

                fm.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
    }
    

