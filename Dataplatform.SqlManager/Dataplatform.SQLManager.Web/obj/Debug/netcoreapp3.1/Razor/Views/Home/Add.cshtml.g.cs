#pragma checksum "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563490fba987d519ca87ee8127404411fb8d9047"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Add), @"mvc.1.0.view", @"/Views/Home/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563490fba987d519ca87ee8127404411fb8d9047", @"/Views/Home/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b2832ec29eaf0ad655765f74394b772d961cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dataplatform.SQLManager.Web.DataModels.Script>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
  
    ViewData["Title"] = "Add";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col\">\r\n");
#nullable restore
#line 8 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
         using (Html.BeginForm("Add", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3> Add Script</h3>\r\n");
#nullable restore
#line 11 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n");
#nullable restore
#line 16 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 19 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.ScriptType, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.EditorFor(model => model.ScriptType, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.ScriptType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2 " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control " } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 35 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.ScriptText, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.TextAreaFor(model => model.ScriptText, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.ScriptText, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 44 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.Keyword, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.EditorFor(model => model.Keyword, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 47 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Keyword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 52 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.IsActive, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 54 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.EditorFor(model => model.IsActive, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 55 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.IsActive, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 60 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.SqlVersion, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.EditorFor(model => model.SqlVersion, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 63 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.SqlVersion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 68 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
           Write(Html.LabelFor(model => model.AlwaysOnActive, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 70 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.EditorFor(model => model.AlwaysOnActive, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 71 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.AlwaysOnActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <button type=""submit"" value=""Save"" class=""btn btn-success"">Save</button>

                </div>
            </div>
            <div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563490fba987d519ca87ee8127404411fb8d904713817", async() => {
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
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 85 "C:\Users\Merve Zavrak\Desktop\Dataplatform.SqlManager\Dataplatform.SQLManager.Web\Views\Home\Add.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    </div>
            <style>

                label {
                    font: .8em,bold;
                }

                textarea {
                    font: 1.4em/1.5em;
                    background-color: ghostwhite;
                    padding: 20px;
                    margin: 0;
                    width: 80%;
                    resize: none;
                    width: 900px;
                    height: 600px;
                }
                input {
                    background-color:ghostwhite;
                }
            </style>

       

      
<div class=""col"">

</div>



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