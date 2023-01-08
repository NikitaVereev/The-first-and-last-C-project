﻿using System;
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
    public partial class NewPost : Form
    {
        DataBase dataBase = new DataBase();
        public NewPost()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
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
                var addQuery = $"insert into posts (type_of, count_of, title, content, price, author) values('{type}', '{count}', '{title}', '{text}', '{price}', '{author}')" ;

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Публикация успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Где-то произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
        }
    }
}
