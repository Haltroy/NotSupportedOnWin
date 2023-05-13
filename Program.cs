namespace NotSupportedOnWin;

public static class Program
{
    public static void Main()
    {
        try
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32S:
                case PlatformID.Win32NT:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                case PlatformID.Xbox:
                    throw new PlatformNotSupportedException("Windows is not supported right now.");
                // TODO: Add Windows Support
                // jk

                default:
                case PlatformID.Unix:
                case PlatformID.MacOSX:
                case PlatformID.Other:
                    Console.WriteLine($"hello {Environment.OSVersion.VersionString}");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error while running application, exception caught: {e.ToString()}");
        }
    }
}