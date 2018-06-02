using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cawsworkapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getdata_Click(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray;

                string[] stringArray1;

                label4.Text = "";



                stringArray = textBox1.Text.Split(' ');

                stringArray1 = textBox2.Text.Split('|');

                for(int i= stringArray.Length-1; i >= 0;i-- ) {

                    label4.Text = label4.Text = label4.Text + stringArray[i] + ",";
                }

                foreach (string addr in stringArray1)
                {

                    label4.Text = label4.Text + addr+ ",";
                }

                label4.Text = label4.Text.Remove(label4.Text.Length-1);

                 
            }
            catch(Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
