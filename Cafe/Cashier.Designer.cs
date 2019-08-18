namespace Cafe
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label noLabel;
            System.Windows.Forms.Label priceLabel;
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDBDataSet = new Cafe.TestDBDataSet();
            this.studentTableAdapter = new Cafe.TestDBDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new Cafe.TestDBDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.cafeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeTableAdapter = new Cafe.TestDBDataSetTableAdapters.cafeTableAdapter();
            this.cafeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeListBox = new System.Windows.Forms.ListBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            userNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            noLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.testDBDataSet;
            // 
            // testDBDataSet
            // 
            this.testDBDataSet.DataSetName = "TestDBDataSet";
            this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cafeTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cafe.TestDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cafeBindingSource
            // 
            this.cafeBindingSource.DataMember = "cafe";
            this.cafeBindingSource.DataSource = this.testDBDataSet;
            // 
            // cafeTableAdapter
            // 
            this.cafeTableAdapter.ClearBeforeFill = true;
            // 
            // cafeBindingSource1
            // 
            this.cafeBindingSource1.DataMember = "cafe";
            this.cafeBindingSource1.DataSource = this.testDBDataSet;
            // 
            // cafeListBox
            // 
            this.cafeListBox.DataSource = this.cafeBindingSource1;
            this.cafeListBox.DisplayMember = "type";
            this.cafeListBox.FormattingEnabled = true;
            this.cafeListBox.ItemHeight = 12;
            this.cafeListBox.Location = new System.Drawing.Point(58, 72);
            this.cafeListBox.Name = "cafeListBox";
            this.cafeListBox.Size = new System.Drawing.Size(233, 208);
            this.cafeListBox.TabIndex = 8;
            this.cafeListBox.ValueMember = "no";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(544, 78);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(65, 12);
            userNameLabel.TabIndex = 8;
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(615, 75);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.userNameTextBox.TabIndex = 9;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(542, 144);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(71, 12);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(619, 141);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(544, 198);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(65, 12);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(615, 195);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.lastNameTextBox.TabIndex = 11;
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Location = new System.Drawing.Point(337, 100);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(23, 12);
            noLabel.TabIndex = 11;
            noLabel.Text = "no:";
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "no", true));
            this.noTextBox.Location = new System.Drawing.Point(366, 97);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(100, 21);
            this.noTextBox.TabIndex = 12;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(319, 166);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(41, 12);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(366, 163);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 21);
            this.priceTextBox.TabIndex = 13;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.cafeListBox);
            this.Controls.Add(this.button1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TestDBDataSet testDBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private TestDBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private TestDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource cafeBindingSource;
        private TestDBDataSetTableAdapters.cafeTableAdapter cafeTableAdapter;
        private System.Windows.Forms.BindingSource cafeBindingSource1;
        private System.Windows.Forms.ListBox cafeListBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}