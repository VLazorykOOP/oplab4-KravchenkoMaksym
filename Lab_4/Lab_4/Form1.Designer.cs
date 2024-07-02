namespace Lab_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button(); // Додано
            this.dgvCosmetics = new System.Windows.Forms.DataGridView();
            this.lblType = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosmetics)).BeginInit();
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(176, 21);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 20);
            this.txtType.TabIndex = 1;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(176, 60);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(200, 20);
            this.txtBrand.TabIndex = 3;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(176, 99);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(200, 20);
            this.txtManufacturer.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(176, 166);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(176, 125);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpExpiryDate.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(176, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(176, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCosmetics
            // 
            this.dgvCosmetics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCosmetics.Location = new System.Drawing.Point(12, 250);
            this.dgvCosmetics.Name = "dgvCosmetics";
            this.dgvCosmetics.Size = new System.Drawing.Size(542, 449);
            this.dgvCosmetics.TabIndex = 12;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(173, 5);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(26, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Вид";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(173, 44);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(40, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Click += new System.EventHandler(this.lblBrand_Click);
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(173, 83);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(56, 13);
            this.lblManufacturer.TabIndex = 4;
            this.lblManufacturer.Text = "Виробник";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(12, 93);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(91, 13);
            this.lblExpiryDate.TabIndex = 6;
            this.lblExpiryDate.Text = "Термін придатності";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(173, 148);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Ціна";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(566, 711);
            this.Controls.Add(this.btnDelete); // Додано
            this.Controls.Add(this.dgvCosmetics);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Name = "Form1";
            this.Text = "Облік продажу косметики";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosmetics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete; // Додано
        private System.Windows.Forms.DataGridView dgvCosmetics;

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblPrice;
    }
}
