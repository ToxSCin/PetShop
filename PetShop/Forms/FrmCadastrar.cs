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
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();

            // Configurar botão e caixas de texto
            ConfigureControls();
        }
        private void FrmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void ConfigureControls()
        {
            // Configurar o botão
            ConfigureButton(BtnEntrar);

            // Configurar as caixas de texto
            ConfigureRoundedTextBox(TxtUsuario);
            ConfigureRoundedTextBox(TxtSenha);
            ConfigureRoundedTextBox(TxtConfirmarSenha);
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

        private void ConfigureRoundedTextBox(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = Color.FromArgb(240, 240, 240);
            textBox.ForeColor = Color.Black;
            textBox.Multiline = true;
            textBox.TextAlign = HorizontalAlignment.Left;
            textBox.Padding = new Padding(10);
            textBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox.Width, textBox.Height, 20, 20));
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

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();
            this.Hide();
            FrmCadastrar frmCadastrar = new FrmCadastrar();
            frmCadastrar.Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                /** Verifica se os campos estão preenchidos */
                if (TxtUsuario.Text == "" || TxtSenha.Text == "")
                {
                    MessageBox.Show("Preencha os campos", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro!", MessageBoxButtons.OK);
            }
        }

        
    }
}
