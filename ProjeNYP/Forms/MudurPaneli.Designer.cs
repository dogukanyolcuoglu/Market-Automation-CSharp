namespace ProjeNYP
{
    partial class MudurPaneli
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
            this.dgvMudur = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSale = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblMudur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMudur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMudur
            // 
            this.dgvMudur.AllowUserToAddRows = false;
            this.dgvMudur.AllowUserToDeleteRows = false;
            this.dgvMudur.BackgroundColor = System.Drawing.Color.White;
            this.dgvMudur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMudur.GridColor = System.Drawing.Color.White;
            this.dgvMudur.Location = new System.Drawing.Point(82, 253);
            this.dgvMudur.Name = "dgvMudur";
            this.dgvMudur.ReadOnly = true;
            this.dgvMudur.RowHeadersWidth = 51;
            this.dgvMudur.RowTemplate.Height = 24;
            this.dgvMudur.Size = new System.Drawing.Size(942, 388);
            this.dgvMudur.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(1036, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.Teal;
            this.lblSale.Location = new System.Drawing.Point(153, 142);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(93, 23);
            this.lblSale.TabIndex = 12;
            this.lblSale.Text = "İndirim %:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(261, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(168, 24);
            this.txtId.TabIndex = 13;
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunID.ForeColor = System.Drawing.Color.Teal;
            this.lblUrunID.Location = new System.Drawing.Point(153, 94);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(80, 23);
            this.lblUrunID.TabIndex = 11;
            this.lblUrunID.Text = "Ürün ID:";
            // 
            // txtSale
            // 
            this.txtSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSale.Location = new System.Drawing.Point(261, 144);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(168, 24);
            this.txtSale.TabIndex = 14;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(278, 188);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(137, 31);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "İndirim uygula";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblMudur
            // 
            this.lblMudur.AutoSize = true;
            this.lblMudur.Font = new System.Drawing.Font("Arial Unicode MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMudur.Location = new System.Drawing.Point(77, 21);
            this.lblMudur.Name = "lblMudur";
            this.lblMudur.Size = new System.Drawing.Size(302, 30);
            this.lblMudur.TabIndex = 16;
            this.lblMudur.Text = "Müdür indirim uygulama paneli";
            // 
            // MudurPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1105, 686);
            this.Controls.Add(this.lblMudur);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.txtSale);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvMudur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MudurPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MudurPaneli";
            this.Load += new System.EventHandler(this.MudurPaneli_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MudurPaneli_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MudurPaneli_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MudurPaneli_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMudur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMudur;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblMudur;
    }
}