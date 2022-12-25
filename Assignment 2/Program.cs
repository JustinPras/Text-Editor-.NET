namespace Assignment_2
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
            FileManager fileManager = new FileManager();
            Application.Run(new Login(fileManager));

        }
    }
}