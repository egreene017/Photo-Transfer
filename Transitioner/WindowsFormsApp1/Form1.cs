using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            //Get the values for the picture name
            Transitioner t = new Transitioner();
            t.setDirectory(txtDirectory.Text);
            t.setDate(yy.Text + "-" + mm.Text + "-" + dd.Text);
            t.setName(txtName.Text);

            //Run the process
            String changeCount = t.transition();

            //Message the user how many changes were made
            MessageBox.Show("There were " + changeCount + " changes made");

        }
        
    }
}
