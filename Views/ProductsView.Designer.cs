namespace Supermarker_mvp.Views
{
    partial class ProductsView
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
            tabPageProductsList = new TabPage();
            DgProducts = new DataGridView();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            tabPageProductsDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtProductsCategoriesId = new TextBox();
            txtProductsStock = new TextBox();
            txtProductsPrice = new TextBox();
            txtProductsName = new TextBox();
            txtProductsId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            tabPageProductsDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.agregar_producto;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 40);
            label1.Name = "label1";
            label1.Size = new Size(162, 46);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(817, 315);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(DgProducts);
            tabPageProductsList.Controls.Add(btnClose);
            tabPageProductsList.Controls.Add(btnDelete);
            tabPageProductsList.Controls.Add(btnEdit);
            tabPageProductsList.Controls.Add(btnNew);
            tabPageProductsList.Controls.Add(btnSearch);
            tabPageProductsList.Controls.Add(txtSearch);
            tabPageProductsList.Controls.Add(label2);
            tabPageProductsList.Location = new Point(4, 29);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(809, 282);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Products List ";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(12, 73);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.Size = new Size(613, 203);
            DgProducts.TabIndex = 7;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Image = Properties.Resources.cerrar;
            btnClose.Location = new Point(672, 225);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 40);
            btnClose.TabIndex = 6;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(672, 178);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 41);
            btnDelete.TabIndex = 5;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(672, 124);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 48);
            btnEdit.TabIndex = 4;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(672, 73);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 45);
            btnNew.TabIndex = 3;
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Image = Properties.Resources.search_small;
            btnSearch.Location = new Point(563, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(62, 52);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(12, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Data to Search";
            txtSearch.Size = new Size(531, 27);
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Products";
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(btnCancel);
            tabPageProductsDetail.Controls.Add(btnSave);
            tabPageProductsDetail.Controls.Add(txtProductsCategoriesId);
            tabPageProductsDetail.Controls.Add(txtProductsStock);
            tabPageProductsDetail.Controls.Add(txtProductsPrice);
            tabPageProductsDetail.Controls.Add(txtProductsName);
            tabPageProductsDetail.Controls.Add(txtProductsId);
            tabPageProductsDetail.Controls.Add(label7);
            tabPageProductsDetail.Controls.Add(label6);
            tabPageProductsDetail.Controls.Add(label5);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Location = new Point(4, 29);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(809, 282);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(391, 186);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 57);
            btnCancel.TabIndex = 11;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(257, 186);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 57);
            btnSave.TabIndex = 10;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtProductsCategoriesId
            // 
            txtProductsCategoriesId.Location = new Point(288, 138);
            txtProductsCategoriesId.Name = "txtProductsCategoriesId";
            txtProductsCategoriesId.Size = new Size(125, 27);
            txtProductsCategoriesId.TabIndex = 9;
            // 
            // txtProductsStock
            // 
            txtProductsStock.Location = new Point(288, 50);
            txtProductsStock.Name = "txtProductsStock";
            txtProductsStock.Size = new Size(125, 27);
            txtProductsStock.TabIndex = 8;
            // 
            // txtProductsPrice
            // 
            txtProductsPrice.Location = new Point(25, 226);
            txtProductsPrice.Name = "txtProductsPrice";
            txtProductsPrice.Size = new Size(125, 27);
            txtProductsPrice.TabIndex = 7;
            // 
            // txtProductsName
            // 
            txtProductsName.Location = new Point(25, 138);
            txtProductsName.Name = "txtProductsName";
            txtProductsName.Size = new Size(125, 27);
            txtProductsName.TabIndex = 6;
            // 
            // txtProductsId
            // 
            txtProductsId.Location = new Point(25, 50);
            txtProductsId.Name = "txtProductsId";
            txtProductsId.Size = new Size(125, 27);
            txtProductsId.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(288, 98);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 4;
            label7.Text = "Categories Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(288, 18);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 3;
            label6.Text = "Products Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 186);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 2;
            label5.Text = "Products Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 98);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 1;
            label4.Text = "Products Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 16);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 0;
            label3.Text = "Products Id";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 440);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "Products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private TabPage tabPageProductsDetail;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView DgProducts;
        private TextBox txtProductsStock;
        private TextBox txtProductsPrice;
        private TextBox txtProductsName;
        private TextBox txtProductsId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtProductsCategoriesId;
    }
}