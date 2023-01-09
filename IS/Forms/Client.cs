

using IS.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

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

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user = '{passUserr}'";
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
MessageBox.Show("Вы успушно вошли!", "УСпешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserPanel frm1 = new UserPanel(loginUser);
                this.Hide();
                frm1.ShowDialog();
                this.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }



        private void button2_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            

            var loginUser = txtEmail.Text;
            var passUserr = txtPassword.Text;

            

            
            string querystring =  $"insert into register(login_user, password_user, is_admin) values('{loginUser}', '{passUserr}', 0)";
                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                dataBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Аккаунт успешно создан!", "УСпешно!");
                    AdminPanel frm1 = new AdminPanel(loginUser);
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!");
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
                MessageBox.Show("Пользователь цжу существует!");
                return true;

            }
            else
            {
                return false;
            }
        }



    }
}