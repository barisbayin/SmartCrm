using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class EntityBase : IEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; } = null;
        public int? ModifiedBy { get; set; } = null;
        public bool IsRemoved { get; set; } = false;
        public DateTime? RemovedDate { get; set; } = null;
        public int? RemovedBy { get; set; } = null;
    }
}
