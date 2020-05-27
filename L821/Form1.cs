using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L821
{
    public partial class Form1 : Form
    {
        Form2 a;
        Form3 b;
        Form4 c;
        Form5 d;
        List<Patients> A = new List<Patients>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = new Form3();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = new Form2();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = new Form4();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d = new Form5();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = new Form2();
            a.Show();
        }
    }

    class Patients
    {
        public string NAME;
        public string Surname;
        public string Disease;
        public int Age;
        public int Number;

        public Patients() { }
        public Patients(string name, string surname, string disease, int age, int number)
        {
            NAME = name;
            Surname = surname;
            Disease = disease;
            Age = age;
            Number = number;
        }

        public override string ToString()
        {
            return this.NAME + " " + this.Surname + " " + this.Disease + " " + this.Age + " " + this.Number;
        }
        static public void FileInformationRewrite(string path, List<Patients> users)
        {
            File.WriteAllText(path, String.Empty);
            using (StreamWriter s = new StreamWriter(path))
            {
                foreach (Patients informationUnit in users)
                {
                    s.WriteLine(informationUnit.ToString());
                }
            }
        }

    }

}   
    
