using EnvDTE;
using EnvDTE80;
using System.Runtime.InteropServices;
using System;

namespace Core;

public class Program
{

    public static void Main()
    {
        var va = (DTE2)Marshal.GetActiveObject("VisualStudio.DTE");

        if (dte2 == null)
        {
            Console.WriteLine("DTE2 is null. Make sure you are running this in a Visual Studio extension environment.");
            return;
        }

        // Create the repository instance
        IBreakpointRepository repository = new BreakPointRepository(dte2);

        // Get all breakpoints
        List<BreakpointInfo> breakpoints = repository.GetAllBreakpoints();
    }
}