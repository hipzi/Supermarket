
using System;

namespace Supermarket
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.OrderGDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amountlbl = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SellerNamelbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PriceProduk = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.ProdukGDV1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Datelabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BillsGDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.QuantProduk = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button7 = new System.Windows.Forms.Button();
            this.NamaProduk = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button6 = new System.Windows.Forms.Button();
            this.IDBill = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdukGDV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsGDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.OrderGDV);
            this.panel1.Controls.Add(this.Amountlbl);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.SellerNamelbl);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.PriceProduk);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ProdukGDV1);
            this.panel1.Controls.Add(this.Datelabel);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.BillsGDV);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.QuantProduk);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.NamaProduk);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.IDBill);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(196, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 751);
            this.panel1.TabIndex = 1;
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(525, 371);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(316, 51);
            this.button13.TabIndex = 32;
            this.button13.Text = "SELL LIST";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // OrderGDV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.OrderGDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderGDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGDV.BackgroundColor = System.Drawing.Color.White;
            this.OrderGDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderGDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderGDV.ColumnHeadersHeight = 25;
            this.OrderGDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nama,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGDV.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderGDV.EnableHeadersVisualStyles = false;
            this.OrderGDV.GridColor = System.Drawing.Color.PowderBlue;
            this.OrderGDV.Location = new System.Drawing.Point(502, 100);
            this.OrderGDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderGDV.Name = "OrderGDV";
            this.OrderGDV.RowHeadersVisible = false;
            this.OrderGDV.RowHeadersWidth = 62;
            this.OrderGDV.RowTemplate.Height = 30;
            this.OrderGDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGDV.Size = new System.Drawing.Size(654, 216);
            this.OrderGDV.TabIndex = 31;
            this.OrderGDV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.OrderGDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderGDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderGDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderGDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderGDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderGDV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderGDV.ThemeStyle.GridColor = System.Drawing.Color.PowderBlue;
            this.OrderGDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.OrderGDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderGDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderGDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderGDV.ThemeStyle.HeaderStyle.Height = 25;
            this.OrderGDV.ThemeStyle.ReadOnly = false;
            this.OrderGDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderGDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderGDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderGDV.ThemeStyle.RowsStyle.Height = 30;
            this.OrderGDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGDV_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "IDProduk";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "NamaProduk";
            this.Nama.MinimumWidth = 8;
            this.Nama.Name = "Nama";
            // 
            // Price
            // 
            this.Price.HeaderText = "PriceProduk";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            // 
            // Amountlbl
            // 
            this.Amountlbl.FlatAppearance.BorderSize = 0;
            this.Amountlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Amountlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlbl.ForeColor = System.Drawing.Color.White;
            this.Amountlbl.Location = new System.Drawing.Point(804, 326);
            this.Amountlbl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Amountlbl.Name = "Amountlbl";
            this.Amountlbl.Size = new System.Drawing.Size(316, 51);
            this.Amountlbl.TabIndex = 30;
            this.Amountlbl.Text = "Rs";
            this.Amountlbl.UseVisualStyleBackColor = true;
            this.Amountlbl.Click += new System.EventHandler(this.Amountlbl_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(525, 326);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(316, 51);
            this.button8.TabIndex = 29;
            this.button8.Text = "Amount";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(116, 416);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 45);
            this.button3.TabIndex = 28;
            this.button3.Text = "Add Product";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SellerNamelbl
            // 
            this.SellerNamelbl.AutoSize = true;
            this.SellerNamelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SellerNamelbl.ForeColor = System.Drawing.Color.White;
            this.SellerNamelbl.Location = new System.Drawing.Point(27, 69);
            this.SellerNamelbl.Name = "SellerNamelbl";
            this.SellerNamelbl.Size = new System.Drawing.Size(74, 28);
            this.SellerNamelbl.TabIndex = 27;
            this.SellerNamelbl.Text = "Seller";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(332, 471);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 26;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PriceProduk
            // 
            this.PriceProduk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceProduk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceProduk.HintForeColor = System.Drawing.Color.Empty;
            this.PriceProduk.HintText = "";
            this.PriceProduk.isPassword = false;
            this.PriceProduk.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.PriceProduk.LineIdleColor = System.Drawing.Color.White;
            this.PriceProduk.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.PriceProduk.LineThickness = 3;
            this.PriceProduk.Location = new System.Drawing.Point(195, 259);
            this.PriceProduk.Margin = new System.Windows.Forms.Padding(6);
            this.PriceProduk.Name = "PriceProduk";
            this.PriceProduk.Size = new System.Drawing.Size(253, 54);
            this.PriceProduk.TabIndex = 25;
            this.PriceProduk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PriceProduk.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "Price";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProdukGDV1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ProdukGDV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProdukGDV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdukGDV1.BackgroundColor = System.Drawing.Color.White;
            this.ProdukGDV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdukGDV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdukGDV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdukGDV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ProdukGDV1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdukGDV1.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProdukGDV1.EnableHeadersVisualStyles = false;
            this.ProdukGDV1.GridColor = System.Drawing.Color.PowderBlue;
            this.ProdukGDV1.Location = new System.Drawing.Point(32, 519);
            this.ProdukGDV1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdukGDV1.Name = "ProdukGDV1";
            this.ProdukGDV1.RowHeadersVisible = false;
            this.ProdukGDV1.RowHeadersWidth = 62;
            this.ProdukGDV1.RowTemplate.Height = 30;
            this.ProdukGDV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdukGDV1.Size = new System.Drawing.Size(416, 211);
            this.ProdukGDV1.TabIndex = 23;
            this.ProdukGDV1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ProdukGDV1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdukGDV1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProdukGDV1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProdukGDV1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProdukGDV1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProdukGDV1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProdukGDV1.ThemeStyle.GridColor = System.Drawing.Color.PowderBlue;
            this.ProdukGDV1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.ProdukGDV1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProdukGDV1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdukGDV1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProdukGDV1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProdukGDV1.ThemeStyle.HeaderStyle.Height = 25;
            this.ProdukGDV1.ThemeStyle.ReadOnly = false;
            this.ProdukGDV1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdukGDV1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdukGDV1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdukGDV1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdukGDV1.ThemeStyle.RowsStyle.Height = 30;
            this.ProdukGDV1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdukGDV1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdukGDV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdukGDV1_CellContentClick);
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Datelabel.ForeColor = System.Drawing.Color.White;
            this.Datelabel.Location = new System.Drawing.Point(976, 46);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(67, 28);
            this.Datelabel.TabIndex = 22;
            this.Datelabel.Text = "Date";
            this.Datelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBox1.ForeColor = System.Drawing.Color.Teal;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox1.Location = new System.Drawing.Point(30, 477);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 31);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "Select Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // BillsGDV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.BillsGDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.BillsGDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsGDV.BackgroundColor = System.Drawing.Color.White;
            this.BillsGDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsGDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsGDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsGDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BillsGDV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillsGDV.DefaultCellStyle = dataGridViewCellStyle9;
            this.BillsGDV.EnableHeadersVisualStyles = false;
            this.BillsGDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsGDV.Location = new System.Drawing.Point(502, 431);
            this.BillsGDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillsGDV.Name = "BillsGDV";
            this.BillsGDV.RowHeadersVisible = false;
            this.BillsGDV.RowHeadersWidth = 62;
            this.BillsGDV.RowTemplate.Height = 30;
            this.BillsGDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsGDV.Size = new System.Drawing.Size(654, 216);
            this.BillsGDV.TabIndex = 20;
            this.BillsGDV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.BillsGDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillsGDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillsGDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillsGDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillsGDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillsGDV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillsGDV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsGDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BillsGDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillsGDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillsGDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillsGDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillsGDV.ThemeStyle.HeaderStyle.Height = 25;
            this.BillsGDV.ThemeStyle.ReadOnly = false;
            this.BillsGDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillsGDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsGDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillsGDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillsGDV.ThemeStyle.RowsStyle.Height = 30;
            this.BillsGDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsGDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillsGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsGDV_CellContentClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Teal;
            this.button12.Location = new System.Drawing.Point(766, 684);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(111, 46);
            this.button12.TabIndex = 16;
            this.button12.Text = "PRINT";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Teal;
            this.button11.Location = new System.Drawing.Point(886, 684);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 46);
            this.button11.TabIndex = 15;
            this.button11.Text = "DELETE";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Teal;
            this.button10.Location = new System.Drawing.Point(646, 684);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 46);
            this.button10.TabIndex = 11;
            this.button10.Text = "ADD";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // QuantProduk
            // 
            this.QuantProduk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantProduk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuantProduk.HintForeColor = System.Drawing.Color.Empty;
            this.QuantProduk.HintText = "";
            this.QuantProduk.isPassword = false;
            this.QuantProduk.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.QuantProduk.LineIdleColor = System.Drawing.Color.White;
            this.QuantProduk.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.QuantProduk.LineThickness = 3;
            this.QuantProduk.Location = new System.Drawing.Point(193, 320);
            this.QuantProduk.Margin = new System.Windows.Forms.Padding(6);
            this.QuantProduk.Name = "QuantProduk";
            this.QuantProduk.Size = new System.Drawing.Size(255, 54);
            this.QuantProduk.TabIndex = 10;
            this.QuantProduk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(23, 326);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 49);
            this.button7.TabIndex = 9;
            this.button7.Text = "Quantity";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // NamaProduk
            // 
            this.NamaProduk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamaProduk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NamaProduk.HintForeColor = System.Drawing.Color.Empty;
            this.NamaProduk.HintText = "";
            this.NamaProduk.isPassword = false;
            this.NamaProduk.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.NamaProduk.LineIdleColor = System.Drawing.Color.White;
            this.NamaProduk.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.NamaProduk.LineThickness = 3;
            this.NamaProduk.Location = new System.Drawing.Point(195, 185);
            this.NamaProduk.Margin = new System.Windows.Forms.Padding(6);
            this.NamaProduk.Name = "NamaProduk";
            this.NamaProduk.Size = new System.Drawing.Size(253, 54);
            this.NamaProduk.TabIndex = 8;
            this.NamaProduk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NamaProduk.OnValueChanged += new System.EventHandler(this.NamaProduk_OnValueChanged);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(23, 193);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 49);
            this.button6.TabIndex = 7;
            this.button6.Text = "ProdName";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // IDBill
            // 
            this.IDBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDBill.HintForeColor = System.Drawing.Color.Empty;
            this.IDBill.HintText = "";
            this.IDBill.isPassword = false;
            this.IDBill.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.IDBill.LineIdleColor = System.Drawing.Color.White;
            this.IDBill.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.IDBill.LineThickness = 3;
            this.IDBill.Location = new System.Drawing.Point(195, 113);
            this.IDBill.Margin = new System.Windows.Forms.Padding(6);
            this.IDBill.Name = "IDBill";
            this.IDBill.Size = new System.Drawing.Size(253, 54);
            this.IDBill.TabIndex = 6;
            this.IDBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IDBill.OnValueChanged += new System.EventHandler(this.IDBill_OnValueChanged);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(23, 116);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "BILL ID";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(465, 32);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(316, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "SELLING";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 814);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdukGDV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsGDV)).EndInit();
            this.ResumeLayout(false);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Datelabel.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void IDBill_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView BillsGDV;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QuantProduk;
        private System.Windows.Forms.Button button7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NamaProduk;
        private System.Windows.Forms.Button button6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox IDBill;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView ProdukGDV1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceProduk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SellerNamelbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Amountlbl;
        private Guna.UI2.WinForms.Guna2DataGridView OrderGDV;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}