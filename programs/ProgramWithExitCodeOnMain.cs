namespace ProgramWithExitCodeOnMain
{
    public class MyProgram
    {
        // May take in an argument that specifies the exit code the application should return
        public static int Main(string args[])
        {
            if (int.TryParse(args.FirstOrDefault(), out int exitCode))
                return exitCode;
            else
                return 0;
        }
    }
}
