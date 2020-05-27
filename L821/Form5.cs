using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L821
{
    public partial class Form5 : Form
    {
        List<Patients> A = new List<Patients>();
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader s = new StreamReader("doctor.txt"))
            {
                string str;
                string[] a;
                while (s.EndOfStream == false)
                {
                    str = s.ReadLine();
                    if (str != "" && str != " ")
                    {
                        a = str.Split();
                        A.Add(new Patients(a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4])));
                    }
                }
            }

            int n = Convert.ToInt32(textBox6.Text);
            Patients A1 = new Patients();
            string name = textBox1.Text;
            A1.NAME = name;
            string sur = textBox2.Text;
            A1.Surname = sur;
            string dis = textBox3.Text;
            A1.Disease = dis;
            int age = Convert.ToInt32(textBox4.Text);
            A1.Age = age;
            int num = Convert.ToInt32(textBox5.Text);
            A1.Number = num;
            A.RemoveAt(n - 1);
            A.Insert(n - 1, A1);
            Patients.FileInformationRewrite("doctor.txt", A);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
