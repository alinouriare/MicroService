using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdempotentConsumers
{
    public interface IMessageInboxItemRepository
    {
        bool AllowReceive(string messageId, string fromService);
        void Receive(string messageId, string fromService);
    }
}
