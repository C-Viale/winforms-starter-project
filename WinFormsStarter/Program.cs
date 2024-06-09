using WinFormsStarter.Forms;

namespace WinFormsStarter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            InitDatabase();

            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            if (loginForm.UserAuthenticated)
            {
                Application.Run(new MainForm());
            }
        }

        static void InitDatabase()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string DbPath = Path.Join(path, "data.db");

            if (!File.Exists(DbPath))
            {
                File.Create(DbPath);
            }

            DatabaseContext db = new DatabaseContext();
            List<User> users = db.Users.ToList();

            if (users.Count == 0)
            {
                db.Add(new User { Name = "admin", Password = "123" });
                db.SaveChanges();
            }
        }
    }
}