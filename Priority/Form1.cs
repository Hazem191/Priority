using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priority
{
    public partial class Form1 : Form
    {
        ArrayList array = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            array.Add(Convert.ToInt32(p1.Text));
            array.Add(Convert.ToInt32(p2.Text));
            array.Add(Convert.ToInt32(p3.Text));
            array.Add(Convert.ToInt32(p4.Text));
            array.Sort();
            foreach (var item in array)
            {
                checkedListBox1.Items.Add(item);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkedListBox1.Items[0].ToString() == p1.Text)
            {
                timer1.Interval = Convert.ToInt32(txtp1.Text + "000");
                textBox5.Text = label1.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == p2.Text)
            {
                timer1.Interval = Convert.ToInt32(txtp2.Text + "000");
                textBox5.Text = label2.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == p3.Text)
            {
                timer1.Interval = Convert.ToInt32(txtp3.Text + "000");
                textBox5.Text = label3.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == p4.Text)
            {
                timer1.Interval = Convert.ToInt32(txtp4.Text + "000");
                textBox5.Text = label4.Text;
            }
            checkedListBox1.Items.RemoveAt(0);

            if (checkedListBox1.Items.Count <= 0)
            {
                MessageBox.Show("Processor is Idel and Wait the processes !!");
                timer1.Stop();

            }
        }
    }
}
