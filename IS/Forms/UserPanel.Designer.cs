using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IS.Forms
{
    partial class UserPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Административная панель";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1071, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 273);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Опубликовать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 273);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1478, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Location = new System.Drawing.Point(655, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 392);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дополинтельная информация";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Добавить имя";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(12, 64);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(193, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 355);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование профиля";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(50, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "E-mail";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(54, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 46);
            this.button4.TabIndex = 6;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(50, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Пароль";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(54, 185);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(297, 43);
            this.textBox9.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 59);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Издательский дом ";
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Segoe UI Black", 11.8F, System.Drawing.FontStyle.Bold);
            this.btn_new.Location = new System.Drawing.Point(1082, 154);
            this.btn_new.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(285, 60);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "Публикация";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Black", 11.8F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Location = new System.Drawing.Point(1083, 263);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(285, 60);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Перевод";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1486, 584);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox13);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.btn_new);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1478, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(728, 538);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(125, 22);
            this.textBox13.TabIndex = 10;
            this.textBox13.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(889, 538);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(125, 22);
            this.textBox10.TabIndex = 9;
            this.textBox10.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(597, 539);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(125, 22);
            this.textBox11.TabIndex = 8;
            this.textBox11.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(18, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(341, 38);
            this.label11.TabIndex = 7;
            this.label11.Text = "Одобреные переводы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(17, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(371, 38);
            this.label10.TabIndex = 6;
            this.label10.Text = "Одобреные публикации";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(18, 374);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(1350, 162);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 154);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1045, 170);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(17, 484);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Публикация";
            this.groupBox1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(415, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Автор";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(415, 283);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(451, 38);
            this.textBox8.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(29, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Цена";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(415, 54);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(451, 205);
            this.textBox7.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(415, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Текст";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(29, 283);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(353, 30);
            this.textBox6.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(29, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Название";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(29, 228);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(353, 38);
            this.textBox5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество копий";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 169);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(353, 38);
            this.textBox4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип материала";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 111);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(353, 38);
            this.textBox3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(29, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 54);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(353, 38);
            this.textBox2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.textBox14);
            this.panel2.Controls.Add(this.textBox15);
            this.panel2.Controls.Add(this.textBox16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(18, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 243);
            this.panel2.TabIndex = 6;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(20, 55);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(417, 42);
            this.textBox14.TabIndex = 0;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(252, 184);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(199, 42);
            this.textBox15.TabIndex = 4;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(20, 184);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(202, 42);
            this.textBox16.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Номер карты";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Срок действия";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(285, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "CVV-код";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 37);
            this.button5.TabIndex = 7;
            this.button5.Text = "Добавить карту";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 584);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TabPage tabPage2;
        private Panel panel1;
        private Label label2;
        private Button btn_new;
        private Button btn_delete;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox textBox8;
        private Label label7;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private DataGridView dataGridView2;
        private Label label11;
        private Label label10;
        private DataGridView dataGridView3;
        private TextBox textBox11;
        private TextBox textBox13;
        private TextBox textBox10;
        private Button button4;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox textBox12;
        private TextBox textBox9;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button button5;
        private Panel panel2;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}