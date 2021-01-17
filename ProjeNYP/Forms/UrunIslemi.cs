using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjeNYP
{
    public partial class UrunIslemi : Form
    {
        Urunler u = new Urunler();
        public UrunIslemi()
        {
            
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           u.getData(dgvProduct,comboBox1.SelectedItem.ToString());
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            AdminPaneli ap = new AdminPaneli();
            this.Hide();
            ap.ShowDialog();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            u.readPrice(txtId, txtSale, dgvProduct, comboBox1.SelectedItem.ToString());
            Clear();
        }

        private void UrunIslemi_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            u.getData(dgvProduct, "Tüm Ürünler");
        }
        public void Clear() {
            txtId.Text = "";
            txtSale.Text = "";
            txtSearch.Text = "";
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void UrunIslemi_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void UrunIslemi_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void UrunIslemi_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }

        }

        private void btnHomePage_MouseEnter(object sender, EventArgs e)
        {
            this.btnHomePage.Image = ProjeNYP.Properties.Resources.back_arrow2;
        }

        private void btnHomePage_MouseLeave(object sender, EventArgs e)
        {
            this.btnHomePage.Image = ProjeNYP.Properties.Resources.back_arrow;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            u.search(dgvProduct, txtSearch);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Calisanlar c = new Calisanlar();
            this.Hide();
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.readStock(txtId2, txtStock, dgvProduct, comboBox1.SelectedItem.ToString());
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            Tedarikci t = new Tedarikci();
            this.Hide();
            t.ShowDialog();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            Market m = new Market();
            this.Hide();
            m.ShowDialog();
        }
    }
}
