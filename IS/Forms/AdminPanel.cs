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
    public partial class AdminPanel : Form
    {
        

        DataBase dataBase = new DataBase();

        int selecedRow;
        
        public AdminPanel(string loginUser)
        {
           
            InitializeComponent();
            textBox9.Text = loginUser;
        }

        

        

        private void CreateColums()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("type_of", "Тип материала");
            dataGridView1.Columns.Add("count_of", "Количество");
            dataGridView1.Columns.Add("title", "Название");
            dataGridView1.Columns.Add("content", "Текст");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("author", "Автор");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            
        }
        private void CreateColums2()
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

        private void RefrestDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from posts";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void AgreedDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from agreed";

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

        private void NextForm_Load(object sender, EventArgs e)
        {
            
            CreateColums();
            RefrestDataGrid(dataGridView1);
            CreateColums2();
            AgreedDataGrid(dataGridView2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selecedRow];
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
            dataBase.openConnection();
            var id = textBox2.Text;
            int.Parse(id.ToString());
            var type = textBox3.Text;
            var count = textBox4.Text;
            var title = textBox5.Text;
            var text = textBox7.Text;
            var author = textBox8.Text;

            int price;

            if (int.TryParse(textBox4.Text, out price))
            {
                var addQuery = $"insert into agreed (id_post, type_of, count_of, title, content, price, author) select id_post, type_of, count_of, title, content, price, author from posts where author = '{author}' and content = '{text}'" +
                $"delete from posts where author = '{author}' and content = '{text}'";
                   

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Публикация успешно опубликована", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Где-то произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefrestDataGrid(dataGridView1);
            AgreedDataGrid(dataGridView2);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from posts where concat (id_post, type_of, count_of, title, content, price, author) like '%" + textBox1.Text + "%'";
            
            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Update()
        {
            dataBase.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;
                if(rowState == RowState.Existed)
                {
                    continue;
                }
                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from posts where id_post = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());

                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var type = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var count = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var title = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var author = dataGridView1.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"update posts set type_of = '{type}', count_of = '{count}', title = '{title}', price = '{price}', content = '{text}' , author = '{author}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }


            }

            dataBase.closeConnection();
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible= false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
            }

            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dataGridView2.Enabled = false;
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
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBox2.Text;
            var type = textBox3.Text;
            var count = textBox4.Text;
            var title = textBox5.Text;
            int price;
            var text = textBox7.Text;
            var author = textBox8.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(textBox6.Text, out price))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, type, count, title, price, text, author);
                    dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
