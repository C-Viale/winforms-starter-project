using System.Diagnostics;
using WinFormsStarter.Forms;

namespace WinFormsStarter
{

    public partial class LoginForm : Form
    {
        public bool UserAuthenticated { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            label_Error.Visible = false;
            string username = input_Username.Text;
            string password = input_Password.Text;

            DatabaseContext db = new DatabaseContext();

            User? user = db.Users.SingleOrDefault(d => d.Name == username && d.Password == password);

            if (user == null)
            {
                label_Error.Visible = true;
                return;
            }

            UserAuthenticated = true;
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

