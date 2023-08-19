namespace Practica2_POE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Despues del evento";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Antes de el eventos";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            panel1.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }


        private string[] imagenes = { "flor.jpg", "gemas.jpg" 
        };
        private int indice = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (indice < imagenes.Length - 1)
            {
               indice++;
            }
            pictureBox1.ImageLocation = imagenes[indice];
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (indice > 0)
            {
                indice--;
            }
            pictureBox1.ImageLocation = imagenes[indice];
            
            
        }


    }
}