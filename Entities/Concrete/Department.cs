using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Department : IEntity
    {
        public string DepartmentName { get; set; }
    }
}
