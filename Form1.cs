using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculation
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listname.Items.Add(textname.Text);
            listsurname.Items.Add(textsurname.Text);
            list1.Items.Add(text1.Text);
            list2.Items.Add(text2.Text);

            double avg = (Convert.ToDouble(text1.Text) + Convert.ToDouble(text2.Text)) / 2; // we calculate the average 

            listavg.Items.Add(avg);
             
            if(avg>= 50)
            {
                listresult.Items.Add("Passed");
            }
            else
            {
                listresult.Items.Add("Failed");
            }

            textname.Text = null;
            textsurname.Clear(); // diğer kullanım şekli temizlemek için. Ya da null değeri ata farketmez.
            text1.Text = null;
            text2.Text = null;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listname.Items.Clear();
            listsurname.Items.Clear();
            list1.Items.Clear();
            list2.Items.Clear();
            listavg.Items.Clear();
            listresult.Items.Clear();
        }
    }
}
