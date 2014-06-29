using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineShop_v2
{

    public partial class AdminPanel : Form
    {

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Activate(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserGrid.Rows.Clear();
            foreach (var user in Lists.users)
            {
                UserGrid.Rows.Add(user.Name);
            }




        }

        private void UserGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowCategories_Click(object sender, EventArgs e)
        {
            categoriesGrid.Rows.Clear();
            foreach (var item in Lists.brands)
            {
                categoriesGrid.Rows.Add(item.Name);
            }
        }

        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            productsGrid.Rows.Clear();
            foreach (var item in Lists.product)
            {

                productsGrid.Rows.Add(item.Name, item.Brand, item.Cost, item.Description);
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            
            Pannels.addnewproduct.Show();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUser anu = new AddNewUser();
            anu.Show();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            Pannels.addnewbrand.Show();
        }

        private void btnToShop_Click(object sender, EventArgs e)
        {
            object[] arr = new object[4];
            bool isExists = false;
            arr[0] = storeGrid[0, storeGrid.CurrentCell.RowIndex].Value;
            arr[1] = storeGrid[1, storeGrid.CurrentCell.RowIndex].Value;
            arr[2] = storeGrid[2, storeGrid.CurrentCell.RowIndex].Value;
            arr[3] = 1;
            //MessageBox.Show(arr[0].ToString());
            if (shopGrid.Rows.Count > 1)
            {
                for (int i = 0; i < shopGrid.Rows.Count-1; i++)
                {
                    if (arr[0].ToString() == shopGrid[0, i].Value.ToString())
                    {
                        if (shopGrid[3, i].Value != null)
                        {
                            //int? tmp = int.Parse();
                            shopGrid[3, i].Value = (int.Parse(shopGrid[3, i].Value.ToString()) + 1).ToString();
                            isExists = true;
                        }
                    }
                }
            }
            if (!isExists)
            {
                shopGrid.Rows.Add(arr);
            }


        }

        private void tabShop_OnGotFocus(object sender, EventArgs e)
        {


        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            storeGrid.Rows.Clear();
            shopGrid.Rows.Clear();
            foreach (var item in Lists.product)
            {
                storeGrid.Rows.Add(item.Name, item.Brand, item.Cost);
            }
            foreach (var item in Lists.productInShop)
            {
                storeGrid.Rows.Add(item.Name, item.Brand, item.Cost,item.Number);
            }
        }



    }
}
