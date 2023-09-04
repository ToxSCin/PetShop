using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Configurar botão e caixas de texto
            ConfigureControls();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void ConfigureControls()
        {
            // Configurar o botão
            ConfigureButton(button1);

            // Configurar as caixas de texto
            ConfigureRoundedTextBox(textBox1);
            ConfigureRoundedTextBox(textBox2);
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

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblVoltar2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            Form2 form2 = new Form2();
            form2.Close();

            
        }
    }
}
