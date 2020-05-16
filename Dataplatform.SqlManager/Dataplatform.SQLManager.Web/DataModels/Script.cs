using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dataplatform.SQLManager.Web.DataModels
{
    public partial class Script
    {   
       
        public int Id { get; set; }
        
        public string ScriptType { get; set; }

        [Required(ErrorMessage = "Type gir")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Type gir")]
        public string ScriptText { get; set; }
        public string Keyword { get; set; }
       
        [Required]
        public Guid ScriptGuid { get; set; }
       
        [Required]
        public DateTime CreateDate { get; set; }
        
        [Required(ErrorMessage = "Type gir")]
        public bool? IsActive { get; set; }
        
        [Required(ErrorMessage = "Type gir")]
        public string SqlVersion { get; set; }
        
        [Required(ErrorMessage = "Type gir")]
        public bool? AlwaysOnActive { get; set; }
    }
  
    }



