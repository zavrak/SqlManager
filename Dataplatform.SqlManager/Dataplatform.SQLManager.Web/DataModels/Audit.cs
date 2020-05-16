using System;
using System.Collections.Generic;

namespace Dataplatform.SQLManager.Web.DataModels
{
    public partial class Audit
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
