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
    public partial class Calisanlar2 : Form
    {
        Calisan c = new Calisan();
        public Calisanlar2()
        {
            InitializeComponent();
        }

        private void btnPage1_Click(object sender, EventArgs e)
        {
            Calisanlar c2 = new Calisanlar();
            this.Hide();
            c2.ShowDialog();
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

        private void btnStock_Click(object sender, EventArgs e)
        {
            UrunIslemi ui = new UrunIslemi();
            this.Hide();
            ui.ShowDialog();
        }

        private void Calisanlar2_Shown(object sender, EventArgs e)
        {
            txtId.Focus();
        }

        private void Calisanlar2_Load(object sender, EventArgs e)
        {
            Clear();
            cmbPlace.DropDownHeight = cmbPlace.ItemHeight * 8;
            cmbCategory.SelectedIndex = 0;
            c.getData(dgvEmployee,"Hepsi");
        }

        public void Clear()
        {
            txtSearch.Text = "";
            txtDay.Text = "";
            txtId.Text = "";
            txtSalary.Text = "";
            cmbPlace.Text = "";
            cmbPosition.Text = "";
            cmbCategory.Text = "";
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Calisanlar2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Calisanlar2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Calisanlar2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            c.search(dgvEmployee,txtSearch.Text);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if(cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Bir kategori seçiniz.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                c.getData(dgvEmployee, cmbCategory.SelectedItem.ToString());
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Query();
        }

        public void Query()
        {
            if (txtSalary.Text != "" && cmbPlace.SelectedIndex != -1 && cmbPosition.SelectedIndex != -1)
            {
                c.updateEmployee(txtId.Text, txtSalary.Text, int.Parse(cmbPlace.SelectedItem.ToString()), cmbPosition.SelectedItem.ToString(), dgvEmployee, cmbCategory.SelectedItem.ToString());
            }
            if (txtSalary.Text != "" && cmbPlace.SelectedIndex == -1 && cmbPosition.SelectedIndex == -1)
            {
                c.updateEmployee(txtId.Text, txtSalary.Text, -1, "", dgvEmployee, cmbCategory.SelectedItem.ToString());
            }
            if (txtSalary.Text == "" && cmbPlace.SelectedIndex != -1 && cmbPosition.SelectedIndex == -1)
            {
                c.updateEmployee(txtId.Text, "", int.Parse(cmbPlace.SelectedItem.ToString()), "", dgvEmployee, cmbCategory.SelectedItem.ToString());
            }
            if (txtSalary.Text == "" && cmbPlace.SelectedIndex == -1 && cmbPosition.SelectedIndex != -1)
            {
                c.updateEmployee(txtId.Text, "", -1, cmbPosition.SelectedItem.ToString(), dgvEmployee, cmbCategory.SelectedItem.ToString());
            }
            if (txtSalary.Text != "" && cmbPlace.SelectedIndex != -1 && cmbPosition.SelectedIndex == -1)
            {
                c.updateEmployee(txtId.Text, txtSalary.Text, int.Parse(cmbPlace.SelectedItem.ToString()), "", dgvEmployee,cmbCategory.SelectedItem.ToString());
            }
            if (txtSalary.Text != "" && cmbPlace.SelectedIndex == -1 && cmbPosition.SelectedIndex != -1)
            {
                c.updateEmployee(txtId.Text, txtSalary.Text, -1, cmbPosition.SelectedItem.ToString(), dgvEmployee, cmbCategory.SelectedItem.ToString());
            }
            if (txtSalary.Text == "" && cmbPlace.SelectedIndex != -1 && cmbPosition.SelectedIndex != -1)
            {
                c.updateEmployee(txtId.Text, "", int.Parse(cmbPlace.SelectedItem.ToString()), cmbPosition.SelectedItem.ToString(), dgvEmployee, cmbCategory.SelectedItem.ToString());
            }
            if (txtSalary.Text == "" && cmbPlace.SelectedIndex == -1 && cmbPosition.SelectedIndex == -1)
            {
                c.updateEmployee(txtId.Text, "", -1, "", dgvEmployee, cmbCategory.SelectedItem.ToString());
            }
        }
        private void btnDay_Click(object sender, EventArgs e)
        {
            c.permissionDay(txtId.Text, int.Parse(txtDay.Text),dgvEmployee,cmbCategory.SelectedItem.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
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
