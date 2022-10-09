using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace Core.Entities
{
    public class BaseEntity
    {
        public virtual int Id { get; set; }
        public bool Status { get; set; } = true;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; } = null;
        public int? ModifiedBy { get; set; } = null;
        public bool IsRemoved { get; set; } = false;
        public DateTime? RemovedDate { get; set; } = null;
        public int? RemovedBy { get; set; } = null;
    }
}
