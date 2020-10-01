using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathCollection
{
    public abstract class Content
    {
        private static List<string> paths = new List<string>();
        private static List<string> names = new List<string>();

        public static List<string> Paths
        {
            get { return paths; }
        }

        public static List<string> Names
        {
            get { return names; }
        }
    }
}
