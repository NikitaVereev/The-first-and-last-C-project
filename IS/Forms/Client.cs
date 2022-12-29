

using IS.Forms;
using SLRDbConnector;

namespace IS
{
    public partial class Client : Form
    {
        
        DataBase dataBase = new DataBase();
        


        public Client()
        {
            InitializeComponent();
           
            
             
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
               
            }
        }

        

        private bool isFormValid()
        {

            if (txtEmail.Text.ToString().Trim() == string.Empty || txtPassword.Text.ToString().Trim() == string.Empty)
                
            {
                MessageBox.Show("Require Fields are Empty", "Please FillAll Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
            }else
            {
                return true;
            }
        }
    }
}