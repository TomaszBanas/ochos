using System.Runtime.InteropServices;


public class Program
{
    [DllImport("user32.dll")]
    public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
    public static void Main(string[] args)
    {
        if (args.Length != 1)
            throw new ArgumentException("Wrong number of arguments");

        int? key = int.TryParse(args[0], out var i) ? i : null;

        if (!key.HasValue)
            throw new ArgumentException("Wrong argument value");

        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
        keybd_event((byte)key.Value, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
    }
}


