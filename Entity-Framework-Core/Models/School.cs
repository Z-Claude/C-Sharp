namespace Entity_Framework_Core.Models
{
    public class School : BaseModel
    {
        private readonly Dictionary<string, object> _data = new Dictionary<string, object>();

        public School()
        {
            Teachers= new List<Teacher>();
        }

        public string Name { get; set; }
        public List<Teacher> Teachers { get; }

        public object this[string key]
        {
            get { return _data[key]; }
            set { _data[key] = value;}
        }

    }
}


