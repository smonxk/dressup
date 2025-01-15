namespace starup
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Launch Form1 as the first form
            using (Form1 mainForm = new Form1())
            {
                mainForm.ShowDialog();  // Show Form1 as a dialog
            }
        }
    }
}