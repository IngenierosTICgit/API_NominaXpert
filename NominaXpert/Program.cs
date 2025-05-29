using OfficeOpenXml;

namespace NominaXpertCore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new View.Forms.Login());
            //Application.Run(new View.MDI_Nomina());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool usuarioAutenticado = false;

            do
            {
                View.Forms.Login loginForm = new View.Forms.Login();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    usuarioAutenticado = true;
                    Application.Run(new View.MDI_Nomina());  // Solo se ejecuta UNA VEZ
                }
                else
                {
                    usuarioAutenticado = false;
                }

            } while (usuarioAutenticado == false);  // No permite que el MDI se ejecute dos veces


        }
    }
}