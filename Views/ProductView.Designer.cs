namespace Supermarket_mvp1.Views
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabProducts = new TabControl();
            tabPagePorductsModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearchP = new Button();
            TxtSearchS = new TextBox();
            label2 = new Label();
            tabPageProductsDetail = new TabPage();
            label3 = new Label();
            TxtProductId = new TextBox();
            label4 = new Label();
            TxtProductName = new TextBox();
            label5 = new Label();
            TxtPrice = new TextBox();
            label6 = new Label();
            TxtStock = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabProducts.SuspendLayout();
            tabPagePorductsModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
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
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(183, 39);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(tabPagePorductsModeList);
            tabProducts.Controls.Add(tabPageProductsDetail);
            tabProducts.Dock = DockStyle.Fill;
            tabProducts.Location = new Point(0, 100);
            tabProducts.Name = "tabProducts";
            tabProducts.SelectedIndex = 0;
            tabProducts.Size = new Size(800, 350);
            tabProducts.TabIndex = 1;
            // 
            // tabPagePorductsModeList
            // 
            tabPagePorductsModeList.Controls.Add(BtnClose);
            tabPagePorductsModeList.Controls.Add(BtnDelete);
            tabPagePorductsModeList.Controls.Add(BtnEdit);
            tabPagePorductsModeList.Controls.Add(BtnNew);
            tabPagePorductsModeList.Controls.Add(DgProduct);
            tabPagePorductsModeList.Controls.Add(BtnSearchP);
            tabPagePorductsModeList.Controls.Add(TxtSearchS);
            tabPagePorductsModeList.Controls.Add(label2);
            tabPagePorductsModeList.Location = new Point(4, 24);
            tabPagePorductsModeList.Name = "tabPagePorductsModeList";
            tabPagePorductsModeList.Padding = new Padding(3);
            tabPagePorductsModeList.Size = new Size(792, 322);
            tabPagePorductsModeList.TabIndex = 0;
            tabPagePorductsModeList.Text = "Products List";
            tabPagePorductsModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(636, 269);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(133, 45);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(636, 209);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(133, 45);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += button3_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(636, 146);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(133, 45);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(636, 81);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(133, 45);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(13, 81);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowTemplate.Height = 25;
            DgProduct.Size = new Size(591, 233);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearchP
            // 
            BtnSearchP.BackgroundImage = Properties.Resources.search;
            BtnSearchP.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchP.Location = new Point(556, 32);
            BtnSearchP.Name = "BtnSearchP";
            BtnSearchP.Size = new Size(48, 43);
            BtnSearchP.TabIndex = 2;
            BtnSearchP.UseVisualStyleBackColor = true;
            // 
            // TxtSearchS
            // 
            TxtSearchS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSearchS.Location = new Point(13, 43);
            TxtSearchS.Name = "TxtSearchS";
            TxtSearchS.PlaceholderText = "Data to search";
            TxtSearchS.Size = new Size(537, 23);
            TxtSearchS.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 23);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 0;
            label2.Text = "Search Products";
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(TxtStock);
            tabPageProductsDetail.Controls.Add(label6);
            tabPageProductsDetail.Controls.Add(TxtPrice);
            tabPageProductsDetail.Controls.Add(label5);
            tabPageProductsDetail.Controls.Add(TxtProductName);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(TxtProductId);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Location = new Point(4, 24);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(792, 322);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 14);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(13, 34);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(179, 23);
            TxtProductId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 81);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 2;
            label4.Text = "Product Name";
            // 
            // TxtProductName
            // 
            TxtProductName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtProductName.Location = new Point(13, 101);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product Name";
            TxtProductName.Size = new Size(310, 23);
            TxtProductName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 152);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 4;
            label5.Text = "Price Product";
            // 
            // TxtPrice
            // 
            TxtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPrice.Location = new Point(13, 172);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.PlaceholderText = "Price Product";
            TxtPrice.Size = new Size(310, 23);
            TxtPrice.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 210);
            label6.Name = "label6";
            label6.Size = new Size(93, 17);
            label6.TabIndex = 6;
            label6.Text = "Stock Product";
            // 
            // TxtStock
            // 
            TxtStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TxtStock.Location = new Point(13, 230);
            TxtStock.Name = "TxtStock";
            TxtStock.PlaceholderText = "Stock Product";
            TxtStock.Size = new Size(310, 23);
            TxtStock.TabIndex = 7;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabProducts);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            Load += ProductView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabProducts.ResumeLayout(false);
            tabPagePorductsModeList.ResumeLayout(false);
            tabPagePorductsModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabProducts;
        private TabPage tabPagePorductsModeList;
        private TabPage tabPageProductsDetail;
        private Button BtnSearchP;
        private TextBox TxtSearchS;
        private Label label2;
        private DataGridView DgProduct;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtProductName;
        private Label label4;
        private TextBox TxtProductId;
        private Label label3;
        private TextBox TxtStock;
        private Label label6;
        private TextBox TxtPrice;
        private Label label5;
    }
}