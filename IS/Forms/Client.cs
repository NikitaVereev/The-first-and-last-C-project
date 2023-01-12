

using IS.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace IS
{
    public partial class Client : Form
    {
        
        DataBase dataBase = new DataBase();
        


        public Client()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtEmail.MaxLength = 50;
            txtPassword.MaxLength = 50;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           var loginUser = txtEmail.Text;
            var passUserr = txtPassword.Text;

           

            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user = '{passUserr}'";
            var queryGetId = $"select id_user from register where login_user = '{loginUser}'";

            var commandGetId = new SqlCommand(queryGetId, dataBase.getConnection());

            dataBase.openConnection();
            SqlDataReader reader = commandGetId.ExecuteReader();
            while (reader.Read())
            {
                DataStorage.UserLogin = reader[0].ToString();
            }
            reader.Close();
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                if (loginUser == "admin" && passUserr == "admin")
                {
                    AdminPanel frm1 = new AdminPanel(loginUser);
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
                else
                {
MessageBox.Show("�� ������� �����!", "�������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewPost frm1 = new NewPost(loginUser);
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
                
            }
            else
            {
                MessageBox.Show("������ �������� �� ����������!", "�������� �� ����������!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }



        private void button2_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();

            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "���� ����������";
            

            var loginUser = txtEmail.Text;
            var passUserr = txtPassword.Text;

            if (checkuser())
            {
                return;
            }

            if(!Regex.IsMatch(txtPassword.Text, "(?=.*?[A-Z])(?=.*?[a-z])(?=.*[0-9])(?=.*?[#?!@$%^&*-]).{8,}"))
            {
                MessageBox.Show("����������, ������� ������", caption, btn, ico);
                return;
            }
            
            
            string querystring =  $"insert into register(login_user, password_user, is_admin) values('{loginUser}', '{passUserr}', 0)";
                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                dataBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("������� ������� ������!", "�������!");
                    NewPost frm1 = new NewPost(loginUser);
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                
                
                
            }
                else
                {
                    MessageBox.Show("������� �� ������!");
                }
                dataBase.closeConnection();
            


        }

        private Boolean checkuser()
        {
            var loginUser = txtEmail.Text;
            var passUser = txtPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand= command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("������������ ��� ����������!");
                return true;

            }
            else
            {
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true) {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}