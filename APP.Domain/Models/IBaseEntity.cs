using System;
using System.Collections.Generic;
using System.Text;

namespace APP.Core.Models
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
