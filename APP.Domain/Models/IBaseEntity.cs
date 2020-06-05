using System;
using System.Collections.Generic;
using System.Text;

namespace APP.Domain.Models
{
    public interface IBaseEntity
    {
        public Guid Id  { get; set; }
        public DateTime CreatedAt  { get; set; }
    }
}
