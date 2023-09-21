namespace Entity_Framework_Core.Models
{
    public class Teacher : BaseModel
    {
        private readonly Dictionary<string, object> _data = new Dictionary<string, object>();
        public string Name { get; set; }
        public int SchoolId { get; set; } 
        public object this[string key]
        {
            get { return _data[key]; }
            set { _data[key] = value; }
        }
    }
}
