namespace UIs;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        // Application.Run(new C_AssignTask());
        // Application.Run(new A_ShowMember());
        // Application.Run(new A_ShowVenue());
        Application.Run(new G_Login());
    }    
}