﻿namespace Motor_Yard
{
    partial class Customers
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Ratings_Customers = new System.Windows.Forms.TabPage();
            this.tabPage_DiscountOffered_Customers = new System.Windows.Forms.TabPage();
            this.tabPage_Requests_Customers = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Ratings_Customers);
            this.tabControl1.Controls.Add(this.tabPage_DiscountOffered_Customers);
            this.tabControl1.Controls.Add(this.tabPage_Requests_Customers);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 384);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Ratings_Customers
            // 
            this.tabPage_Ratings_Customers.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Ratings_Customers.Name = "tabPage_Ratings_Customers";
            this.tabPage_Ratings_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Ratings_Customers.Size = new System.Drawing.Size(545, 356);
            this.tabPage_Ratings_Customers.TabIndex = 0;
            this.tabPage_Ratings_Customers.Text = "Ratings";
            this.tabPage_Ratings_Customers.UseVisualStyleBackColor = true;
            // 
            // tabPage_DiscountOffered_Customers
            // 
            this.tabPage_DiscountOffered_Customers.Location = new System.Drawing.Point(4, 24);
            this.tabPage_DiscountOffered_Customers.Name = "tabPage_DiscountOffered_Customers";
            this.tabPage_DiscountOffered_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DiscountOffered_Customers.Size = new System.Drawing.Size(545, 356);
            this.tabPage_DiscountOffered_Customers.TabIndex = 1;
            this.tabPage_DiscountOffered_Customers.Text = "Discount Offered";
            this.tabPage_DiscountOffered_Customers.UseVisualStyleBackColor = true;
            // 
            // tabPage_Requests_Customers
            // 
            this.tabPage_Requests_Customers.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Requests_Customers.Name = "tabPage_Requests_Customers";
            this.tabPage_Requests_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Requests_Customers.Size = new System.Drawing.Size(545, 356);
            this.tabPage_Requests_Customers.TabIndex = 2;
            this.tabPage_Requests_Customers.Text = "Requests";
            this.tabPage_Requests_Customers.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 387);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Control System - Customers";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Ratings_Customers;
        private System.Windows.Forms.TabPage tabPage_DiscountOffered_Customers;
        private System.Windows.Forms.TabPage tabPage_Requests_Customers;
    }
}