using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("kernel32.dll")]
    static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    const int SW_HIDE = 0;

    static void Main()
    {
        // Hide Console Window
        var handle = GetConsoleWindow();
        ShowWindow(handle, SW_HIDE);

        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "wt.exe", // Windows Terminal executable
            UseShellExecute = true
        };

        try
        {
            Process.Start(startInfo);
        }
        catch (Exception ex)
        {
            // Handle errors silently or log them as needed
        }
    }
}
