using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS.Forms
{
    public partial class Card : Form
    {
        

        
        public Card(string getPrice)
        {
            InitializeComponent();
            textBox4.Text = getPrice;
        }

        private void Card_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cardNumber = textBox1.Text;
            var cardDate = textBox2.Text;
            var cardCVV = textBox3.Text;
        }
    }
}
