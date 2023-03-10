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
using static System.Net.Mime.MediaTypeNames;

namespace IS.Forms
{
    public partial class Card : Form
    {


        DataBase dataBase = new DataBase();
        int selecedRow;

        public Card(string getPrice, string type, string count, string title, string text, string author )
        {
            InitializeComponent();
            textBox4.Text = getPrice;
            textBox5.Text = type;
            textBox6.Text = count;
            textBox7.Text = title;
            textBox8.Text = text;
            textBox9.Text = author;
        }
        private void CreateColums()
        {
            dataGridView1.Columns.Add("card_id", "id");
            dataGridView1.Columns.Add("card_number", "Номер карты");
            dataGridView1.Columns.Add("cart_date", "Дата");
            dataGridView1.Columns.Add("card_cvv", "CVV");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefrestDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from user_card where id_user = '{DataStorage.UserLogin}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Card_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefrestDataGrid(dataGridView1);
        }
        

        private void ClearFields()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var type = textBox5.Text;
            var count = textBox6.Text;
            var title = textBox7.Text;
            var text = textBox8.Text;
            var author = textBox9.Text;

            int price;

            if (int.TryParse(textBox4.Text, out price))
            {
                var addQuery = $"insert into posts (type_of, count_of, title, content, price, author, id_user) values('{type}', '{count}', '{title}', '{text}', '{price}', '{author}', '{DataStorage.UserLogin}')";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selecedRow];
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
      

            }
        }

        
    }
}
