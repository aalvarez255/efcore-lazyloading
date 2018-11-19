using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore
{
    public abstract class EntityA
    {
        public EntityA() { }

        public int Id { get; set; }

        [NotMapped]
        public abstract bool Condition { get; }
    }
}
