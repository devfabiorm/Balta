using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = [];
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}