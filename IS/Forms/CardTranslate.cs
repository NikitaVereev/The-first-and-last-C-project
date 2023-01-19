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
    public partial class CardTranslate : Form
    {

        
        DataBase dataBase = new DataBase();
        int selecedRow;

        public CardTranslate(string getPrice, string ann,string syn, string tran,string tit,string or_a,string or_l,string pri, string count)
        {
            InitializeComponent();
            textBox4.Text = getPrice;
            textBox5.Text = ann;
            textBox6.Text = syn;
            textBox7.Text = tran;
            textBox8.Text = tit;
            textBox9.Text = or_a;
            textBox10.Text = or_l;
            textBox11.Text = pri;
            textBox12.Text = count;
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

        private void CardTranslate_Load(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var ann = textBox5.Text;
            var syn = textBox6.Text;
            var tran = textBox7.Text;
            var tit = textBox8.Text;
            var or_a = textBox9.Text;
            var or_l = textBox10.Text;
            var pri = textBox11.Text;
            int price;

            var count = textBox12.Text;

            if (int.TryParse(textBox4.Text, out price))
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
