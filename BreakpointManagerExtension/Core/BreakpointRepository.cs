using BreakpointManagerExtension;
using EnvDTE;
using EnvDTE80;
using System.Collections.Generic;
using Microsoft.VisualStudio.Shell;

namespace Core
{
    public interface IBreakpointRepository
    {
        List<BreakpointInfo> GetAllBreakpoints();
    }

    internal class BreakPointRepository : IBreakpointRepository
    {
        private DTE2 Dte2 {  get; set; }

        public BreakPointRepository(DTE2 dte2)
        {
            Dte2 = dte2;
        }

        public List<BreakpointInfo> GetAllBreakpoints()
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            var allBreakpoints = new List<BreakpointInfo>();

            foreach (Breakpoint bp in Dte2.Debugger.Breakpoints)
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
}
