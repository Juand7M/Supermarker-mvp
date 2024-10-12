namespace Supermarker_mvp.Views
{
    partial class MainView
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
            pictureBox1 = new PictureBox();
            BtnPayMode = new Button();
            panel1 = new Panel();
            btnCategories = new Button();
            btnCustomers = new Button();
            BtnExit = new Button();
            btnProducts = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Dock = DockStyle.Top;
            BtnPayMode.Location = new Point(0, 59);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(250, 85);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 3;
            // 
            // btnCategories
            // 
            btnCategories.BackgroundImage = Properties.Resources.categorias;
            btnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            btnCategories.Dock = DockStyle.Top;
            btnCategories.Location = new Point(0, 225);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(250, 71);
            btnCategories.TabIndex = 4;
            btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.BackgroundImage = Properties.Resources.apoyo_tecnico;
            btnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.Location = new Point(0, 144);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(250, 81);
            btnCustomers.TabIndex = 3;
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.cerrar_sesion;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 359);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(250, 91);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.BackgroundImage = Properties.Resources.agregar_producto;
            btnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            btnProducts.Dock = DockStyle.Top;
            btnProducts.Location = new Point(0, 296);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(250, 72);
            btnProducts.TabIndex = 5;
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnPayMode;
        private Panel panel1;
        private Button BtnExit;
        private Button btnCustomers;
        private Button btnCategories;
        private Button btnProducts;
    }
}