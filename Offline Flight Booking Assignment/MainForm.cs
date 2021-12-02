using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Offline_Flight_Booking_Assignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                /*
                System.IO.TextWriter txt = new System.IO.StreamWriter("C:\\Users\\USER.txt");
                txt.Write(textBox1.Text);
                txt.Close();*/



                StreamWriter A = new StreamWriter(Application.StartupPath + "\\forms\\" + "flight.txt");

                A.WriteLine(textBox1);
                A.WriteLine("Passenger ID:" + textBox2.Text);
                A.WriteLine(groupBox4.Text);
                A.WriteLine("Date of Flight:" + dateTimePicker1.Text);
                A.WriteLine("From:" + comboBox4.Text);
                A.WriteLine("To:" + comboBox3.Text);
                A.WriteLine("Flight:" + comboBox1.Text);
                A.WriteLine(groupBox2.Text);
                A.WriteLine(groupBox3.Text);
                A.WriteLine(groupBox1.Text);

                A.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            About f = new About();
            f.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            /*string text;
            var fileStream = new FileStream(@"C:\Users\USER\source\repos\Offline Flight Booking Assignment\Offline Flight Booking Assignment\bin\Debug\forms\flight.text", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }*/
            }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            string text;
            var fileStream = new FileStream(@"C:\Users\USER\source\repos\Offline Flight Booking Assignment\Offline Flight Booking Assignment\bin\Debug\forms\flight.text", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }
        }
    }
    }

