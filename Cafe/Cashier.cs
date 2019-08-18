using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDBDataSet);

        }

        private void Cashier_Load(object sender, EventArgs e)
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

            result = MessageBox.Show(this, "Are you want to login out?", "Quit", buttons);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 NewForm = new Form1();
                NewForm.ShowDialog();
            }

        }
    }
}
