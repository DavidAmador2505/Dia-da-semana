namespace Dia_da_semana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);
            string diadasemanas = "";

            switch(numero)
            {
                case 1:
                    diadasemanas = "Domingo";
                    MessageBox.Show("Hoje é" + diadasemanas);
                    break;

                case 2:
                    diadasemanas = "Segunda";
                    MessageBox.Show("Hoje é" + diadasemanas);
                    break;

                case 3:
                    diadasemanas = "Terça";
                    MessageBox.Show("Hoje é" + diadasemanas);
                    break;

                case 4:
                    diadasemanas = "Quarta";
                    MessageBox.Show("Hoje é" + diadasemanas);
                    break;

                case 5:
                    diadasemanas = "Quinta";
                    MessageBox.Show("Hoje é" + diadasemanas);
                    break;

                case 6:
                    diadasemanas = "Sexta";
                    MessageBox.Show("Hoje é" + diadasemanas);
                    break;

                case 7:
                    diadasemanas = "Sábado";
                    MessageBox.Show("Hoje é" + diadasemanas);
                    break;

                default:
                    MessageBox.Show("Número inserido inválido!");
                    break;

            }
        }
    }
}