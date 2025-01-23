using EnvDTE;
using EnvDTE80;

namespace Core;

public interface IBreakpointRepository
{
    public List<BreakpointInfo> GetAllBreakpoints();
}

internal class BreakPointRepository(DTE2 dte2) : IBreakpointRepository
{
    private DTE2 DTE2 { get; set; } = dte2;

    public List<BreakpointInfo> GetAllBreakpoints()
    {
        var allBreakpoints = new List<BreakpointInfo>();

        foreach (Breakpoint bp in DTE2.Debugger.Breakpoints)
        {
            allBreakpoints.Add(new BreakpointInfo
            {
                File = bp.File,
                Line = bp.FileLine,
                Column = bp.FileColumn,
                Condition = bp.Condition,
                Enabled = bp.Enabled,
                Name = bp.Name,
            });
        }
        
        return allBreakpoints;
    }
}
