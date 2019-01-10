using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab3.DataClasses;

namespace Lab3
{
    /*AUTHOR: NICHOLAS SIM
  DATE: 01-09-2019
  CLASS: CPG200
  OBJECTIVE: Create a program that reads database and provides detailed information on products.
*/
    public partial class MainWindow : Form
    {


        private BindingList<Product> products = new BindingList<Product>();
        private BindingSource pBSource = new BindingSource();
        private BindingList<Supplier> suppliers = new BindingList<Supplier>();
        private BindingSource sBSource = new BindingSource();
        private BindingList<Category> categories = new BindingList<Category>();
        private BindingSource cBSource = new BindingSource();

        public MainWindow()
        {
            InitializeComponent();
            using (SqlConnection Sql = new SqlConnection(Program.ConnectionString))
            {
                Sql.Open();
                using (SqlCommand Command = new SqlCommand("SELECT ProductID,ProductName FROM Products;", Sql)) 
                {
                    SqlDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        products.Add(new Product(Reader.GetInt32(0), Reader.GetString(1))); //Adds it to the bindinglist to be used for combo box later.
                    }

                    Reader.Close(); //Closes the SQL Data Reader.
                }

                using (SqlCommand Command = new SqlCommand("SELECT SupplierID,CompanyName FROM Suppliers;", Sql))
                {
                    SqlDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        suppliers.Add(new Supplier(Reader.GetInt32(0), Reader.GetString(1))); //Adds it to the bindinglist to be used for combo box later.
                    }

                    Reader.Close();
                }

