namespace Supermarket_mvp1.Views
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
            tabCategoriesList = new TabPage();
            tabCategoriesDetail = new TabPage();
            BtnCancelC = new Button();
            BtnSaveC = new Button();
            TxtCategoriesObservation = new TextBox();
            label4 = new Label();
            TxtCategoriesName = new TextBox();
            label3 = new Label();
            TxtCategoriesId = new TextBox();
            label2 = new Label();
            BtnCloseC = new Button();
            BtnDeleteC = new Button();
            BtnEditC = new Button();
            BtnNewC = new Button();
            DgCategoriesC = new DataGridView();
            BtnSearchP = new Button();
            TxtSearchsC = new TextBox();
            lbSearch = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCategoriesList.SuspendLayout();
            tabCategoriesDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategoriesC).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 85);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(204, 40);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 1;
            label1.Text = "CATEGORIES";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCategoriesList);
            tabControl1.Controls.Add(tabCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabCategoriesList
            // 
            tabCategoriesList.Controls.Add(BtnCloseC);
            tabCategoriesList.Controls.Add(BtnDeleteC);
            tabCategoriesList.Controls.Add(BtnEditC);
            tabCategoriesList.Controls.Add(BtnNewC);
            tabCategoriesList.Controls.Add(DgCategoriesC);
            tabCategoriesList.Controls.Add(BtnSearchP);
            tabCategoriesList.Controls.Add(TxtSearchsC);
            tabCategoriesList.Controls.Add(lbSearch);
            tabCategoriesList.Location = new Point(4, 24);
            tabCategoriesList.Name = "tabCategoriesList";
            tabCategoriesList.Padding = new Padding(3);
            tabCategoriesList.Size = new Size(792, 322);
            tabCategoriesList.TabIndex = 0;
            tabCategoriesList.Text = "Categories List";
            tabCategoriesList.UseVisualStyleBackColor = true;
            // 
            // tabCategoriesDetail
            // 
            tabCategoriesDetail.Controls.Add(BtnCancelC);
            tabCategoriesDetail.Controls.Add(BtnSaveC);
            tabCategoriesDetail.Controls.Add(TxtCategoriesObservation);
            tabCategoriesDetail.Controls.Add(label4);
            tabCategoriesDetail.Controls.Add(TxtCategoriesName);
            tabCategoriesDetail.Controls.Add(label3);
            tabCategoriesDetail.Controls.Add(TxtCategoriesId);
            tabCategoriesDetail.Controls.Add(label2);
            tabCategoriesDetail.Location = new Point(4, 24);
            tabCategoriesDetail.Name = "tabCategoriesDetail";
            tabCategoriesDetail.Padding = new Padding(3);
            tabCategoriesDetail.Size = new Size(792, 322);
            tabCategoriesDetail.TabIndex = 1;
            tabCategoriesDetail.Text = "Categories Detail";
            tabCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelC
            // 
            BtnCancelC.Image = Properties.Resources.cancel;
            BtnCancelC.Location = new Point(149, 250);
            BtnCancelC.Name = "BtnCancelC";
            BtnCancelC.Size = new Size(65, 49);
            BtnCancelC.TabIndex = 15;
            BtnCancelC.UseVisualStyleBackColor = true;
            // 
            // BtnSaveC
            // 
            BtnSaveC.Image = Properties.Resources.save;
            BtnSaveC.Location = new Point(38, 250);
            BtnSaveC.Name = "BtnSaveC";
            BtnSaveC.Size = new Size(65, 49);
            BtnSaveC.TabIndex = 14;
            BtnSaveC.UseVisualStyleBackColor = true;
            // 
            // TxtCategoriesObservation
            // 
            TxtCategoriesObservation.Location = new Point(20, 161);
            TxtCategoriesObservation.Multiline = true;
            TxtCategoriesObservation.Name = "TxtCategoriesObservation";
            TxtCategoriesObservation.PlaceholderText = "TxtCategoriesObservation";
            TxtCategoriesObservation.Size = new Size(333, 70);
            TxtCategoriesObservation.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 138);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 12;
            label4.Text = "Categories Observation";
            // 
            // TxtCategoriesName
            // 
            TxtCategoriesName.Location = new Point(20, 101);
            TxtCategoriesName.Name = "TxtCategoriesName";
            TxtCategoriesName.PlaceholderText = "Categories id";
            TxtCategoriesName.Size = new Size(301, 23);
            TxtCategoriesName.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 78);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 10;
            label3.Text = "Categories id";
            // 
            // TxtCategoriesId
            // 
            TxtCategoriesId.Location = new Point(20, 38);
            TxtCategoriesId.Name = "TxtCategoriesId";
            TxtCategoriesId.Size = new Size(301, 23);
            TxtCategoriesId.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 8;
            label2.Text = "Categories id";
            // 
            // BtnCloseC
            // 
            BtnCloseC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseC.Location = new Point(619, 264);
            BtnCloseC.Name = "BtnCloseC";
            BtnCloseC.Size = new Size(162, 47);
            BtnCloseC.TabIndex = 25;
            BtnCloseC.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteC
            // 
            BtnDeleteC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteC.Location = new Point(619, 200);
            BtnDeleteC.Name = "BtnDeleteC";
            BtnDeleteC.Size = new Size(162, 47);
            BtnDeleteC.TabIndex = 26;
            BtnDeleteC.UseVisualStyleBackColor = true;
            // 
            // BtnEditC
            // 
            BtnEditC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditC.Location = new Point(619, 136);
            BtnEditC.Name = "BtnEditC";
            BtnEditC.Size = new Size(162, 47);
            BtnEditC.TabIndex = 27;
            BtnEditC.UseVisualStyleBackColor = true;
            // 
            // BtnNewC
            // 
            BtnNewC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewC.BackColor = Color.Transparent;
            BtnNewC.Location = new Point(619, 70);
            BtnNewC.Name = "BtnNewC";
            BtnNewC.Size = new Size(162, 47);
            BtnNewC.TabIndex = 28;
            BtnNewC.UseVisualStyleBackColor = false;
            // 
            // DgCategoriesC
            // 
            DgCategoriesC.AllowUserToAddRows = false;
            DgCategoriesC.AllowUserToDeleteRows = false;
            DgCategoriesC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategoriesC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategoriesC.Location = new Point(19, 70);
            DgCategoriesC.Name = "DgCategoriesC";
            DgCategoriesC.ReadOnly = true;
            DgCategoriesC.RowTemplate.Height = 25;
            DgCategoriesC.Size = new Size(594, 241);
            DgCategoriesC.TabIndex = 24;
            // 
            // BtnSearchP
            // 
            BtnSearchP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchP.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchP.Location = new Point(563, 18);
            BtnSearchP.Name = "BtnSearchP";
            BtnSearchP.Size = new Size(50, 46);
            BtnSearchP.TabIndex = 23;
            BtnSearchP.UseVisualStyleBackColor = true;
            // 
            // TxtSearchsC
            // 
            TxtSearchsC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchsC.Location = new Point(19, 32);
            TxtSearchsC.Name = "TxtSearchsC";
            TxtSearchsC.PlaceholderText = "Data to search";
            TxtSearchsC.Size = new Size(538, 23);
            TxtSearchsC.TabIndex = 22;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbSearch.Location = new Point(12, 12);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(117, 17);
            lbSearch.TabIndex = 21;
            lbSearch.Text = "Search Categories";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "CategoriesView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCategoriesList.ResumeLayout(false);
            tabCategoriesList.PerformLayout();
            tabCategoriesDetail.ResumeLayout(false);
            tabCategoriesDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategoriesC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabCategoriesList;
        private TabPage tabCategoriesDetail;
        private Button BtnCloseC;
        private Button BtnDeleteC;
        private Button BtnEditC;
        private Button BtnNewC;
        private DataGridView DgCategoriesC;
        private Button BtnSearchP;
        private TextBox TxtSearchsC;
        private Label lbSearch;
        private Button BtnCancelC;
        private Button BtnSaveC;
        private TextBox TxtCategoriesObservation;
        private Label label4;
        private TextBox TxtCategoriesName;
        private Label label3;
        private TextBox TxtCategoriesId;
        private Label label2;
    }
}