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

using static System.Net.Mime.MediaTypeNames;

namespace IS.Forms
{

    public partial class AdminTranslates : Form
    {


        DataBase dataBase = new DataBase();

        int selecedRow;

        public AdminTranslates()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            
        }





        private void CreateColums()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("annotation", "Аннотация");
            dataGridView1.Columns.Add("synopsis", "Синопсис");
            dataGridView1.Columns.Add("trans", "Перевод");
            dataGridView1.Columns.Add("title", "Название");
            dataGridView1.Columns.Add("original_author", "Оригинальный автор");
            dataGridView1.Columns.Add("original_language", "Оригинальный язык");
            dataGridView1.Columns.Add("privilege", "Лицензия");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("count_of", "Количество");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }
        private void CreateColums2()
        {
            dataGridView2.Columns.Add("id", "id");
            dataGridView2.Columns.Add("annotation", "Аннотация");
            dataGridView2.Columns.Add("synopsis", "Синопсис");
            dataGridView2.Columns.Add("trans", "Перевод");
            dataGridView2.Columns.Add("title", "Название");
            dataGridView2.Columns.Add("original_author", "Оригинальный автор");
            dataGridView2.Columns.Add("original_language", "Оригинальный язык");
            dataGridView2.Columns.Add("privilege", "Лицензия");
            dataGridView2.Columns.Add("price", "Цена");
            dataGridView2.Columns.Add("count_of", "Количество");
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
            textBox9.Text = "";
            
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetString(2),record.GetString(3),record.GetString(4),record.GetString(5), record.GetString(6), record.GetString(7), record.GetInt32(8), record.GetInt32(9), RowState.ModifiedNew);
        }

        private void RefrestDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from translates";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void AgreedDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from agreed_translates";

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

        private void AdminTranslates_Load_1(object sender, EventArgs e)
        {

            CreateColums();
            RefrestDataGrid(dataGridView1);
            
            CreateColums2();
            AgreedDataGrid(dataGridView2);
            


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selecedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selecedRow];
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "")
            {
                MessageBox.Show("Выберете элемент удаления", "Ок", MessageBoxButtons.OK);
            }
            else
            {
                dataBase.openConnection();
                var id = textBox2.Text;
                int.Parse(id.ToString());
                var ann = textBox3.Text;
                var syn = textBox4.Text;
                var tran = textBox5.Text;
                var tit = textBox6.Text;
                var or_a = textBox7.Text;
                var or_l = textBox8.Text;
                var pri = textBox11.Text;
                var count = textBox13.Text;

                int price;

                if (int.TryParse(textBox10.Text, out price))
                {
                    var addQuery = $"insert into agreed_translates (id_translate, annotation, synopsis, trans, title, original_author, original_language, privilege, price, count_of, id_user) select id_translate, annotation, synopsis, trans, title, original_author, original_language, privilege, price, count_of, id_user from translates where id_translate = '{id}' and trans = '{tran}'" +
                        $"delete from translates where id_translate = '{id}' and trans = '{tran}'";


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

           
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            RefrestDataGrid(dataGridView1);
            AgreedDataGrid(dataGridView2); 
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from translates where concat (id_translate, annotation, synopsis, trans, title, original_author, original_language, privilege,price,count_of, id_user) like '%" + textBox1.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
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

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[10].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from translates where id_post = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());

                    command.ExecuteNonQuery();
                }

                


            }

            dataBase.closeConnection();
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
            }

            dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {

            dataGridView2.Enabled = false;
            DeleteRow();
            ClearFields();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            Update();
            ClearFields();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBox2.Text;
            var ann = textBox3.Text;
            var syn = textBox4.Text;
            var tran = textBox5.Text;
            int price;
            var tit = textBox6.Text;
            var or_a = textBox7.Text;
            var or_l = textBox8.Text;
            var pri = textBox11.Text;
            var count = textBox13.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox10.Text, out price))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, ann, syn, tran, tit, or_a, or_l, pri, price, count);
                    dataGridView1.Rows[selectedRowIndex].Cells[10].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат");
                }
            }
        }

        

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            selecedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selecedRow];
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
