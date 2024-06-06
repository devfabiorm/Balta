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
    }

    public class Module
    {
        public Module()
        {
            Lectures = [];
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }

    public class Lecture
    {
        public int Order { get; set; }
        public string Title { get; set; }
    }
}