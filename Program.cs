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
            // énables visual styles for the application 
            Application.EnableVisualStyles();

            // set text rendering to be compatible with the system (helps with font rendering)
            Application.SetCompatibleTextRenderingDefault(false);

            // launch the first form of the application (Form1) as a dialog
            using (Form1 mainForm = new Form1())
            {
                mainForm.ShowDialog();  // show Form1 as a modal dialog (blocking until it's closed)
            }
        }
    }
}