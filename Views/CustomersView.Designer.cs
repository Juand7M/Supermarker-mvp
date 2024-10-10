namespace Supermarker_mvp.Views
{
    partial class CustomersView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCustomersList = new TabPage();
            btnCLose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            DgCustomers = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            tabPageCustomersDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtCustomersEmail = new TextBox();
            txtCustomersPhoneNumber = new TextBox();
            txtCustomersBirthday = new TextBox();
            txtCustomersAddress = new TextBox();
            txtCustomersLastName = new TextBox();
            txtCustomersFirstName = new TextBox();
            txtCustomersDocumentNumber = new TextBox();
            txtCustomersId = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.apoyo_tecnico;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 40);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomersList);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCustomersList
            // 
            tabPageCustomersList.Controls.Add(btnCLose);
            tabPageCustomersList.Controls.Add(btnDelete);
            tabPageCustomersList.Controls.Add(btnEdit);
            tabPageCustomersList.Controls.Add(btnNew);
            tabPageCustomersList.Controls.Add(DgCustomers);
            tabPageCustomersList.Controls.Add(btnSearch);
            tabPageCustomersList.Controls.Add(txtSearch);
            tabPageCustomersList.Controls.Add(label2);
            tabPageCustomersList.Location = new Point(4, 29);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(792, 292);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "Customers List";
            tabPageCustomersList.UseVisualStyleBackColor = true;
            // 
            // btnCLose
            // 
            btnCLose.Image = Properties.Resources.cerrar;
            btnCLose.Location = new Point(657, 217);
            btnCLose.Name = "btnCLose";
            btnCLose.Size = new Size(116, 42);
            btnCLose.TabIndex = 7;
            btnCLose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(657, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 42);
            btnDelete.TabIndex = 6;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(657, 121);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(116, 42);
            btnEdit.TabIndex = 5;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.BackgroundImageLayout = ImageLayout.None;
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(657, 75);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(116, 40);
            btnNew.TabIndex = 4;
            btnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(8, 84);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.RowHeadersWidth = 51;
            DgCustomers.Size = new Size(617, 188);
            DgCustomers.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.search_small;
            btnSearch.Location = new Point(572, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(53, 50);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(8, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Data to Search";
            txtSearch.Size = new Size(546, 27);
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 17);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Customers";
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Controls.Add(btnCancel);
            tabPageCustomersDetail.Controls.Add(btnSave);
            tabPageCustomersDetail.Controls.Add(txtCustomersEmail);
            tabPageCustomersDetail.Controls.Add(txtCustomersPhoneNumber);
            tabPageCustomersDetail.Controls.Add(txtCustomersBirthday);
            tabPageCustomersDetail.Controls.Add(txtCustomersAddress);
            tabPageCustomersDetail.Controls.Add(txtCustomersLastName);
            tabPageCustomersDetail.Controls.Add(txtCustomersFirstName);
            tabPageCustomersDetail.Controls.Add(txtCustomersDocumentNumber);
            tabPageCustomersDetail.Controls.Add(txtCustomersId);
            tabPageCustomersDetail.Controls.Add(label10);
            tabPageCustomersDetail.Controls.Add(label9);
            tabPageCustomersDetail.Controls.Add(label8);
            tabPageCustomersDetail.Controls.Add(label7);
            tabPageCustomersDetail.Controls.Add(label6);
            tabPageCustomersDetail.Controls.Add(label5);
            tabPageCustomersDetail.Controls.Add(label4);
            tabPageCustomersDetail.Controls.Add(label3);
            tabPageCustomersDetail.Location = new Point(4, 29);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(792, 292);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "Customers Detail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(594, 111);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 55);
            btnCancel.TabIndex = 17;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(594, 40);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 58);
            btnSave.TabIndex = 16;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtCustomersEmail
            // 
            txtCustomersEmail.Location = new Point(281, 248);
            txtCustomersEmail.Name = "txtCustomersEmail";
            txtCustomersEmail.PlaceholderText = "Customers Email";
            txtCustomersEmail.Size = new Size(162, 27);
            txtCustomersEmail.TabIndex = 15;
            // 
            // txtCustomersPhoneNumber
            // 
            txtCustomersPhoneNumber.Location = new Point(279, 178);
            txtCustomersPhoneNumber.Name = "txtCustomersPhoneNumber";
            txtCustomersPhoneNumber.PlaceholderText = "Customers Phone ";
            txtCustomersPhoneNumber.Size = new Size(162, 27);
            txtCustomersPhoneNumber.TabIndex = 14;
            // 
            // txtCustomersBirthday
            // 
            txtCustomersBirthday.Location = new Point(279, 104);
            txtCustomersBirthday.Name = "txtCustomersBirthday";
            txtCustomersBirthday.PlaceholderText = "Customers Birthday";
            txtCustomersBirthday.Size = new Size(164, 27);
            txtCustomersBirthday.TabIndex = 13;
            // 
            // txtCustomersAddress
            // 
            txtCustomersAddress.Location = new Point(281, 37);
            txtCustomersAddress.Name = "txtCustomersAddress";
            txtCustomersAddress.PlaceholderText = "Customers Address";
            txtCustomersAddress.Size = new Size(164, 27);
            txtCustomersAddress.TabIndex = 12;
            // 
            // txtCustomersLastName
            // 
            txtCustomersLastName.Location = new Point(8, 248);
            txtCustomersLastName.Name = "txtCustomersLastName";
            txtCustomersLastName.PlaceholderText = "Customers Last Name";
            txtCustomersLastName.Size = new Size(164, 27);
            txtCustomersLastName.TabIndex = 11;
            // 
            // txtCustomersFirstName
            // 
            txtCustomersFirstName.Location = new Point(8, 178);
            txtCustomersFirstName.Name = "txtCustomersFirstName";
            txtCustomersFirstName.PlaceholderText = "Customers First Name";
            txtCustomersFirstName.Size = new Size(165, 27);
            txtCustomersFirstName.TabIndex = 10;
            // 
            // txtCustomersDocumentNumber
            // 
            txtCustomersDocumentNumber.Location = new Point(8, 104);
            txtCustomersDocumentNumber.Name = "txtCustomersDocumentNumber";
            txtCustomersDocumentNumber.PlaceholderText = "Customers Doc Number";
            txtCustomersDocumentNumber.Size = new Size(165, 27);
            txtCustomersDocumentNumber.TabIndex = 9;
            // 
            // txtCustomersId
            // 
            txtCustomersId.Location = new Point(8, 37);
            txtCustomersId.Name = "txtCustomersId";
            txtCustomersId.Size = new Size(165, 27);
            txtCustomersId.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(281, 225);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 7;
            label10.Text = "Customers Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(281, 146);
            label9.Name = "label9";
            label9.Size = new Size(181, 20);
            label9.TabIndex = 6;
            label9.Text = "Customers Phone Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 78);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 5;
            label8.Text = "Customers Birthday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(281, 14);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 4;
            label7.Text = "Customers Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 78);
            label6.Name = "label6";
            label6.Size = new Size(209, 20);
            label6.TabIndex = 3;
            label6.Text = "Customers Document Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 225);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 2;
            label5.Text = "Customers Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 146);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 1;
            label4.Text = "Customers First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 14);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 0;
            label3.Text = "Customers Id";
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "CustomersView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomersList.ResumeLayout(false);
            tabPageCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private TabPage tabPageCustomersDetail;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView DgCustomers;
        private Button btnCLose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtCustomersLastName;
        private TextBox txtCustomersFirstName;
        private TextBox txtCustomersDocumentNumber;
        private TextBox txtCustomersId;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtCustomersEmail;
        private TextBox txtCustomersPhoneNumber;
        private TextBox txtCustomersBirthday;
        private TextBox txtCustomersAddress;
        private Button btnSave;
        private Button btnCancel;
    }
}