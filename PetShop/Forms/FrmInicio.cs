using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Forms
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();

            // Configuração para o button1
            ConfigureButton(BtnFazerLogin);

            // Configuração para o button2
            ConfigureButton(BtnMeCadastrar);
        }

        private void ConfigureButton(Button button)
        {
            // "CSS" dos botão
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(163, 220, 227);
            button.ForeColor = Color.Black;
            button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void BtnFazerLogin_Click(object sender, EventArgs e)
        {
            // Feche o Form1
            this.Hide();
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Close();

            FrmLogin frmLogin = new FrmLogin();

            // Exiba o Form2
            frmLogin.Show();
        }

        private void BtnMeCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar frmCadastrar = new FrmCadastrar();
            frmCadastrar.Show();


            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Close();
        }

        private void LblFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
