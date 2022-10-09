using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : BaseEntity, IEntity
    {
        public string CustomerName { get; set; }
    }
}
