using CoreDomain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDomain.Entities
{
public abstract    class Entity: IAuditable
    {
        public long Id { get; protected set; }
        public BusinessId BusinessId { get; protected set; } = BusinessId.FromGuid(Guid.NewGuid());
        protected Entity() { }
    }
}
