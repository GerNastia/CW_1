namespace CW_1
{
    internal static class Program
    {
        private static DBworker worker = new DBworker("C:\\Users\\User\\source\\repos\\CW_1\\users.db");
        private static Form1 form1 = new Form1(); 
        private static authForm authForm = new authForm(form1, worker);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            authForm.Show();

            Application.Run(form1);
        }
    }
}