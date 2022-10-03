namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")



            {



                MessageBox.Show("Nie podano wszystkich danych.");



            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Nie podano wszystkich danych.");




            }
            else
            {



                MessageBox.Show
                 ("Podane imiê: " + textBox1.Text + "  nazwisko: " + textBox2.Text + " data urodzenia: " + dateTimePicker1.Text);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}