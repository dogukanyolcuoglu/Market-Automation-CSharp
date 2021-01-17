namespace ProjeNYP
{
    partial class Calisanlar
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnTrade = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(1356, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnMarket);
            this.panel1.Controls.Add(this.btnTrade);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Location = new System.Drawing.Point(56, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 804);
            this.panel1.TabIndex = 3;
            // 
            // btnMarket
            // 
            this.btnMarket.BackColor = System.Drawing.Color.White;
            this.btnMarket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarket.FlatAppearance.BorderSize = 0;
            this.btnMarket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMarket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarket.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarket.Image = global::ProjeNYP.Properties.Resources.market;
            this.btnMarket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarket.Location = new System.Drawing.Point(15, 471);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(217, 91);
            this.btnMarket.TabIndex = 5;
            this.btnMarket.Text = "Marketlerim";
            this.btnMarket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarket.UseVisualStyleBackColor = false;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnTrade
            // 
            this.btnTrade.BackColor = System.Drawing.Color.White;
            this.btnTrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrade.FlatAppearance.BorderSize = 0;
            this.btnTrade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrade.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrade.Image = global::ProjeNYP.Properties.Resources.business;
            this.btnTrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrade.Location = new System.Drawing.Point(15, 320);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(217, 91);
            this.btnTrade.TabIndex = 4;
            this.btnTrade.Text = "Tedarikçiler";
            this.btnTrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrade.UseVisualStyleBackColor = false;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Image = global::ProjeNYP.Properties.Resources.stock;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(15, 173);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(217, 91);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Ürün İşlemi";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cmbPosition);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.lblSalary);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.lblPlace);
            this.groupBox1.Controls.Add(this.cmbPlace);
            this.groupBox1.Controls.Add(this.lblAdress);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(355, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 668);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Çalışan Kaydı";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(218, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kayıt";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // cmbPosition
            // 
            this.cmbPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPosition.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Kasiyer",
            "Müdür Yardımcısı",
            "Müdür"});
            this.cmbPosition.Location = new System.Drawing.Point(218, 487);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(193, 28);
            this.cmbPosition.TabIndex = 4;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(109, 490);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(59, 23);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "Mevki:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(109, 431);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(56, 23);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Maaş:";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(218, 432);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(193, 28);
            this.txtSalary.TabIndex = 3;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(108, 169);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(74, 23);
            this.lblPlace.TabIndex = 5;
            this.lblPlace.Text = "Şube ID:";
            // 
            // cmbPlace
            // 
            this.cmbPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPlace.DropDownWidth = 50;
            this.cmbPlace.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbPlace.Location = new System.Drawing.Point(218, 166);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(133, 28);
            this.cmbPlace.TabIndex = 1;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(109, 245);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(96, 23);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Açık Adres:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(109, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ad Soyad:";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(218, 245);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(491, 146);
            this.txtAdress.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(218, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 28);
            this.txtName.TabIndex = 0;
            // 
            // btnPage1
            // 
            this.btnPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPage1.FlatAppearance.BorderSize = 0;
            this.btnPage1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPage1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage1.Font = new System.Drawing.Font("BankGothic Md BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPage1.ForeColor = System.Drawing.Color.Red;
            this.btnPage1.Location = new System.Drawing.Point(758, 730);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(38, 41);
            this.btnPage1.TabIndex = 8;
            this.btnPage1.Text = "1";
            this.btnPage1.UseVisualStyleBackColor = true;
            this.btnPage1.MouseEnter += new System.EventHandler(this.btnPage1_MouseEnter);
            this.btnPage1.MouseLeave += new System.EventHandler(this.btnPage1_MouseLeave);
            // 
            // btnPage2
            // 
            this.btnPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPage2.FlatAppearance.BorderSize = 0;
            this.btnPage2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPage2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage2.Font = new System.Drawing.Font("BankGothic Md BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPage2.Location = new System.Drawing.Point(802, 730);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(38, 41);
            this.btnPage2.TabIndex = 9;
            this.btnPage2.Text = "2";
            this.btnPage2.UseVisualStyleBackColor = true;
            this.btnPage2.Click += new System.EventHandler(this.btnPage2_Click);
            this.btnPage2.MouseEnter += new System.EventHandler(this.btnPage2_MouseEnter);
            this.btnPage2.MouseLeave += new System.EventHandler(this.btnPage2_MouseLeave);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Image = global::ProjeNYP.Properties.Resources.back_arrow;
            this.btnHomePage.Location = new System.Drawing.Point(1292, 12);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(58, 45);
            this.btnHomePage.TabIndex = 6;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            this.btnHomePage.MouseEnter += new System.EventHandler(this.btnHomePage_MouseEnter);
            this.btnHomePage.MouseLeave += new System.EventHandler(this.btnHomePage_MouseLeave);
            // 
            // Calisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1423, 800);
            this.Controls.Add(this.btnPage2);
            this.Controls.Add(this.btnPage1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calisanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calisanlar";
            this.Load += new System.EventHandler(this.Calisanlar_Load);
            this.Shown += new System.EventHandler(this.Calisanlar_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calisanlar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Calisanlar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Calisanlar_MouseUp);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.ComboBox cmbPlace;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Button btnSave;
    }
}