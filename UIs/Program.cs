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
<<<<<<< HEAD
        //Application.Run(new G_Login());
        // Application.Run(new G_ForgotPassword());
        //Application.Run(new CM_CreateAccount());
        Application.Run(new C_AccountManagement());
=======
        // Application.Run(new M_Information());
        // Application.Run(new G_ForgotPassword());
        // Application.Run(new A_FileUploader());
        Application.Run(new Form1());
>>>>>>> 004a9a167b55e196f85eba3bf02ba5cbb7e0cfb2
    }    
}