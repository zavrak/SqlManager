using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Dataplatform.SqlManager.ScriptDocument
{
    public class ScriptDocument : Entity, IHasCreationTime
    {
        [Required]
        public ScriptTypeEnum ScriptType { get; set; }

        [Required]

        public string ScriptText { get; set; }

        [Required]
        public string Title { get; set; }

        public bool SqlVersion { get; set; }
        public bool AlwaysOnActive { get; set; }


        public DateTime CreationTime { get; set; }

    }

    public enum ScriptTypeEnum : byte
    {
        Other = 0,
        Performance = 1,
        Tracking = 2,
        Optimization =3
    }
}
