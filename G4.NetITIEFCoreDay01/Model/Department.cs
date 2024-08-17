namespace G4.NetITIEFCoreDay01.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        /*-----------------------------------------------------*/
        public ICollection<Employee> Employees = new HashSet<Employee>();
        /*-----------------------------------------------------*/
        public override string ToString()
        {
            return $"Id: {Id}, Name: {DeptName}";
        }
    }
}
