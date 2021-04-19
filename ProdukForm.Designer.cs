using System;
using System.Windows.Forms;

namespace Supermarket
{
    partial class ProdukForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdukForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProdukGDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.KategoriCb = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.priceProduk = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button8 = new System.Windows.Forms.Button();
            this.QuantProduk = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button7 = new System.Windows.Forms.Button();
            this.NamaProduk = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button6 = new System.Windows.Forms.Button();
            this.IDProduk = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdukGDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.ProdukGDV);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.KategoriCb);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.priceProduk);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.QuantProduk);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.NamaProduk);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.IDProduk);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(206, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 751);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ProdukGDV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProdukGDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdukGDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdukGDV.BackgroundColor = System.Drawing.Color.White;
            this.ProdukGDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdukGDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdukGDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdukGDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProdukGDV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdukGDV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProdukGDV.EnableHeadersVisualStyles = false;
            this.ProdukGDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdukGDV.Location = new System.Drawing.Point(465, 131);
            this.ProdukGDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdukGDV.Name = "ProdukGDV";
            this.ProdukGDV.RowHeadersVisible = false;
            this.ProdukGDV.RowHeadersWidth = 62;
            this.ProdukGDV.RowTemplate.Height = 30;
            this.ProdukGDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdukGDV.Size = new System.Drawing.Size(700, 600);
            this.ProdukGDV.TabIndex = 20;
            this.ProdukGDV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ProdukGDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdukGDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProdukGDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProdukGDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProdukGDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProdukGDV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProdukGDV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdukGDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProdukGDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProdukGDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdukGDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProdukGDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProdukGDV.ThemeStyle.HeaderStyle.Height = 25;
            this.ProdukGDV.ThemeStyle.ReadOnly = false;
            this.ProdukGDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdukGDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdukGDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdukGDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdukGDV.ThemeStyle.RowsStyle.Height = 30;
            this.ProdukGDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdukGDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdukGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdukGDV_CellContentClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Teal;
            this.button12.Location = new System.Drawing.Point(146, 509);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(111, 46);
            this.button12.TabIndex = 16;
            this.button12.Text = "EDIT";
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
            this.button11.Location = new System.Drawing.Point(266, 509);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 46);
            this.button11.TabIndex = 15;
            this.button11.Text = "DELETE";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Teal;
            this.button10.Location = new System.Drawing.Point(26, 509);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 46);
            this.button10.TabIndex = 11;
            this.button10.Text = "ADD";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // KategoriCb
            // 
            this.KategoriCb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.KategoriCb.ForeColor = System.Drawing.Color.Teal;
            this.KategoriCb.FormattingEnabled = true;
            this.KategoriCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.KategoriCb.Location = new System.Drawing.Point(194, 412);
            this.KategoriCb.Name = "KategoriCb";
            this.KategoriCb.Size = new System.Drawing.Size(188, 31);
            this.KategoriCb.TabIndex = 14;
            this.KategoriCb.Text = "Select Category";
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(9, 412);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(178, 49);
            this.button9.TabIndex = 13;
            this.button9.Text = "CATEGORY";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // priceProduk
            // 
            this.priceProduk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceProduk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceProduk.HintForeColor = System.Drawing.Color.Empty;
            this.priceProduk.HintText = "";
            this.priceProduk.isPassword = false;
            this.priceProduk.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.priceProduk.LineIdleColor = System.Drawing.Color.White;
            this.priceProduk.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.priceProduk.LineThickness = 3;
            this.priceProduk.Location = new System.Drawing.Point(195, 342);
            this.priceProduk.Margin = new System.Windows.Forms.Padding(6);
            this.priceProduk.Name = "priceProduk";
            this.priceProduk.Size = new System.Drawing.Size(190, 54);
            this.priceProduk.TabIndex = 12;
            this.priceProduk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.priceProduk.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(-2, 343);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(138, 49);
            this.button8.TabIndex = 11;
            this.button8.Text = "PRICE";
            this.button8.UseVisualStyleBackColor = true;
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
            this.QuantProduk.Location = new System.Drawing.Point(195, 265);
            this.QuantProduk.Margin = new System.Windows.Forms.Padding(6);
            this.QuantProduk.Name = "QuantProduk";
            this.QuantProduk.Size = new System.Drawing.Size(190, 54);
            this.QuantProduk.TabIndex = 10;
            this.QuantProduk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QuantProduk.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(6, 271);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 49);
            this.button7.TabIndex = 9;
            this.button7.Text = "QUANTITY";
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
            this.NamaProduk.Location = new System.Drawing.Point(195, 194);
            this.NamaProduk.Margin = new System.Windows.Forms.Padding(6);
            this.NamaProduk.Name = "NamaProduk";
            this.NamaProduk.Size = new System.Drawing.Size(190, 54);
            this.NamaProduk.TabIndex = 8;
            this.NamaProduk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NamaProduk.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(10, 202);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 49);
            this.button6.TabIndex = 7;
            this.button6.Text = "NAME";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // IDProduk
            // 
            this.IDProduk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDProduk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDProduk.HintForeColor = System.Drawing.Color.Empty;
            this.IDProduk.HintText = "";
            this.IDProduk.isPassword = false;
            this.IDProduk.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.IDProduk.LineIdleColor = System.Drawing.Color.White;
            this.IDProduk.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.IDProduk.LineThickness = 3;
            this.IDProduk.Location = new System.Drawing.Point(195, 126);
            this.IDProduk.Margin = new System.Windows.Forms.Padding(6);
            this.IDProduk.Name = "IDProduk";
            this.IDProduk.Size = new System.Drawing.Size(190, 54);
            this.IDProduk.TabIndex = 6;
            this.IDProduk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IDProduk.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(20, 129);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "ID";
            this.button5.UseVisualStyleBackColor = true;
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
            this.button4.Text = "MANAGE PRODUCTS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(27, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.CadetBlue;
            this.button2.Location = new System.Drawing.Point(0, 231);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(1377, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.CadetBlue;
            this.button3.Location = new System.Drawing.Point(0, 745);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 51);
            this.button3.TabIndex = 11;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProdukForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 814);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProdukForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdukForm";
            this.Load += new System.EventHandler(this.ProdukForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProdukGDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QuantProduk;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NamaProduk;
        private System.Windows.Forms.Button button6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox IDProduk;
        private Bunifu.Framework.UI.BunifuMaterialTextbox priceProduk;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox KategoriCb;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private Guna.UI2.WinForms.Guna2DataGridView ProdukGDV;
        private System.Windows.Forms.Button button3;
    }
}