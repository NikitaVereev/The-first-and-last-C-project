using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::System;
 using global::System.Collections.Generic;
 using global::System.Drawing;
 using global::System.IO;
 using global::System.Linq;
 using global::System.Net.Http;
 using global::System.Threading;
 using global::System.Threading.Tasks;
 using global::System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS.Forms
{
    public partial class NewTranslate : Form
    {
        DataBase dataBase = new DataBase();


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public NewTranslate(string loginUser)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox6.Text = loginUser;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var getPrice = textBox8.Text;
            var count = textBox9.Text;

            var ann = textBox1.Text;
            var syn = textBox2.Text;
            var tran = textBox3.Text;
            var tit = textBox4.Text;
            var or_a = textBox5.Text;
            var or_l = textBox6.Text;
            var pri = textBox7.Text;

            CardTranslate addFrm = new CardTranslate(getPrice, ann, syn, tran, tit, or_a, or_l, pri, count);
            addFrm.Show();


           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var countText = textBox9.Text;
            



            var countTextInt = int.Parse(countText);
            

            int CaltPrice = (countTextInt * 129);
            textBox8.Text = CaltPrice.ToString();
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
