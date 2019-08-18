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
   
    public partial class Form1 : Form
    {
        FileManager fm = new FileManager();

        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.testDBDataSet.Student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                

                string query = "select * from Student where (UserName= @User COLLATE SQL_Latin1_General_CP1_CS_AS and Password= @Pass COLLATE SQL_Latin1_General_CP1_CS_AS)";

                SqlCommand cmd = fm.query(query);

                SqlParameter UserName = cmd.Parameters.Add("@User", SqlDbType.NChar);
                SqlParameter Password = cmd.Parameters.Add("@Pass", SqlDbType.VarChar);

                UserName.Value = textBox1.Text;
                Password.Value = textBox2.Text;

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.Read())
                {
         
                        if (reader[2].ToString().TrimEnd() == "admin")
                        {
                        MessageBox.Show("Welcome Manager");
                        this.Hide();
                            Manager ManagerScreen = new Manager();
                            ManagerScreen.ShowDialog();
                        }


                    if (reader[2].ToString().TrimEnd() == "cash")
                    {
                        MessageBox.Show("Welcome to sales system");
                        this.Hide();
                        Cashier ManagerScreen = new Cashier();
                        ManagerScreen.ShowDialog();
                    }



                }

                else
                {
                    MessageBox.Show("Wrong Login");
                }

                fm.close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        //public bool ValidatePassword(string password)
        //{
        //    string patternPassword = @"^(?=.*[a-z])(?=.*[0-9]).{4,10}$";

        //    if (!string.IsNullOrEmpty(password))
        //    {
        //        if (!Regex.IsMatch(password, patternPassword))
        //        {
        //            return false;
        //        }

        //    }
        //    return true ;
        //}
    }
}
    

