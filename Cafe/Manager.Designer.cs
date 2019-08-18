namespace Cafe
{
    partial class Manager
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label noLabel1;
            System.Windows.Forms.Label typeLabel1;
            System.Windows.Forms.Label priceLabel1;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label userNameLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cafeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.testDBDataSet = new Cafe.TestDBDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Cafe.TestDBDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new Cafe.TestDBDataSetTableAdapters.TableAdapterManager();
            this.cafeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeTableAdapter = new Cafe.TestDBDataSetTableAdapters.cafeTableAdapter();
            this.cafeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            noLabel1 = new System.Windows.Forms.Label();
            typeLabel1 = new System.Windows.Forms.Label();
            priceLabel1 = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(558, 63);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(23, 12);
            label1.TabIndex = 13;
            label1.Text = "no:";
            // 
            // noLabel1
            // 
            noLabel1.AutoSize = true;
            noLabel1.Location = new System.Drawing.Point(42, 40);
            noLabel1.Name = "noLabel1";
            noLabel1.Size = new System.Drawing.Size(23, 12);
            noLabel1.TabIndex = 20;
            noLabel1.Text = "no:";
            // 
            // typeLabel1
            // 
            typeLabel1.AutoSize = true;
            typeLabel1.Location = new System.Drawing.Point(30, 80);
            typeLabel1.Name = "typeLabel1";
            typeLabel1.Size = new System.Drawing.Size(35, 12);
            typeLabel1.TabIndex = 21;
            typeLabel1.Text = "type:";
            // 
            // priceLabel1
            // 
            priceLabel1.AutoSize = true;
            priceLabel1.Location = new System.Drawing.Point(24, 116);
            priceLabel1.Name = "priceLabel1";
            priceLabel1.Size = new System.Drawing.Size(41, 12);
            priceLabel1.TabIndex = 22;
            priceLabel1.Text = "price:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(30, 324);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(59, 12);
            passwordLabel.TabIndex = 23;
            passwordLabel.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cafeBindingSource2
            // 
            this.cafeBindingSource2.DataMember = "cafe";
            this.cafeBindingSource2.DataSource = this.testDBDataSet;
            // 
            // testDBDataSet
            // 
            this.testDBDataSet.DataSetName = "TestDBDataSet";
            this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.testDBDataSet;
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
            // cafeBindingSource
            // 
            this.cafeBindingSource.DataSource = this.testDBDataSet;
            this.cafeBindingSource.Position = 0;
            // 
            // cafeTableAdapter
            // 
            this.cafeTableAdapter.ClearBeforeFill = true;
            // 
            // cafeBindingSource1
            // 
            this.cafeBindingSource1.DataSource = this.testDBDataSet;
            this.cafeBindingSource1.Position = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(624, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(601, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(98, 21);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(349, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(349, 77);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(351, 113);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(98, 21);
            this.textBox7.TabIndex = 20;
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource2, "no", true));
            this.noTextBox.Location = new System.Drawing.Point(71, 37);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(100, 21);
            this.noTextBox.TabIndex = 21;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource2, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(71, 77);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 21);
            this.typeTextBox.TabIndex = 22;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cafeBindingSource2, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(71, 113);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 21);
            this.priceTextBox.TabIndex = 23;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(95, 321);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 21);
            this.passwordTextBox.TabIndex = 24;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Update Password";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(24, 290);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(65, 12);
            userNameLabel.TabIndex = 26;
            userNameLabel.Text = "User Name:";
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "UserName", true));
            this.userNameLabel1.Location = new System.Drawing.Point(95, 290);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.userNameLabel1.TabIndex = 27;
            this.userNameLabel1.Text = "label2";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameLabel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(priceLabel1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(typeLabel1);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(noLabel1);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Manager";
            this.Text = "Manger";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource cafeBindingSource;
        private TestDBDataSetTableAdapters.cafeTableAdapter cafeTableAdapter;
        private System.Windows.Forms.BindingSource cafeBindingSource1;
        private System.Windows.Forms.BindingSource cafeBindingSource2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label userNameLabel1;
    }
}