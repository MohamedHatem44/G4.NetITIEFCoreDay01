// How To Write Model Classes With EF RunTime?
// 1- EF Convensions
// 2- Data Annotaions
// 3- Fluent API
// 4- External Configration Class


// 1- EF Convensions
// 1- PK => Primitive int Id, <classname>Id => EmployeeId    EmpId  XXXXXXXXXXXX
// 2- PK => Identity Col
// 3- any value type column => not null
// 4- any Ref Type column => Allow null
// 5- string => nvarchar(max) => 5GB


using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G4.NetITIEFCoreDay01.Model
{
    //[Table("hr_Employees")]
    //[Index(nameof(Name))]
    public class Employee
    {
        /*-----------------------------------------------------*/
        [Key]
        public int Id { get; set; }
        /*-----------------------------------------------------*/
        [Required]
        //[MinLength(3)]
        //[MaxLength(20)]
        [StringLength(25,MinimumLength = 4)]
        [Column("EMP_Name")]
        public string Name { get; set; }
        /*-----------------------------------------------------*/
        public int? Age { get; set; }
        /*-----------------------------------------------------*/
        //[NotMapped]
        //public int? SSN { get; set; }
        /*-----------------------------------------------------*/
        public decimal Salary { get; set; }
        /*-----------------------------------------------------*/
        public int? DepartmentId { get; set; }  // => // Not Req

        // Navigation Prop
        //[ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        /*-----------------------------------------------------*/
        public override string ToString()
        {
            string departmentName = Department != null ? Department.DeptName : "No Department";
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, DeptId: {DepartmentId}, DeptName: {departmentName}";
        }
    }
}
