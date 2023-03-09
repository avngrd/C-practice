using System.Xml.Linq;

namespace task_3
{
    internal class MyInfo
    {
        public event Action<string> Action;
        private string _name;
        public string Name { get { return _name; } set {
                if (_name != value)
                {
                    _name = value;
                    Action($"Name was changed {_name}");
                 return;
                }
                Action($"Name was't changed");
            } }

        public MyInfo(string name)
        {
            _name =  name;
        }

        public void NameChanged(string name)
        {
            if (name != _name)
            {
                _name = name;
                Action($"Name was changed {_name}");
                return;
            }
            Action($"Name was't changed");
        }
    }
}
