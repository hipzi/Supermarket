namespace Supermarket
{
    partial class SellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PassSeller = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.PhoneSeller = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button8 = new System.Windows.Forms.Button();
            this.AgeSeller = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button7 = new System.Windows.Forms.Button();
            this.NamaSeller = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button6 = new System.Windows.Forms.Button();
            this.IDSeller = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SellerGDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerGDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.SellerGDV);
            this.panel1.Controls.Add(this.PassSeller);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.PhoneSeller);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.AgeSeller);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.NamaSeller);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.IDSeller);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(137, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 488);
            this.panel1.TabIndex = 1;
            // 
            // PassSeller
            // 
            this.PassSeller.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassSeller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassSeller.HintForeColor = System.Drawing.Color.Empty;
            this.PassSeller.HintText = "";
            this.PassSeller.isPassword = false;
            this.PassSeller.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.PassSeller.LineIdleColor = System.Drawing.Color.White;
            this.PassSeller.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.PassSeller.LineThickness = 3;
            this.PassSeller.Location = new System.Drawing.Point(130, 268);
            this.PassSeller.Margin = new System.Windows.Forms.Padding(4);
            this.PassSeller.Name = "PassSeller";
            this.PassSeller.Size = new System.Drawing.Size(127, 25);
            this.PassSeller.TabIndex = 20;
            this.PassSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Teal;
            this.button12.Location = new System.Drawing.Point(97, 331);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(74, 30);
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
            this.button11.Location = new System.Drawing.Point(177, 331);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 30);
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
            this.button10.Location = new System.Drawing.Point(17, 331);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 30);
            this.button10.TabIndex = 11;
            this.button10.Text = "ADD";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(7, 269);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(119, 32);
            this.button9.TabIndex = 13;
            this.button9.Text = "PASSWORD";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // PhoneSeller
            // 
            this.PhoneSeller.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneSeller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PhoneSeller.HintForeColor = System.Drawing.Color.Empty;
            this.PhoneSeller.HintText = "";
            this.PhoneSeller.isPassword = false;
            this.PhoneSeller.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneSeller.LineIdleColor = System.Drawing.Color.White;
            this.PhoneSeller.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneSeller.LineThickness = 3;
            this.PhoneSeller.Location = new System.Drawing.Point(130, 222);
            this.PhoneSeller.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneSeller.Name = "PhoneSeller";
            this.PhoneSeller.Size = new System.Drawing.Size(127, 25);
            this.PhoneSeller.TabIndex = 12;
            this.PhoneSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(8, 223);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 32);
            this.button8.TabIndex = 11;
            this.button8.Text = "PHONE";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // AgeSeller
            // 
            this.AgeSeller.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeSeller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AgeSeller.HintForeColor = System.Drawing.Color.Empty;
            this.AgeSeller.HintText = "";
            this.AgeSeller.isPassword = false;
            this.AgeSeller.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.AgeSeller.LineIdleColor = System.Drawing.Color.White;
            this.AgeSeller.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.AgeSeller.LineThickness = 3;
            this.AgeSeller.Location = new System.Drawing.Point(130, 172);
            this.AgeSeller.Margin = new System.Windows.Forms.Padding(4);
            this.AgeSeller.Name = "AgeSeller";
            this.AgeSeller.Size = new System.Drawing.Size(127, 28);
            this.AgeSeller.TabIndex = 10;
            this.AgeSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(6, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 32);
            this.button7.TabIndex = 9;
            this.button7.Text = "AGE";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // NamaSeller
            // 
            this.NamaSeller.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamaSeller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NamaSeller.HintForeColor = System.Drawing.Color.Empty;
            this.NamaSeller.HintText = "";
            this.NamaSeller.isPassword = false;
            this.NamaSeller.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.NamaSeller.LineIdleColor = System.Drawing.Color.White;
            this.NamaSeller.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.NamaSeller.LineThickness = 3;
            this.NamaSeller.Location = new System.Drawing.Point(130, 126);
            this.NamaSeller.Margin = new System.Windows.Forms.Padding(4);
            this.NamaSeller.Name = "NamaSeller";
            this.NamaSeller.Size = new System.Drawing.Size(127, 28);
            this.NamaSeller.TabIndex = 8;
            this.NamaSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(7, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 32);
            this.button6.TabIndex = 7;
            this.button6.Text = "NAME";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // IDSeller
            // 
            this.IDSeller.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDSeller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDSeller.HintForeColor = System.Drawing.Color.Empty;
            this.IDSeller.HintText = "";
            this.IDSeller.isPassword = false;
            this.IDSeller.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.IDSeller.LineIdleColor = System.Drawing.Color.White;
            this.IDSeller.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.IDSeller.LineThickness = 3;
            this.IDSeller.Location = new System.Drawing.Point(130, 82);
            this.IDSeller.Margin = new System.Windows.Forms.Padding(4);
            this.IDSeller.Name = "IDSeller";
            this.IDSeller.Size = new System.Drawing.Size(127, 28);
            this.IDSeller.TabIndex = 6;
            this.IDSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IDSeller.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(13, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 32);
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
            this.button4.Location = new System.Drawing.Point(310, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "MANAGE SELLERS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(918, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.CadetBlue;
            this.button3.Location = new System.Drawing.Point(18, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Selling";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.CadetBlue;
            this.button2.Location = new System.Drawing.Point(11, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(18, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerGDV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SellerGDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SellerGDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellerGDV.BackgroundColor = System.Drawing.Color.White;
            this.SellerGDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerGDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerGDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerGDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SellerGDV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellerGDV.DefaultCellStyle = dataGridViewCellStyle3;
            this.SellerGDV.EnableHeadersVisualStyles = false;
            this.SellerGDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerGDV.Location = new System.Drawing.Point(310, 85);
            this.SellerGDV.Name = "SellerGDV";
            this.SellerGDV.RowHeadersVisible = false;
            this.SellerGDV.RowTemplate.Height = 30;
            this.SellerGDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellerGDV.Size = new System.Drawing.Size(467, 390);
            this.SellerGDV.TabIndex = 21;
            this.SellerGDV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.SellerGDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerGDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellerGDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellerGDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellerGDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellerGDV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellerGDV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerGDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SellerGDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellerGDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerGDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellerGDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellerGDV.ThemeStyle.HeaderStyle.Height = 25;
            this.SellerGDV.ThemeStyle.ReadOnly = false;
            this.SellerGDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerGDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerGDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerGDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerGDV.ThemeStyle.RowsStyle.Height = 30;
            this.SellerGDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerGDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerGDV_CellContentClick);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 529);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SellerGDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneSeller;
        private System.Windows.Forms.Button button8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AgeSeller;
        private System.Windows.Forms.Button button7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NamaSeller;
        private System.Windows.Forms.Button button6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox IDSeller;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PassSeller;
        private System.Windows.Forms.Button button9;
        private Guna.UI2.WinForms.Guna2DataGridView SellerGDV;
    }
}