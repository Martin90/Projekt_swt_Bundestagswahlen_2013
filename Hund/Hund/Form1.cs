using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hund
{
    public partial class Form1 : Form
    {
        
        HundMitAnzeigen windhund;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            windhund.Loeschen();
            }

        private void buttonZeigen_Click(object sender, EventArgs e)
        {
            windhund.Anzeigen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            windhund = new HundMitAnzeigen("Fix", "Windhund", @"..\..\..\hund1.png");
            windhund.Init(textBoxName,textBoxTyp,pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
