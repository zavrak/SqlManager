using System;
using System.Collections.Generic;

namespace Dataplatform.SQLManager.Web.DataModels
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
