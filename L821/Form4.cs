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
    public partial class Form4 : Form
    {
        List<Patients> A = new List<Patients>();
        public Form4()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = File.CreateText(openFileDialog1.FileName);
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

            int n = Convert.ToInt32(textBox2.Text);
            A.RemoveAt(n - 1);
            Patients.FileInformationRewrite("doctor.txt", A);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
