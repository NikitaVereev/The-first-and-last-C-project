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
using Microsoft.Data.SqlClient;
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
            textBox6.Text = loginUser;
        }
       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var type = textBox1.Text;
            var count = textBox2.Text;
            var title = textBox3.Text;
            var text = textBox5.Text;
            var author = textBox6.Text;
        
            int price;

            if(int.TryParse(textBox4.Text, out price) )
            {
                var addQuery = $"insert into posts (type_of, count_of, title, content, price, author, id_user) values('{type}', '{count}', '{title}', '{text}', '{price}', '{author}', '{DataStorage.UserLogin}')" ;
                SqlCommand command = new SqlCommand(addQuery, dataBase.getConnection());
                dataBase.openConnection();

                command.ExecuteNonQuery();
                dataBase.closeConnection();

                MessageBox.Show("Публикация успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Где-то произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
