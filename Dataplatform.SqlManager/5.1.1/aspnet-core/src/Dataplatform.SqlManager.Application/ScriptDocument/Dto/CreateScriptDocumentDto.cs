using Abp.AutoMapper;
using Abp.Runtime.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dataplatform.SqlManager.ScriptDocument.Dto
{
    [AutoMapTo(typeof(ScriptDocument))]
    public class CreateScriptDocumentDto : IShouldNormalize
    {
        [Required]
        public ScriptTypeEnum? ScriptType { get; set; }

        [Required]

        public string ScriptText { get; set; }

        [Required]
        public string Title { get; set; }

        public bool SqlVersion { get; set; }
        public bool AlwaysOnActive { get; set; }

        public void Normalize()
        {
            if (ScriptType == null)
            {
                ScriptType = ScriptTypeEnum.Other;
            }
        }
    }
}
