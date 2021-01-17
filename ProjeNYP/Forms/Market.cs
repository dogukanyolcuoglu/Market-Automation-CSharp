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
    public partial class Market : Form
    {
        Marketlerim m = new Marketlerim();
        public Market()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            UrunIslemi ui = new UrunIslemi();
            this.Hide();
            ui.ShowDialog();
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            Tedarikci t = new Tedarikci();
            this.Hide();
            t.ShowDialog();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            Calisanlar c = new Calisanlar();
            this.Hide();
            c.ShowDialog();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            AdminPaneli ap = new AdminPaneli();
            this.Hide();
            ap.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Market_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            m.getData(dgvMarket);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            m.search(dgvMarket,txtSearch);
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Market_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Market_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Market_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
