using System.Collections.Generic;

namespace Analytics_server
{
    public class starInfo
    {
        public starInfo(string name = null, int born = default, List<string> moviesAppearedIn = null)
        {
            Name = name;
            this.born = born;
            this.moviesAppearedIn = moviesAppearedIn;
        }

        public string Name { get; set; }
        public int born { get; set; }
        public List<string> moviesAppearedIn { get; set; }
    }
}