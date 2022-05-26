// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5EfrpgTest
{
    // Logs
    public class MQ_Log
    {
        public int Id { get; set; } // Id (Primary key)
        public int? UserId { get; set; } // UserId
        public int? ImpersonatingUserId { get; set; } // ImpersonatingUserId

        // Foreign keys

        /// <summary>
        /// Parent MQ_ApplicationUser pointed by [Logs].([ImpersonatingUserId]) (FK_MQ_LOGS__ImpersonatingUser)
        /// </summary>
        public virtual MQ_ApplicationUser ImpersonatingUser { get; set; } // FK_MQ_LOGS__ImpersonatingUser

        /// <summary>
        /// Parent MQ_ApplicationUser pointed by [Logs].([UserId]) (FK_MQ_LOGS__User)
        /// </summary>
        public virtual MQ_ApplicationUser User { get; set; } // FK_MQ_LOGS__User
    }

}
// </auto-generated>
