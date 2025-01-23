using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Core;

public class BreakpointInfo
{
    public string File { get; set; }

    public int Line { get; set; }

    public int Column { get; set; }

    public string Condition { get; set; }

    public bool Enabled { get; set; }

    public string Name { get; set; }
}
