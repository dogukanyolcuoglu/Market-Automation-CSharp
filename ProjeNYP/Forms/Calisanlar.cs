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
    public partial class Calisanlar : Form
    {
        public Calisanlar()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            UrunIslemi ui = new UrunIslemi();
            this.Hide();
            ui.ShowDialog();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            AdminPaneli ap = new AdminPaneli();
            this.Hide();
            ap.ShowDialog();
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {
            Clear();
            cmbPlace.DropDownHeight = cmbPlace.ItemHeight * 8;
        }

        private void Calisanlar_Shown(object sender, EventArgs e)
        {
            txtName.Focus();
        }


        public void Clear() {

            txtName.Text = "";
            txtAdress.Text = "";
            txtSalary.Text = "";
            cmbPosition.Text = "";
            cmbPlace.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPosition.SelectedIndex == -1 || txtName.Text == "" || txtAdress.Text == "" || txtSalary.Text == "" || cmbPlace.SelectedIndex == -1) {
                MessageBox.Show("Boş alanları doldurunuz lütfen", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else {

                int change = int.Parse(cmbPlace.SelectedItem.ToString());
                Calisan c = new Calisan();
                c.saveEmployee(txtName.Text, txtAdress.Text,txtSalary.Text,change, cmbPosition.SelectedItem.ToString());
                Clear();
            }

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

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.White;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = Color.Black;
        }

        private void btnPage1_MouseEnter(object sender, EventArgs e)
        {
            this.btnPage1.Font = new Font("BankGothic Md BT", 15, FontStyle.Bold);
            this.btnPage1.TextAlign = ContentAlignment.TopCenter;
        }

        private void btnPage1_MouseLeave(object sender, EventArgs e)
        {
            this.btnPage1.Font = new Font("BankGothic Md BT", 13, FontStyle.Bold);
            this.btnPage1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnPage2_MouseEnter(object sender, EventArgs e)
        {
            this.btnPage2.Font = new Font("BankGothic Md BT", 15, FontStyle.Bold);
            this.btnPage2.TextAlign = ContentAlignment.TopCenter;
        }

        private void btnPage2_MouseLeave(object sender, EventArgs e)
        {
            this.btnPage2.Font = new Font("BankGothic Md BT", 13, FontStyle.Bold);
            this.btnPage2.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {
            Calisanlar2 c2 = new Calisanlar2();
            this.Hide();
            c2.ShowDialog();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Calisanlar_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Calisanlar_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Calisanlar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move) {

                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
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
