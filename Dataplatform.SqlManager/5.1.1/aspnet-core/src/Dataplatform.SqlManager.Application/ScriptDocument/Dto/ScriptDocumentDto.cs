using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Dataplatform.SqlManager.Authorization.Users;

namespace Dataplatform.SqlManager.ScriptDocument.Dto
{


    [AutoMapFrom(typeof(ScriptDocument))]
    public class ScriptDocumentDto : EntityDto<long>
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
}
