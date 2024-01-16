namespace RecapProject1
{
    partial class Form1
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
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.gbxName = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxCategory.SuspendLayout();
            this.gbxName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblKategori);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(776, 73);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Listele";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(18, 36);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(73, 33);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(205, 21);
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // gbxName
            // 
            this.gbxName.Controls.Add(this.tbxSearch);
            this.gbxName.Controls.Add(this.lblName);
            this.gbxName.Location = new System.Drawing.Point(13, 91);
            this.gbxName.Name = "gbxName";
            this.gbxName.Size = new System.Drawing.Size(775, 73);
            this.gbxName.TabIndex = 1;
            this.gbxName.TabStop = false;
            this.gbxName.Text = "Ürün İsmine Göre Listele";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Isim";
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 210);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(776, 228);
            this.dgwProduct.TabIndex = 2;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(72, 31);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(205, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxName);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxName.ResumeLayout(false);
            this.gbxName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox gbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.TextBox tbxSearch;
    }
}

