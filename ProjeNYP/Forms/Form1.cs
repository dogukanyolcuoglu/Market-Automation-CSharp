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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            if (rdoAdmin.Checked)
            {
                if (kullanici.userSignInQuery(txtUsername.Text, txtPassword.Text, rdoAdmin.Text) == true)
                {
                    AdminPaneli admin = new AdminPaneli();
                    this.Hide();
                    admin.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya Parolanız yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rdoManager.Checked)
            {
                if (kullanici.userSignInQuery(txtUsername.Text, txtPassword.Text, rdoManager.Text) == true)
                {
                    MudurPaneli mp = new MudurPaneli();
                    this.Hide();
                    mp.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya Parolanız yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
          this.btnSubmit.Image = ProjeNYP.Properties.Resources.enter;
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
          this.btnSubmit.Image = ProjeNYP.Properties.Resources.enter2;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.Font = new Font("Microsoft Sans Serif",10,FontStyle.Bold);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }
    }
}
