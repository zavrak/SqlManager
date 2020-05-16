using System;
using System.Collections.Generic;

namespace Dataplatform.SQLManager.Web.DataModels
{
    public partial class ScriptType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid ScriptTypeUuid { get; set; }
    }
}
