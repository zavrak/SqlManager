#pragma checksum "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a3fb48fb45f6af0d2bbe3c9f357c218a0a87d82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\_ViewImports.cshtml"
using Dataplatform.SQLManager.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\_ViewImports.cshtml"
using Dataplatform.SQLManager.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3fb48fb45f6af0d2bbe3c9f357c218a0a87d82", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b2832ec29eaf0ad655765f74394b772d961cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dataplatform.SQLManager.Web.DataModels.Script>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a3fb48fb45f6af0d2bbe3c9f357c218a0a87d823860", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"jquery.highlighter.css\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h4>Script Details</h4>\r\n    <hr />\r\n\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ScriptType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\" style=\"background-color:ghostwhite\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Model.ScriptType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\" style=\"background-color:ghostwhite \">\r\n            ");
#nullable restore
#line 25 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ScriptText));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dt>

        <dd class=""col-sm-10"" style=""background-color:ghostwhite"" >
            <div class=""rounded-right"">
                <button class=""btn btn-primary"" id=""btnCopy"">Copy</button>
            </div>
            <pre class=""code"" data-language=""sql"" contenteditable=""true"">   
            <textarea id=""Ctext"" class=""md-textarea form-control"" style=""height:800px ;resize:none; font-size:small"" readonly>
                      ");
#nullable restore
#line 38 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
                 Write(Model.ScriptText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </textarea>\r\n                    </pre>\r\n\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Keyword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\" style=\"background-color: ghostwhite \">\r\n            ");
#nullable restore
#line 48 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Model.Keyword);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\" style=\"background-color:ghostwhite \">\r\n            ");
#nullable restore
#line 55 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\" style=\"background-color:ghostwhite \">\r\n            ");
#nullable restore
#line 61 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Model.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SqlVersion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\" style=\"background-color: ghostwhite \">\r\n            ");
#nullable restore
#line 67 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Model.SqlVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AlwaysOnActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dt>\r\n        <dd class=\"col-sm-10\" style=\"background-color:ghostwhite \">\r\n            ");
#nullable restore
#line 74 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Details.cshtml"
       Write(Model.AlwaysOnActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a3fb48fb45f6af0d2bbe3c9f357c218a0a87d8211167", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>



</div>
<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<script src=""jquery.highlight.js""></script>

<script>
   
    document.getElementById(""btnCopy"").addEventListener(""click"", function () {
        var copyText = document.getElementById(""Ctext"");
        copyText.select();
        document.execCommand(""Copy"");
        alert(""Copied Clipboard!"");
    });
     
</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dataplatform.SQLManager.Web.DataModels.Script> Html { get; private set; }
    }
}
#pragma warning restore 1591
