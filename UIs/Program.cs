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
        // Application.Run(new M_AssignTask());
        // Application.Run(new A_ShowMember());
        // Application.Run(new A_ShowVenue());
        Application.Run(new G_Login());
        // Application.Run(new E_Information());
        // Application.Run(new Form1());
        // Application.Run(new M_AssignTask());
        // Application.Run(new A_ShowTag());
        // Application.Run(new C_AssignTask());
        // Application.Run(new CM_Resident_sDetail());
        // Application.Run(new A_EditTask());
        //Application.Run(new A_EditTask());
    }  
}