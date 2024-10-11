namespace Supermarker_mvp.Views
{
    partial class CategoriesView
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
            tabPageCategoriesList = new TabPage();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            DgCategories = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoriesDetail = new TabPage();
            txtCategoriesDescription = new TextBox();
            txtCategoriesName = new TextBox();
            txtCategoriesId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabPageCategoriesDetail.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 44);
            label1.Name = "label1";
            label1.Size = new Size(202, 49);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(btnClose);
            tabPageCategoriesList.Controls.Add(btnDelete);
            tabPageCategoriesList.Controls.Add(btnEdit);
            tabPageCategoriesList.Controls.Add(btnNew);
            tabPageCategoriesList.Controls.Add(DgCategories);
            tabPageCategoriesList.Controls.Add(btnSearch);
            tabPageCategoriesList.Controls.Add(txtSearch);
            tabPageCategoriesList.Controls.Add(label2);
            tabPageCategoriesList.Location = new Point(4, 29);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(792, 292);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categories List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Image = Properties.Resources.cerrar;
            btnClose.Location = new Point(672, 214);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 47);
            btnClose.TabIndex = 7;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(672, 159);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 49);
            btnDelete.TabIndex = 6;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(672, 104);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 49);
            btnEdit.TabIndex = 5;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(672, 52);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 46);
            btnNew.TabIndex = 4;
            btnNew.UseVisualStyleBackColor = true;
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(17, 73);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.RowHeadersWidth = 51;
            DgCategories.Size = new Size(628, 188);
            DgCategories.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Image = Properties.Resources.search_small;
            btnSearch.Location = new Point(568, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(77, 44);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(17, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Data to Search";
            txtSearch.Size = new Size(545, 27);
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 12);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Categories";
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(txtCategoriesDescription);
            tabPageCategoriesDetail.Controls.Add(txtCategoriesName);
            tabPageCategoriesDetail.Controls.Add(txtCategoriesId);
            tabPageCategoriesDetail.Controls.Add(label5);
            tabPageCategoriesDetail.Controls.Add(label4);
            tabPageCategoriesDetail.Controls.Add(label3);
            tabPageCategoriesDetail.Controls.Add(btnCancel);
            tabPageCategoriesDetail.Controls.Add(btnSave);
            tabPageCategoriesDetail.Location = new Point(4, 29);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(792, 292);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "Categories Detail";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // txtCategoriesDescription
            // 
            txtCategoriesDescription.Location = new Point(37, 177);
            txtCategoriesDescription.Multiline = true;
            txtCategoriesDescription.Name = "txtCategoriesDescription";
            txtCategoriesDescription.PlaceholderText = "Categories Description";
            txtCategoriesDescription.Size = new Size(248, 80);
            txtCategoriesDescription.TabIndex = 7;
            // 
            // txtCategoriesName
            // 
            txtCategoriesName.Location = new Point(37, 105);
            txtCategoriesName.Name = "txtCategoriesName";
            txtCategoriesName.PlaceholderText = "Categories Name";
            txtCategoriesName.Size = new Size(248, 27);
            txtCategoriesName.TabIndex = 6;
            // 
            // txtCategoriesId
            // 
            txtCategoriesId.Location = new Point(37, 40);
            txtCategoriesId.Name = "txtCategoriesId";
            txtCategoriesId.ReadOnly = true;
            txtCategoriesId.Size = new Size(160, 27);
            txtCategoriesId.TabIndex = 5;
            txtCategoriesId.Text = "0";
            txtCategoriesId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 154);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 4;
            label5.Text = "Categories Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 82);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 3;
            label4.Text = "Categories Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 17);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Categories Id";
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(432, 105);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 48);
            btnCancel.TabIndex = 1;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(432, 40);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 48);
            btnSave.TabIndex = 0;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Categories";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TabPage tabPageCategoriesDetail;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView DgCategories;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtCategoriesDescription;
        private TextBox txtCategoriesName;
        private TextBox txtCategoriesId;
    }
}