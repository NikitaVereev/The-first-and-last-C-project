using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            dataBase.openConnection();

            var ann = textBox1.Text;
            var syn = textBox2.Text;
            var tran = textBox3.Text;
            var tit = textBox4.Text;
            var or_a = textBox5.Text;
            var or_l = textBox6.Text;
            var pri = textBox7.Text;
            int price;

            var count = textBox9.Text;

            if (int.TryParse(textBox8.Text, out price))
            {
                var addQuery = $"insert into translates (annotation, synopsis, trans, title, original_author, original_language, privilege, price, count_of, id_user) values('{ann}','{syn}', '{tran}','{tit}','{or_a}', '{or_l}', '{pri}', '{price}', '{count}', '{DataStorage.UserLogin}')";
                SqlCommand command = new SqlCommand(addQuery, dataBase.getConnection());
                dataBase.openConnection();

                command.ExecuteNonQuery();
                dataBase.closeConnection();

                MessageBox.Show("Перевод успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
