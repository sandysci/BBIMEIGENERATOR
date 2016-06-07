using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bbmgenaratorapp
{
    public partial class Formbb : Form
    {
        bb mybbclas = new bb();
        public Formbb()
        {
            InitializeComponent();
        }

        private void Formbb_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         HashSet<int> bbhash =    mybbclas.bbhold();
         foreach (var k in bbhash) {
             viewbbgen.Text="358650"+ k.ToString() ;         
         }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