                using (SqlCommand Command = new SqlCommand("SELECT CategoryID,CategoryName FROM Categories;", Sql))
                {
                    SqlDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        categories.Add(new Category(Reader.GetInt32(0), Reader.GetString(1))); //Adds it to the bindinglist to be used for combo box later.
                    }
                }
            }

            ProductCombo.ValueMember = "ID";
            ProductCombo.DisplayMember = "Name";
            pBSource.DataSource = products;
            ProductCombo.DataSource = pBSource;
            SupplierCombo.ValueMember = "ID";
            SupplierCombo.DisplayMember = "Name";
            sBSource.DataSource = suppliers;
            SupplierCombo.DataSource = sBSource;
            CategoryCombo.ValueMember = "ID";
            CategoryCombo.DisplayMember = "Name";
            cBSource.DataSource = categories;
            CategoryCombo.DataSource = cBSource;


        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ProductCombo.SelectedValue != null)
                {
                    int Id = (int)ProductCombo.SelectedValue;
                    using (SqlConnection Sql = new SqlConnection(Program.ConnectionString))
                    {
                        Sql.Open();
                        using (SqlCommand Command = new SqlCommand("SELECT * FROM Products WHERE ProductID=@Id;", Sql)) //Selects from Product table where specific product id is defined.
                        {
                            Command.Parameters.AddWithValue("@Id", Id);
                            SqlDataReader Reader = Command.ExecuteReader();
                            while (Reader.Read())
                            {
                                ProductNameField.Text = Reader.GetString(1);
                                CostNumeric.Value = Reader.GetDecimal(5);
                                StockedNumeric.Value = Reader.GetInt16(6);
                                QuanityField.Text = Reader.GetString(4);
                                UnitsNumeric.Value = Reader.GetInt16(7);
                                ReorderNumeric.Value = Reader.GetInt16(8);
                                DiscontinueCheck.Checked = Reader.GetBoolean(9);

                                CategoryCombo.SelectedValue = Reader.GetInt32(3);
                                SupplierCombo.SelectedValue = Reader.GetInt32(2);
                            }
                            Reader.Close();
                        }
                        using (SqlCommand Command = new SqlCommand("SELECT * FROM [Order Details] WHERE ProductID=@Id;", Sql))
                        {
                            OrderGrid.Rows.Clear();
                            Command.Parameters.AddWithValue("@Id", Id);
                            SqlDataReader Reader = Command.ExecuteReader();
                            while (Reader.Read())
                            {
                                OrderGrid.Rows.Add(Reader.GetInt32(0), Reader.GetDecimal(2), Reader.GetInt16(3), Reader.GetFloat(4));
                               
                            }
                        }

                    }
                }
                else
                {
                    if(ProductCombo.Items.Count > 0)
                    {
                        ProductCombo.SelectedIndex = 0;
                    }
                }
            }
            catch (SqlException ex) 
            {
                MessageBox.Show("Error: " + ex.Message, "SQL Exception");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Closes the program.
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = (int)ProductCombo.SelectedValue;
                using (SqlConnection Sql = new SqlConnection(Program.ConnectionString))
                {
                    Sql.Open();
                    using (SqlCommand Command = new SqlCommand("UPDATE Products SET ProductName=@Name, SupplierID=@SupID, CategoryID=@CatID, QuantityPerUnit=@QunUnit, " +
                        "UnitPrice=@Price, UnitsInStock=@Stock, UnitsOnOrder=@Order, ReorderLevel=@Reorder, Discontinued=@Discontinued WHERE ProductID=@Id;", Sql))
                    {
                        Command.Parameters.AddWithValue("@Id", Id);
                        Command.Parameters.AddWithValue("@Name", ProductNameField.Text);
                        Command.Parameters.AddWithValue("@SupId", SupplierCombo.SelectedValue);
                        Command.Parameters.AddWithValue("@CatID", CategoryCombo.SelectedValue);
                        Command.Parameters.AddWithValue("@QunUnit", QuanityField.Text);
                        Command.Parameters.AddWithValue("@Price", CostNumeric.Value);
                        Command.Parameters.AddWithValue("@Stock", StockedNumeric.Value);
                        Command.Parameters.AddWithValue("@Order", UnitsNumeric.Value);
                        Command.Parameters.AddWithValue("@Reorder", ReorderNumeric.Value);
                        Command.Parameters.AddWithValue("@Discontinued", DiscontinueCheck.Checked); //Binds the parameter selected with a value.
                        int i = Command.ExecuteNonQuery();
                        Product px = (Product)ProductCombo.SelectedItem;
                        string nx = ProductNameField.Text;
                        int vx = (int)ProductCombo.SelectedValue;
                        products.Remove(px);
                        products.Add(new Product(vx, nx));
                        ProductCombo.SelectedValue = vx;

                        MessageBox.Show("Rows updated: " + i);
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SQL Exception");
            }

     
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = (int)ProductCombo.SelectedValue;
                using (SqlConnection Sql = new SqlConnection(Program.ConnectionString))
                {
                    Sql.Open();
                    using (SqlCommand Command = new SqlCommand("DELETE FROM Products WHERE ProductID=@Id;", Sql))
                    {
                        Command.Parameters.AddWithValue("@Id", Id);
                        int i = Command.ExecuteNonQuery();
                        Product px = (Product)ProductCombo.SelectedItem;
                        string nx = ProductNameField.Text;
                        int vx = (int)ProductCombo.SelectedValue;
                        products.Remove(px);
                        ProductCombo.SelectedValue = vx;

                        MessageBox.Show("Rows updated: " + i);
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SQL Exception");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = (int)ProductCombo.SelectedValue;
            using (SqlConnection Sql = new SqlConnection(Program.ConnectionString))
            {
                Sql.Open();
                using (SqlCommand Command = new SqlCommand("INSERT INTO Products (ProductName, SupplierId, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, " +
                    "UnitsOnOrder, ReorderLevel, Discontinued) VALUES (@Name, @SupId, @CatID, @Quanity, @Price, @Stock, @Order, @Reorder, @Discontinued )", Sql))
                {
                    Command.Parameters.AddWithValue("@Name", ProductNameField.Text);
                    Command.Parameters.AddWithValue("@SupId", SupplierCombo.SelectedValue);
                    Command.Parameters.AddWithValue("@CatID", CategoryCombo.SelectedValue);
                    Command.Parameters.AddWithValue("@Quanity", QuanityField.Text);
                    Command.Parameters.AddWithValue("@Price", CostNumeric.Value);
                    Command.Parameters.AddWithValue("@Stock", StockedNumeric.Value);
                    Command.Parameters.AddWithValue("@Order", UnitsNumeric.Value);
                    Command.Parameters.AddWithValue("@Reorder", ReorderNumeric.Value);
                    Command.Parameters.AddWithValue("@Discontinued", DiscontinueCheck.Checked);

                    int i = Command.ExecuteNonQuery();
                    using (SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 ProductID FROM Products WHERE ProductName = @name ORDER BY ProductID DESC;", Sql))
                    {
                        cmd2.Parameters.AddWithValue("@name", ProductNameField.Text);
                        int id = (int)cmd2.ExecuteScalar();
                        products.Add(new Product(id, ProductNameField.Text));
                        ProductCombo.SelectedValue = id;
                    }

                    MessageBox.Show("Rows updated: " + i);
                }
            }
        }
    }
}
