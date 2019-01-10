namespace Lab3
{
    partial class MainWindow
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
            this.ProductCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DiscontinueCheck = new System.Windows.Forms.CheckBox();
            this.StockedNumeric = new System.Windows.Forms.NumericUpDown();
            this.ReorderNumeric = new System.Windows.Forms.NumericUpDown();
            this.SupplierCombo = new System.Windows.Forms.ComboBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.QuanityField = new System.Windows.Forms.TextBox();
            this.UnitsNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CostNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductNameField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.ColOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReorderNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCombo
            // 
            this.ProductCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCombo.FormattingEnabled = true;
            this.ProductCombo.Location = new System.Drawing.Point(107, 13);
            this.ProductCombo.Name = "ProductCombo";
            this.ProductCombo.Size = new System.Drawing.Size(211, 21);
            this.ProductCombo.TabIndex = 0;
            this.ProductCombo.SelectedIndexChanged += new System.EventHandler(this.ProductCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Product:";
            // 
            // ExitButton
            // 
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(827, 141);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(74, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(744, 141);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(77, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete Item";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(650, 141);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(88, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update Item";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DiscontinueCheck);
            this.groupBox1.Controls.Add(this.StockedNumeric);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.ReorderNumeric);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.SupplierCombo);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.CategoryCombo);
            this.groupBox1.Controls.Add(this.QuanityField);
            this.groupBox1.Controls.Add(this.UnitsNumeric);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CostNumeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProductNameField);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 178);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details:";
            // 
            // DiscontinueCheck
            // 
            this.DiscontinueCheck.AutoSize = true;
            this.DiscontinueCheck.Location = new System.Drawing.Point(807, 118);
            this.DiscontinueCheck.Name = "DiscontinueCheck";
            this.DiscontinueCheck.Size = new System.Drawing.Size(88, 17);
            this.DiscontinueCheck.TabIndex = 17;
            this.DiscontinueCheck.Text = "Discontinued";
            this.DiscontinueCheck.UseVisualStyleBackColor = true;
            // 
            // StockedNumeric
            // 
            this.StockedNumeric.Location = new System.Drawing.Point(312, 63);
            this.StockedNumeric.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.StockedNumeric.Name = "StockedNumeric";
            this.StockedNumeric.Size = new System.Drawing.Size(120, 20);
            this.StockedNumeric.TabIndex = 16;
            // 
            // ReorderNumeric
            // 
            this.ReorderNumeric.Location = new System.Drawing.Point(521, 64);
            this.ReorderNumeric.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.ReorderNumeric.Name = "ReorderNumeric";
            this.ReorderNumeric.Size = new System.Drawing.Size(120, 20);
            this.ReorderNumeric.TabIndex = 15;
            // 
            // SupplierCombo
            // 
            this.SupplierCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierCombo.FormattingEnabled = true;
            this.SupplierCombo.Location = new System.Drawing.Point(701, 59);
            this.SupplierCombo.Name = "SupplierCombo";
            this.SupplierCombo.Size = new System.Drawing.Size(182, 21);
            this.SupplierCombo.TabIndex = 14;
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(701, 89);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(182, 21);
            this.CategoryCombo.TabIndex = 13;
            // 
            // QuanityField
            // 
            this.QuanityField.Location = new System.Drawing.Point(634, 27);
            this.QuanityField.Name = "QuanityField";
            this.QuanityField.Size = new System.Drawing.Size(249, 20);
            this.QuanityField.TabIndex = 12;
            // 
            // UnitsNumeric
            // 
            this.UnitsNumeric.Location = new System.Drawing.Point(416, 26);
            this.UnitsNumeric.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.UnitsNumeric.Name = "UnitsNumeric";
            this.UnitsNumeric.Size = new System.Drawing.Size(120, 20);
            this.UnitsNumeric.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(643, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Category:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Supplier:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stocked Units:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Reorder Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quanity per Unit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Units on Order:";
            // 
            // CostNumeric
            // 
            this.CostNumeric.DecimalPlaces = 2;
            this.CostNumeric.Location = new System.Drawing.Point(95, 63);
            this.CostNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CostNumeric.Name = "CostNumeric";
            this.CostNumeric.Size = new System.Drawing.Size(120, 20);
            this.CostNumeric.TabIndex = 4;
            this.CostNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost per Unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // ProductNameField
            // 
            this.ProductNameField.Location = new System.Drawing.Point(90, 26);
            this.ProductNameField.Name = "ProductNameField";
            this.ProductNameField.Size = new System.Drawing.Size(236, 20);
            this.ProductNameField.TabIndex = 0;
            this.ProductNameField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create New Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderGrid
            // 
            this.OrderGrid.AllowUserToAddRows = false;
            this.OrderGrid.AllowUserToDeleteRows = false;
            this.OrderGrid.AllowUserToResizeColumns = false;
            this.OrderGrid.AllowUserToResizeRows = false;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColOrderID,
            this.ColUnitPrice,
            this.ColQty,
            this.ColDiscount});
            this.OrderGrid.Location = new System.Drawing.Point(12, 224);
            this.OrderGrid.MultiSelect = false;
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.RowHeadersVisible = false;
            this.OrderGrid.Size = new System.Drawing.Size(909, 214);
            this.OrderGrid.TabIndex = 6;
            // 
            // ColOrderID
            // 
            this.ColOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColOrderID.FillWeight = 30F;
            this.ColOrderID.HeaderText = "Order ID";
            this.ColOrderID.Name = "ColOrderID";
            this.ColOrderID.ReadOnly = true;
            this.ColOrderID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColUnitPrice.FillWeight = 25F;
            this.ColUnitPrice.HeaderText = "Unit Price";
            this.ColUnitPrice.Name = "ColUnitPrice";
            this.ColUnitPrice.ReadOnly = true;
            this.ColUnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColQty
            // 
            this.ColQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColQty.FillWeight = 20F;
            this.ColQty.HeaderText = "Quantity";
            this.ColQty.Name = "ColQty";
            this.ColQty.ReadOnly = true;
            this.ColQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColDiscount
            // 
            this.ColDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDiscount.FillWeight = 20F;
            this.ColDiscount.HeaderText = "Discount";
            this.ColDiscount.Name = "ColDiscount";
            this.ColDiscount.ReadOnly = true;
            this.ColDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductCombo);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReorderNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown CostNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductNameField;
        private System.Windows.Forms.CheckBox DiscontinueCheck;
        private System.Windows.Forms.NumericUpDown StockedNumeric;
        private System.Windows.Forms.NumericUpDown ReorderNumeric;
        private System.Windows.Forms.ComboBox SupplierCombo;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.TextBox QuanityField;
        private System.Windows.Forms.NumericUpDown UnitsNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiscount;
    }
}

