using System.Diagnostics;

namespace reading_from_text_to_text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Tüm Dosyalar (*.*)|*.*|Metin dosyaları (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Tüm Dosyalar (*.*)|*.*|Metin dosyaları (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox2.Text = openFileDialog1.FileName;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int operations = 500;
            var watch = new Stopwatch();
            watch.Start();
            


            string filepath1 = textBox1.Text;
            string filepath2 = textBox2.Text;
            string[]? data = null;
            if (filepath1 != null && filepath2 != null) { 
                data = File.ReadAllLines(filepath1);
                
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;
                File.WriteAllLines(filepath2, data);
                progressBar1.BackColor = Color.Green;
                progressBar1.Value = 100;

            }

            



        }
    }
}
