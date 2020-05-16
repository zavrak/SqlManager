using System.Collections.Generic;
using Dataplatform.SqlManager.Roles.Dto;
using Dataplatform.SqlManager.ScriptDocument.Dto;
using Dataplatform.SqlManager.Users.Dto;

namespace Dataplatform.SqlManager.Web.Models.ScriptDocument
{
    public class ScriptDocumentListViewModel
    {
        public IReadOnlyList<ScriptDocumentDto> ScriptDocuments { get; set; }

        public ScriptDocumentListViewModel(IReadOnlyList<ScriptDocumentDto> documents)
        {
            ScriptDocuments = documents;
        }

        public string GetTaskLabel(ScriptDocumentDto documents)
        {

            switch (documents.ScriptType)
            {
                case SqlManager.ScriptDocument.ScriptTypeEnum.Other:
                    return "label-primary";

                case SqlManager.ScriptDocument.ScriptTypeEnum.Performance:
                    return "label-success";

                case SqlManager.ScriptDocument.ScriptTypeEnum.Tracking:
                    return "label-warning";

                case SqlManager.ScriptDocument.ScriptTypeEnum.Optimization:
                    return "label-success";


            }
            return "";
        }
    }



}
