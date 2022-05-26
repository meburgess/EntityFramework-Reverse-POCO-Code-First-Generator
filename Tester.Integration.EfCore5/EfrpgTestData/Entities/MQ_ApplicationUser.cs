// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace V5EfrpgTest
{
    // ApplicationUsers
    public class MQ_ApplicationUser
    {
        public int Id { get; set; } // Id (Primary key)

        // Reverse navigation

        /// <summary>
        /// Child MQ_Logs where [Logs].[ImpersonatingUserId] point to this entity (FK_MQ_LOGS__ImpersonatingUser)
        /// </summary>
        public virtual ICollection<MQ_Log> MQ_Logs_ImpersonatingUserId { get; set; } // Logs.FK_MQ_LOGS__ImpersonatingUser

        /// <summary>
        /// Child MQ_Logs where [Logs].[UserId] point to this entity (FK_MQ_LOGS__User)
        /// </summary>
        public virtual ICollection<MQ_Log> MQ_Logs_UserId { get; set; } // Logs.FK_MQ_LOGS__User

        public MQ_ApplicationUser()
        {
            MQ_Logs_ImpersonatingUserId = new List<MQ_Log>();
            MQ_Logs_UserId = new List<MQ_Log>();
        }
    }

}
// </auto-generated>
