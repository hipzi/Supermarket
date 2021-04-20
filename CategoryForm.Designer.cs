namespace Supermarket
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.KategoriGDV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.DeskripsiKategori = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button7 = new System.Windows.Forms.Button();
            this.NamaKategori = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button6 = new System.Windows.Forms.Button();
            this.IDKategori = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KategoriGDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.KategoriGDV);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.DeskripsiKategori);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.NamaKategori);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.IDKategori);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(206, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 751);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // KategoriGDV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.KategoriGDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.KategoriGDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KategoriGDV.BackgroundColor = System.Drawing.Color.White;
            this.KategoriGDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KategoriGDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KategoriGDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KategoriGDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.KategoriGDV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KategoriGDV.DefaultCellStyle = dataGridViewCellStyle3;
            this.KategoriGDV.EnableHeadersVisualStyles = false;
            this.KategoriGDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KategoriGDV.Location = new System.Drawing.Point(465, 131);
            this.KategoriGDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KategoriGDV.Name = "KategoriGDV";
            this.KategoriGDV.RowHeadersVisible = false;
            this.KategoriGDV.RowHeadersWidth = 62;
            this.KategoriGDV.RowTemplate.Height = 30;
            this.KategoriGDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KategoriGDV.Size = new System.Drawing.Size(700, 600);
            this.KategoriGDV.TabIndex = 18;
            this.KategoriGDV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.KategoriGDV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.KategoriGDV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.KategoriGDV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.KategoriGDV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.KategoriGDV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.KategoriGDV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.KategoriGDV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KategoriGDV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.KategoriGDV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KategoriGDV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KategoriGDV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.KategoriGDV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.KategoriGDV.ThemeStyle.HeaderStyle.Height = 25;
            this.KategoriGDV.ThemeStyle.ReadOnly = false;
            this.KategoriGDV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.KategoriGDV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KategoriGDV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KategoriGDV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.KategoriGDV.ThemeStyle.RowsStyle.Height = 30;
            this.KategoriGDV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KategoriGDV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.KategoriGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KategoriGDV_CellContentClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Teal;
            this.button12.Location = new System.Drawing.Point(146, 377);
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
            this.button11.Location = new System.Drawing.Point(266, 377);
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
            this.button10.Location = new System.Drawing.Point(26, 377);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 46);
            this.button10.TabIndex = 11;
            this.button10.Text = "ADD";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // DeskripsiKategori
            // 
            this.DeskripsiKategori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeskripsiKategori.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskripsiKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeskripsiKategori.HintForeColor = System.Drawing.Color.Empty;
            this.DeskripsiKategori.HintText = "";
            this.DeskripsiKategori.isPassword = false;
            this.DeskripsiKategori.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.DeskripsiKategori.LineIdleColor = System.Drawing.Color.White;
            this.DeskripsiKategori.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.DeskripsiKategori.LineThickness = 3;
            this.DeskripsiKategori.Location = new System.Drawing.Point(214, 265);
            this.DeskripsiKategori.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeskripsiKategori.Name = "DeskripsiKategori";
            this.DeskripsiKategori.Size = new System.Drawing.Size(190, 54);
            this.DeskripsiKategori.TabIndex = 10;
            this.DeskripsiKategori.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(14, 272);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 49);
            this.button7.TabIndex = 9;
            this.button7.Text = "DESCRIPTION";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // NamaKategori
            // 
            this.NamaKategori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamaKategori.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NamaKategori.HintForeColor = System.Drawing.Color.Empty;
            this.NamaKategori.HintText = "";
            this.NamaKategori.isPassword = false;
            this.NamaKategori.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.NamaKategori.LineIdleColor = System.Drawing.Color.White;
            this.NamaKategori.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.NamaKategori.LineThickness = 3;
            this.NamaKategori.Location = new System.Drawing.Point(214, 194);
            this.NamaKategori.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NamaKategori.Name = "NamaKategori";
            this.NamaKategori.Size = new System.Drawing.Size(190, 54);
            this.NamaKategori.TabIndex = 8;
            this.NamaKategori.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // IDKategori
            // 
            this.IDKategori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDKategori.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDKategori.HintForeColor = System.Drawing.Color.Empty;
            this.IDKategori.HintText = "";
            this.IDKategori.isPassword = false;
            this.IDKategori.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.IDKategori.LineIdleColor = System.Drawing.Color.White;
            this.IDKategori.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.IDKategori.LineThickness = 3;
            this.IDKategori.Location = new System.Drawing.Point(216, 126);
            this.IDKategori.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IDKategori.Name = "IDKategori";
            this.IDKategori.Size = new System.Drawing.Size(190, 54);
            this.IDKategori.TabIndex = 6;
            this.IDKategori.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.button4.Size = new System.Drawing.Size(368, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "MANAGE CATEGORIES";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(1377, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.CadetBlue;
            this.button2.Location = new System.Drawing.Point(16, 231);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 51);
            this.button2.TabIndex = 23;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button3.TabIndex = 24;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1413, 814);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load_2);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KategoriGDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DeskripsiKategori;
        private System.Windows.Forms.Button button7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NamaKategori;
        private System.Windows.Forms.Button button6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox IDKategori;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView KategoriGDV;
        private System.Windows.Forms.Button button3;
    }
}