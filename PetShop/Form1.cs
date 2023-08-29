using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configuração para o button1
            ConfigureButton(button1);

            // Configuração para o button2
            ConfigureButton(button2);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Exiba o Form2
            form2.Show();

            // Feche o Form1
            this.Hide();
            Form1 form1 = new Form1();
            form1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();


            this.Hide();
            Form2 form2 = new Form2();
            form2.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();


            this.Hide();
            Form2 form2 = new Form2();
            form2.Close();

        }
    }
}
