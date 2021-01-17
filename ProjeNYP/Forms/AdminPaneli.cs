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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void AdminPaneli_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void AdminPaneli_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void AdminPaneli_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            UrunIslemi u = new UrunIslemi();
            this.Hide();
            u.ShowDialog();
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Calisanlar c = new Calisanlar();
            this.Hide();
            c.ShowDialog();
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            Tedarikci t = new Tedarikci();
            this.Hide();
            t.ShowDialog();
        }

        private void linkLblDogukan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tr.linkedin.com/in/do%C4%9Fukan-yolcuo%C4%9Flu-3510701a4");
        }

        private void linkLblEnder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tr.linkedin.com/in/ender-g%C3%BClger-3abb36173");
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            Market m = new Market();
            this.Hide();
            m.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dogukanyolcuoglu");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/endergulger"); 
        }
    }
}
