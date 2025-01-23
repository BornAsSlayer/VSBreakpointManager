namespace BreakpointManagerExtension
{
    public class BreakpointInfo
    {
        public string File { get; set; }

        public int Line { get; set; }

        public int Column { get; set; }

        public string Condition { get; set; }

        public bool Enabled { get; set; }

        public string Name { get; set; }
    }
}
