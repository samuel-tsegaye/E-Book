namespace E_Book
{
    partial class admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_BOOKDataSet = new E_Book.E_BOOKDataSet();
            this.Lb_reset = new System.Windows.Forms.Button();
            this.Lb_add = new System.Windows.Forms.Button();
            this.Lb_firstname = new System.Windows.Forms.TextBox();
            this.Lb_phone = new System.Windows.Forms.TextBox();
            this.Lb_lastname = new System.Windows.Forms.TextBox();
            this.Lb_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Lib_reset = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Lib_add = new System.Windows.Forms.Button();
            this.Lib_username = new System.Windows.Forms.TextBox();
            this.Lib_password = new System.Windows.Forms.TextBox();
            this.Lib_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Au_reset = new System.Windows.Forms.Button();
            this.Au_add = new System.Windows.Forms.Button();
            this.Au_firstname = new System.Windows.Forms.TextBox();
            this.Au_phone = new System.Windows.Forms.TextBox();
            this.Au_lastname = new System.Windows.Forms.TextBox();
            this.Au_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.Aut_reset = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Aut_add = new System.Windows.Forms.Button();
            this.Aut_username = new System.Windows.Forms.TextBox();
            this.Aut_password = new System.Windows.Forms.TextBox();
            this.Aut_id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.lib_InfoTableAdapter = new E_Book.E_BOOKDataSetTableAdapters.Lib_InfoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportExecutionService1 = new Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution.ReportExecutionService();
            this.e_BOOKDataSet7 = new E_Book.E_BOOKDataSet7();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_BOOKDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_BOOKDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-4, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::E_Book.Properties.Resources._731608;
            this.tabPage1.Controls.Add(this.reportViewer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rport";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "E_Book.Report.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(615, 503);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::E_Book.Properties.Resources._731608;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "To Librarian";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(176, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Create Account To Librarian";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(-6, 35);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(644, 480);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::E_Book.Properties.Resources._731608;
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.Lb_reset);
            this.tabPage3.Controls.Add(this.Lb_add);
            this.tabPage3.Controls.Add(this.Lb_firstname);
            this.tabPage3.Controls.Add(this.Lb_phone);
            this.tabPage3.Controls.Add(this.Lb_lastname);
            this.tabPage3.Controls.Add(this.Lb_id);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(636, 454);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Registration";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.libInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 307);
            this.dataGridView1.TabIndex = 27;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 160;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 160;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // libInfoBindingSource
            // 
            this.libInfoBindingSource.DataMember = "Lib_Info";
            this.libInfoBindingSource.DataSource = this.e_BOOKDataSet;
            // 
            // e_BOOKDataSet
            // 
            this.e_BOOKDataSet.DataSetName = "E_BOOKDataSet";
            this.e_BOOKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Lb_reset
            // 
            this.Lb_reset.Location = new System.Drawing.Point(333, 71);
            this.Lb_reset.Name = "Lb_reset";
            this.Lb_reset.Size = new System.Drawing.Size(61, 23);
            this.Lb_reset.TabIndex = 25;
            this.Lb_reset.Text = "RESET";
            this.Lb_reset.UseVisualStyleBackColor = true;
            this.Lb_reset.Click += new System.EventHandler(this.Lb_reset_Click);
            // 
            // Lb_add
            // 
            this.Lb_add.Location = new System.Drawing.Point(180, 71);
            this.Lb_add.Name = "Lb_add";
            this.Lb_add.Size = new System.Drawing.Size(61, 23);
            this.Lb_add.TabIndex = 24;
            this.Lb_add.Text = "ADD";
            this.Lb_add.UseVisualStyleBackColor = true;
            this.Lb_add.Click += new System.EventHandler(this.Lb_add_Click);
            // 
            // Lb_firstname
            // 
            this.Lb_firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lb_firstname.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Lb_firstname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lb_firstname.Location = new System.Drawing.Point(148, 36);
            this.Lb_firstname.Name = "Lb_firstname";
            this.Lb_firstname.Size = new System.Drawing.Size(121, 24);
            this.Lb_firstname.TabIndex = 23;
            this.Lb_firstname.Text = "   ";
            // 
            // Lb_phone
            // 
            this.Lb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lb_phone.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Lb_phone.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lb_phone.Location = new System.Drawing.Point(449, 36);
            this.Lb_phone.Name = "Lb_phone";
            this.Lb_phone.Size = new System.Drawing.Size(121, 24);
            this.Lb_phone.TabIndex = 22;
            this.Lb_phone.Text = "   ";
            // 
            // Lb_lastname
            // 
            this.Lb_lastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lb_lastname.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Lb_lastname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lb_lastname.Location = new System.Drawing.Point(295, 36);
            this.Lb_lastname.Name = "Lb_lastname";
            this.Lb_lastname.Size = new System.Drawing.Size(121, 24);
            this.Lb_lastname.TabIndex = 21;
            this.Lb_lastname.Text = "   ";
            // 
            // Lb_id
            // 
            this.Lb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lb_id.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Lb_id.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lb_id.Location = new System.Drawing.Point(44, 36);
            this.Lb_id.Name = "Lb_id";
            this.Lb_id.Size = new System.Drawing.Size(76, 24);
            this.Lb_id.TabIndex = 20;
            this.Lb_id.Text = "   ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(149, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(296, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(450, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(56, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::E_Book.Properties.Resources._731608;
            this.tabPage4.Controls.Add(this.Lib_reset);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.Lib_add);
            this.tabPage4.Controls.Add(this.Lib_username);
            this.tabPage4.Controls.Add(this.Lib_password);
            this.tabPage4.Controls.Add(this.Lib_id);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(636, 454);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Account Create";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Lib_reset
            // 
            this.Lib_reset.Location = new System.Drawing.Point(317, 77);
            this.Lib_reset.Name = "Lib_reset";
            this.Lib_reset.Size = new System.Drawing.Size(75, 23);
            this.Lib_reset.TabIndex = 44;
            this.Lib_reset.Text = "RESET";
            this.Lib_reset.UseVisualStyleBackColor = true;
            this.Lib_reset.Click += new System.EventHandler(this.Lib_reset_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(70, 125);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(454, 321);
            this.dataGridView2.TabIndex = 41;
            // 
            // Lib_add
            // 
            this.Lib_add.Location = new System.Drawing.Point(182, 77);
            this.Lib_add.Name = "Lib_add";
            this.Lib_add.Size = new System.Drawing.Size(75, 23);
            this.Lib_add.TabIndex = 38;
            this.Lib_add.Text = "ADD";
            this.Lib_add.UseVisualStyleBackColor = true;
            this.Lib_add.Click += new System.EventHandler(this.Lib_add_Click);
            // 
            // Lib_username
            // 
            this.Lib_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lib_username.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Lib_username.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lib_username.Location = new System.Drawing.Point(206, 35);
            this.Lib_username.Name = "Lib_username";
            this.Lib_username.Size = new System.Drawing.Size(121, 24);
            this.Lib_username.TabIndex = 37;
            // 
            // Lib_password
            // 
            this.Lib_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lib_password.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Lib_password.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lib_password.Location = new System.Drawing.Point(353, 35);
            this.Lib_password.Name = "Lib_password";
            this.Lib_password.Size = new System.Drawing.Size(121, 24);
            this.Lib_password.TabIndex = 35;
            // 
            // Lib_id
            // 
            this.Lib_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lib_id.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lib_id.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lib_id.Location = new System.Drawing.Point(102, 35);
            this.Lib_id.Name = "Lib_id";
            this.Lib_id.Size = new System.Drawing.Size(76, 24);
            this.Lib_id.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(207, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "User Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(354, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(114, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "ID";
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = global::E_Book.Properties.Resources._731608;
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.tabControl3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(621, 509);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "To Author";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gold;
            this.label16.Location = new System.Drawing.Point(183, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(239, 22);
            this.label16.TabIndex = 45;
            this.label16.Text = "Create Account To Author";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Location = new System.Drawing.Point(-6, 38);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(640, 476);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = global::E_Book.Properties.Resources._731608;
            this.tabPage6.Controls.Add(this.dataGridView3);
            this.tabPage6.Controls.Add(this.Au_reset);
            this.tabPage6.Controls.Add(this.Au_add);
            this.tabPage6.Controls.Add(this.Au_firstname);
            this.tabPage6.Controls.Add(this.Au_phone);
            this.tabPage6.Controls.Add(this.Au_lastname);
            this.tabPage6.Controls.Add(this.Au_id);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(632, 450);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Registration";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(18, 106);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(587, 329);
            this.dataGridView3.TabIndex = 27;
            // 
            // Au_reset
            // 
            this.Au_reset.Location = new System.Drawing.Point(333, 71);
            this.Au_reset.Name = "Au_reset";
            this.Au_reset.Size = new System.Drawing.Size(61, 23);
            this.Au_reset.TabIndex = 25;
            this.Au_reset.Text = "RESET";
            this.Au_reset.UseVisualStyleBackColor = true;
            this.Au_reset.Click += new System.EventHandler(this.Au_reset_Click);
            // 
            // Au_add
            // 
            this.Au_add.Location = new System.Drawing.Point(180, 71);
            this.Au_add.Name = "Au_add";
            this.Au_add.Size = new System.Drawing.Size(61, 23);
            this.Au_add.TabIndex = 24;
            this.Au_add.Text = "ADD";
            this.Au_add.UseVisualStyleBackColor = true;
            this.Au_add.Click += new System.EventHandler(this.Au_add_Click);
            // 
            // Au_firstname
            // 
            this.Au_firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Au_firstname.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Au_firstname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Au_firstname.Location = new System.Drawing.Point(148, 36);
            this.Au_firstname.Name = "Au_firstname";
            this.Au_firstname.Size = new System.Drawing.Size(121, 24);
            this.Au_firstname.TabIndex = 23;
            // 
            // Au_phone
            // 
            this.Au_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Au_phone.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Au_phone.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Au_phone.Location = new System.Drawing.Point(449, 36);
            this.Au_phone.Name = "Au_phone";
            this.Au_phone.Size = new System.Drawing.Size(121, 24);
            this.Au_phone.TabIndex = 22;
            // 
            // Au_lastname
            // 
            this.Au_lastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Au_lastname.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Au_lastname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Au_lastname.Location = new System.Drawing.Point(295, 36);
            this.Au_lastname.Name = "Au_lastname";
            this.Au_lastname.Size = new System.Drawing.Size(121, 24);
            this.Au_lastname.TabIndex = 21;
            // 
            // Au_id
            // 
            this.Au_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Au_id.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Au_id.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Au_id.Location = new System.Drawing.Point(44, 36);
            this.Au_id.Name = "Au_id";
            this.Au_id.Size = new System.Drawing.Size(76, 24);
            this.Au_id.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(149, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "First Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(296, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(450, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Phone Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(56, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "ID";
            // 
            // tabPage7
            // 
            this.tabPage7.BackgroundImage = global::E_Book.Properties.Resources._731608;
            this.tabPage7.Controls.Add(this.Aut_reset);
            this.tabPage7.Controls.Add(this.dataGridView4);
            this.tabPage7.Controls.Add(this.Aut_add);
            this.tabPage7.Controls.Add(this.Aut_username);
            this.tabPage7.Controls.Add(this.Aut_password);
            this.tabPage7.Controls.Add(this.Aut_id);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(632, 450);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Account Create";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Aut_reset
            // 
            this.Aut_reset.Location = new System.Drawing.Point(333, 77);
            this.Aut_reset.Name = "Aut_reset";
            this.Aut_reset.Size = new System.Drawing.Size(75, 23);
            this.Aut_reset.TabIndex = 44;
            this.Aut_reset.Text = "RESET";
            this.Aut_reset.UseVisualStyleBackColor = true;
            this.Aut_reset.Click += new System.EventHandler(this.Aut_reset_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(72, 128);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(424, 307);
            this.dataGridView4.TabIndex = 41;
            // 
            // Aut_add
            // 
            this.Aut_add.Location = new System.Drawing.Point(169, 77);
            this.Aut_add.Name = "Aut_add";
            this.Aut_add.Size = new System.Drawing.Size(75, 23);
            this.Aut_add.TabIndex = 38;
            this.Aut_add.Text = "ADD";
            this.Aut_add.UseVisualStyleBackColor = true;
            this.Aut_add.Click += new System.EventHandler(this.Aut_add_Click);
            // 
            // Aut_username
            // 
            this.Aut_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Aut_username.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Aut_username.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Aut_username.Location = new System.Drawing.Point(206, 35);
            this.Aut_username.Name = "Aut_username";
            this.Aut_username.Size = new System.Drawing.Size(121, 24);
            this.Aut_username.TabIndex = 37;
            // 
            // Aut_password
            // 
            this.Aut_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Aut_password.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Aut_password.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Aut_password.Location = new System.Drawing.Point(353, 35);
            this.Aut_password.Name = "Aut_password";
            this.Aut_password.Size = new System.Drawing.Size(121, 24);
            this.Aut_password.TabIndex = 35;
            // 
            // Aut_id
            // 
            this.Aut_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Aut_id.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic);
            this.Aut_id.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Aut_id.Location = new System.Drawing.Point(102, 35);
            this.Aut_id.Name = "Aut_id";
            this.Aut_id.Size = new System.Drawing.Size(76, 24);
            this.Aut_id.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(207, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "User Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(354, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Location = new System.Drawing.Point(114, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "ID";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Location = new System.Drawing.Point(528, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 45;
            this.button9.Text = "LOG OUT";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // lib_InfoTableAdapter
            // 
            this.lib_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 0;
            // 
            // reportExecutionService1
            // 
            this.reportExecutionService1.Credentials = null;
            this.reportExecutionService1.ExecutionHeaderValue = null;
            this.reportExecutionService1.ServerInfoHeaderValue = null;
            this.reportExecutionService1.TrustedUserHeaderValue = null;
            this.reportExecutionService1.Url = "http://localhost/ReportServer/ReportExecution2005.asmx";
            this.reportExecutionService1.UseDefaultCredentials = false;
            // 
            // e_BOOKDataSet7
            // 
            this.e_BOOKDataSet7.DataSetName = "E_BOOKDataSet7";
            this.e_BOOKDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "documents";
            this.documentsBindingSource.DataSource = this.e_BOOKDataSet7;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Book.Properties.Resources._731608;
            this.ClientSize = new System.Drawing.Size(619, 550);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_BOOKDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_BOOKDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Lb_reset;
        private System.Windows.Forms.Button Lb_add;
        private System.Windows.Forms.TextBox Lb_firstname;
        private System.Windows.Forms.TextBox Lb_phone;
        private System.Windows.Forms.TextBox Lb_lastname;
        private System.Windows.Forms.TextBox Lb_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Lib_reset;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Lib_add;
        private System.Windows.Forms.TextBox Lib_username;
        private System.Windows.Forms.TextBox Lib_password;
        private System.Windows.Forms.TextBox Lib_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button Au_reset;
        private System.Windows.Forms.Button Au_add;
        private System.Windows.Forms.TextBox Au_firstname;
        private System.Windows.Forms.TextBox Au_phone;
        private System.Windows.Forms.TextBox Au_lastname;
        private System.Windows.Forms.TextBox Au_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button Aut_reset;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button Aut_add;
        private System.Windows.Forms.TextBox Aut_username;
        private System.Windows.Forms.TextBox Aut_password;
        private System.Windows.Forms.TextBox Aut_id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label16;
        private E_BOOKDataSet e_BOOKDataSet;
        private System.Windows.Forms.BindingSource libInfoBindingSource;
        private E_BOOKDataSetTableAdapters.Lib_InfoTableAdapter lib_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution.ReportExecutionService reportExecutionService1;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private E_BOOKDataSet7 e_BOOKDataSet7;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
    }
}