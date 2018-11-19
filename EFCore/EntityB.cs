using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore
{
    public class EntityB : EntityA
    {
        public int OtherEntityId { get; set; }
        public virtual OtherEntity OtherEntity { get; set; }

        public override bool Condition
        {
            get
            {
                return OtherEntity.Name == "AA";
            }
        }
    }
}
