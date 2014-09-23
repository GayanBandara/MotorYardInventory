﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motor_Yard
{
    public partial class Stock_Control : Form
    {
        public Stock_Control(int index)
        {
            InitializeComponent();

            if (index == 1) 
            {
                tabControl1.SelectedTab = tabPageAddNewStock;
                tabPageClearStock.Enabled = false;
                tabPageDeleteStock.Enabled = false;
                tabPageStockStatus.Enabled = false;
                tabPageUpdateStock.Enabled = false;
            }

            else if (index == 2) 
            {
                tabControl1.SelectedTab = tabPageUpdateStock;
                tabPageAddNewStock.Enabled = false;
                tabPageDeleteStock.Enabled = false;
                tabPageStockStatus.Enabled = false;
                tabPageClearStock.Enabled = false;
            }

            else if (index == 3)
            {
                tabControl1.SelectedTab = tabPageDeleteStock;
                tabPageAddNewStock.Enabled = false;
                tabPageClearStock.Enabled = false;
                tabPageStockStatus.Enabled = false;
                tabPageUpdateStock.Enabled = false;
            }

            else if (index == 4)
            {
                tabControl1.SelectedTab = tabPageClearStock;
                tabPageAddNewStock.Enabled = false;
                tabPageDeleteStock.Enabled = false;
                tabPageStockStatus.Enabled = false;
                tabPageUpdateStock.Enabled = false;
            }

            else if (index == 5)
            {
                tabControl1.SelectedTab = tabPageStockStatus;
                tabPageAddNewStock.Enabled = false;
                tabPageDeleteStock.Enabled = false;
                tabPageClearStock.Enabled = false;
                tabPageUpdateStock.Enabled = false;
            }

        }
        long brand_id;
        long cinId;
        long model_id;
        long fuel_id;
        long engine_id;
        long year;
        long cat_id;
        long part_id;
        long quantity_in;
        long unit_price;
        string brand_name;
        string model_name;
        string fuel_type;
        long engine_capacity;
        string cat_name;
        string part_name;


        private void pictureBoxClearButton_Click(object sender, EventArgs e)
        {
            String itemCode = textBox_ItemCode_ClearStock.Text;
            String repeatitemCode = textBox_RepeatItemCode_ClearStock.Text;

            if (itemCode == repeatitemCode)
            {
                MessageBox.Show("ItemCode : " + itemCode + "\nQuantity on Hand : " + 12, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("Check Item Code", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxDeleteButton_Click(object sender, EventArgs e)
        {
            String itemCode = textBox_ItemCode_DeleteStock.Text;
            String repeatitemCode = textBox_RepeatItemCode_DeleteStock.Text;

            if (itemCode == repeatitemCode)
            {
                MessageBox.Show("ItemCode : " + itemCode + "\n Item Name : Door ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("Check Item Code", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxUpdateButton_Click(object sender, EventArgs e)
        {
            string itemCode = textBox_ItemCode_UpdateStock.Text;
            string QuantityIn=textBox_QuantityIn_UpdateStock.Text;

            DatabaseConnections db = new DatabaseConnections();
            long QuantityHand = db.CheckQuantity(itemCode);

            if(QuantityHand>-1)
            MessageBox.Show("Item Code : "+itemCode+"\nQuantity In : "+QuantityIn, "Verify Item Code and Quantity In", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            else
            {
            MessageBox.Show("Check Item code : " + itemCode, "Invalid Item Code", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxAddButton_Click(object sender, EventArgs e)
        {

            brand_id = Convert.ToInt64(textBoxBrandId_AddStock.Text);
            model_id = Convert.ToInt64(textBoxModelId_AddStock.Text);
            fuel_id = Convert.ToInt64(textBoxFuelId_AddStock.Text);
            engine_id = Convert.ToInt64(textBoxEngineId_AddStock.Text);
            year=Convert.ToInt64(textBoxYear_AddStock.Text);
            cat_id = Convert.ToInt64(textBoxCatId_AddStock.Text);
            part_id = Convert.ToInt64(textBoxPartId_AddStock.Text);
            quantity_in=Convert.ToInt64(textBoxQuantityIn_AddStock.Text);
            unit_price = Convert.ToInt64(textBoxUnitPrice_AddStock.Text);
            brand_name=comboBoxBrandName_AddStock.Text;
            model_name=comboBoxModelName_AddStock.Text;
            fuel_type=comboBoxFuelType_AddStock.Text;
            engine_capacity = Convert.ToInt64(comboBoxEngineCapacity_AddStock.Text);
            cat_name=comboBoxCatName_AddStock.Text;
            part_name=comboBoxPartName_AddStock.Text;


            DatabaseConnections db=new DatabaseConnections();
            db.AddNewStock( brand_id, brand_name, model_id, model_name, fuel_id, fuel_type, engine_id, engine_capacity, year, year,cat_id, cat_name, part_id, part_name, quantity_in,unit_price) ;
        }     
    }
}
