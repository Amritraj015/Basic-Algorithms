namespace DoublyLinkedList
{
    class Employee
    {
        private readonly string _name;

        public Employee(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return  " " + _name + " ";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Employee)) return false;

            return _name == ((Employee) obj)._name;
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode();
        }
    }
}
