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
    public partial class MudurPaneli : Form
    {
        Mudur m = new Mudur();
        public MudurPaneli()
        {
            InitializeComponent();
        }

        private void MudurPaneli_Load(object sender, EventArgs e)
        {
            m.getData(dgvMudur);
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void MudurPaneli_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void MudurPaneli_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void MudurPaneli_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            m.readPrice(txtId,txtSale,dgvMudur);
            txtId.Text = "";
            txtSale.Text = "";
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
    }
}
