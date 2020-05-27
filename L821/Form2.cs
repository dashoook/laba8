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
    public partial class Form2 : Form
    {
        List<Patients> A = new List<Patients>();
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            dataGridView1.RowCount = A.Count;
            // dataGridView1.ColumnCount = 5;
            for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                   
                   dataGridView1[0, j].Value = A[j].NAME;
                   dataGridView1[1, j].Value = A[j].Surname;
                   dataGridView1[2, j].Value = A[j].Disease;
                   dataGridView1[3, j].Value = A[j].Age;
                   dataGridView1[4, j].Value = A[j].Number;
                }
            
        }
    }

}
