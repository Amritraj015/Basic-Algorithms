namespace Linked_List
{
    class EmployeeNode
    {
        private readonly Employee _employee;
        private EmployeeNode _next;

        public EmployeeNode(Employee employee)
        {
            _employee = employee;
        }

        public EmployeeNode GetNext()
        {
            return _next;
        }

        public void SetNext(EmployeeNode next)
        {
            _next = next;
        }


        public override string ToString()
        {
            return _employee.ToString();
        }
    }
}
