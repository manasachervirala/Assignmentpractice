using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();//reference to the button
            b.Text = "Click Button";// Text Implemented as click here
            b.Size = new Size(100, 50);//Size mentioned for the button
            b.Location = new Point(150, 150);//point located on the button created
            this.Controls.Add(b);//controlling mechasim of button should go to center.
                                 //shpw the meassg
            //b.Click += new EventHandler(button1_Click1);
            //Delagate with Anonymous Methos
            b.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("hello World");
                

            };
            //b.Click += delegate (object sender2, EventArgs e2)
            //{
            //    MessageBox.Show("programming is fun");

            //};
            b.Click += delegate (object sender3, EventArgs e3)
            {
                MessageBox.Show("This is printing");


            };
            b.Click += delegate (object sender4, EventArgs e4)
            {
                MessageBox.Show("This is printing again");


            };
            b.Click += delegate (object sender5, EventArgs e5)
            {
                MessageBox.Show("yeyyyy! This Crazy");


            };
            b.Click += delegate (object sender6, EventArgs e6)
            {
                MessageBox.Show("yeyyyy! This is super crazy");


            };


            //this.button1.Click += new System.EventHandler(this.button1+click); //Delegate been created
            //method creation
            //    private void button1_Click1(object sender1,EventArgs e1)
            //{
            //    MessageBox.Show("hello");
        }

    }
}
