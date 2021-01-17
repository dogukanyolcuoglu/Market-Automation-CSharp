using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeNYP
{
    public partial class Tedarikci : Form
    {
        Tedarikcilerim t = new Tedarikcilerim();
        public Tedarikci()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(t.readStock(txtId.Text) < int.Parse(txtStock.Text))
            {
                MessageBox.Show("Maalesef tedarikçinin elinde istediğiniz miktar bulunmamaktadır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else
            {
                MessageBox.Show("Ürün satın alındı. Ürünler kısmından kontrol edebilirsiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.addProduct(txtId.Text, int.Parse(txtStock.Text),int.Parse(cmbPlaceId.SelectedItem.ToString()));
                t.updateStock(t.readStock(txtId.Text),int.Parse(txtStock.Text), txtId.Text);
                t.getData(dgvBuyProduct,cmbList.SelectedItem.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            t.search(dgvBuyProduct, txtSearch);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            t.getData(dgvBuyProduct,cmbList.SelectedItem.ToString());
        }

        private void Tedarikci_Load(object sender, EventArgs e)
        {
            cmbList.SelectedIndex = 0;
            t.getData(dgvBuyProduct, "Tüm Ürünler");
        }
        public void Clear()
        {
            txtId.Text = "";
            txtSearch.Text = "";
            txtStock.Text = "";
            cmbList.Text = "";
            cmbPlaceId.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            UrunIslemi u = new UrunIslemi();
            this.Hide();
            u.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Calisanlar c = new Calisanlar();
            this.Hide();
            c.ShowDialog();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Tedarikci_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Tedarikci_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Tedarikci_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
        }

        private void btnHomePage_MouseEnter(object sender, EventArgs e)
        {
            this.btnHomePage.Image = ProjeNYP.Properties.Resources.back_arrow2;
        }

        private void btnHomePage_MouseLeave(object sender, EventArgs e)
        {
            this.btnHomePage.Image = ProjeNYP.Properties.Resources.back_arrow;
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            AdminPaneli ap = new AdminPaneli();
            this.Hide();
            ap.ShowDialog();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            Market m = new Market();
            this.Hide();
            m.ShowDialog();
        }
    }
}
