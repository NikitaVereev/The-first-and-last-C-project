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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS.Forms
{
    public partial class NewPost : Form
    {
        DataBase dataBase = new DataBase();


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public NewPost(string loginUser)
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
            textBox6.Text = DataStorage.UserName;

            

            

        }

        
            
        
       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            var getPrice = textBox4.Text;
            var type = textBox1.Text;
            var count = textBox2.Text;
            var title = textBox3.Text;
            var text = textBox5.Text;
            var author = textBox6.Text;

            Card addFrm = new Card(getPrice, type, count, title, text, author);
            addFrm.Show();
            
            
            
           
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox2.Enabled= false;
        }
           
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            var countText = textBox2.Text;
            var strText = textBox1.Text;



            var countTextInt = int.Parse(countText);
            var strTextInt = int.Parse(strText);

            int CaltPrice = (countTextInt * 129) + (strTextInt * 499);
            textBox4.Text = CaltPrice.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPost_Load(object sender, EventArgs e)
        {

        }
    }
}
