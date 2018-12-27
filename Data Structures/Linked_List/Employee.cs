namespace Linked_List
{
    class Employee
    {
        private readonly string _name;
        private readonly int _id;

        public Employee(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public override string ToString()
        {
            return _id + ": " + _name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Employee)) return false;

            return _id == ((Employee) obj)._id && _name == ((Employee) obj)._name;
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() + _id.GetHashCode();
        }
    }
}
