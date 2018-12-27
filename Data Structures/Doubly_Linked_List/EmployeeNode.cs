namespace DoublyLinkedList
{
    class EmployeeNode
    {
        private readonly Employee _employee;
        private EmployeeNode _next;
        private EmployeeNode _previous;

        public EmployeeNode(Employee employee)
        {
            _employee = employee;
        }

        public EmployeeNode GetPrevious()
        {
            return _previous;
        }

        public EmployeeNode GetNext()
        {
            return _next;
        }

        public void SetNext(EmployeeNode employeeNode)
        {
            _next = employeeNode;
        }

        public void SetPrevious(EmployeeNode employeeNode)
        {
            _previous = employeeNode;
        }

        public Employee GetEmployee()
        {
            return _employee;
        }

        public override string ToString()
        {
            return _employee.ToString();
        }
    }
}
