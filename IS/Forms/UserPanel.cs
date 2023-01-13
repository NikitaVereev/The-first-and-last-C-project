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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    
    public partial class UserPanel : Form
    {


        DataBase dataBase = new DataBase();

        int selecedRow;

        public UserPanel(string loginUser)
        {

            InitializeComponent();
            textBox8.Text = loginUser;
            groupBox1.Visible= false;
        }





        private void CreateColums()
        {
            dataGridView2.Columns.Add("id", "id");
            dataGridView2.Columns.Add("type_of", "Тип материала");
            dataGridView2.Columns.Add("count_of", "Количество");
            dataGridView2.Columns.Add("title", "Название");
            dataGridView2.Columns.Add("content", "Текст");
            dataGridView2.Columns.Add("price", "Цена");
            dataGridView2.Columns.Add("author", "Автор");
            dataGridView2.Columns.Add("IsNew", String.Empty);

        }

        private void CreateColums2()
        {
            dataGridView3.Columns.Add("id", "id");
            dataGridView3.Columns.Add("annotation", "Аннотация");
            dataGridView3.Columns.Add("synopsis", "Синопсис");
            dataGridView3.Columns.Add("trans", "Перевод");
            dataGridView3.Columns.Add("title", "Название");
            dataGridView3.Columns.Add("original_author", "Оригинальный автор");
            dataGridView3.Columns.Add("original_language", "Оригинальный язык");
            dataGridView3.Columns.Add("privilege", "Лицензия");
            dataGridView3.Columns.Add("price", "Цена");
            dataGridView3.Columns.Add("count_of", "Количество");
            dataGridView3.Columns.Add("IsNew", String.Empty);

        }

        private void ClearFields()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void ReadTranslateSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7), record.GetInt32(8), record.GetInt32(9), RowState.ModifiedNew);
        }

        private void RefrestTranslateDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from agreed_translates where id_user = '{DataStorage.UserLogin}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadTranslateSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void RefrestDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from agreed where id_user = '{DataStorage.UserLogin}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void UserPanel_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefrestDataGrid(dataGridView2);

            CreateColums2();
            RefrestTranslateDataGrid(dataGridView3);
        }
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selecedRow];
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();
                textBox5.Text = row.Cells[3].Value.ToString();
                textBox7.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox8.Text = row.Cells[6].Value.ToString();

            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var loginUser = textBox8.Text;
            NewPost addFrm = new NewPost(loginUser);
            addFrm.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefrestDataGrid(dataGridView2);
        }

       

        

        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[7].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from posts where id_post = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());

                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var type = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var count = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var title = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    var price = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    var text = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    var author = dataGridView2.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"update posts set type_of = '{type}', count_of = '{count}', title = '{title}', price = '{price}', content = '{text}' where id = '{id}', author = '{author}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }


            }

            dataBase.closeConnection();
        }

        private void DeleteRow()
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[index].Visible = false;
            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[7].Value = RowState.Deleted;
            }

            dataGridView2.Rows[index].Cells[7].Value = RowState.Deleted;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Update();
            ClearFields();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;
            var id = textBox2.Text;
            var type = textBox3.Text;
            var count = textBox4.Text;
            var title = textBox5.Text;
            int price;
            var text = textBox7.Text;
            var author = textBox8.Text;

            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox6.Text, out price))
                {
                    dataGridView2.Rows[selectedRowIndex].SetValues(id, type, count, title, price, text, author);
                    dataGridView2.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат");
                }
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            var loginUser = textBox8.Text;
            NewTranslate addFrm = new NewTranslate(loginUser);
            addFrm.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selecedRow];
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();
                textBox5.Text = row.Cells[3].Value.ToString();
                textBox6.Text = row.Cells[4].Value.ToString();
                textBox7.Text = row.Cells[5].Value.ToString();
                textBox8.Text = row.Cells[6].Value.ToString();
                textBox11.Text = row.Cells[7].Value.ToString();
                textBox10.Text = row.Cells[8].Value.ToString();
                textBox13.Text = row.Cells[9].Value.ToString();

            }
        }

        
    }
}
