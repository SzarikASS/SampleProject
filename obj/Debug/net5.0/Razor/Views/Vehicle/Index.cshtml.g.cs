#pragma checksum "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77f2dcb83fb9ae848177c9cb7a935cb0d7df4cb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_Index), @"mvc.1.0.view", @"/Views/Vehicle/Index.cshtml")]
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
#line 1 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\_ViewImports.cshtml"
using SampleProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\_ViewImports.cshtml"
using SampleProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77f2dcb83fb9ae848177c9cb7a935cb0d7df4cb6", @"/Views/Vehicle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7547ae200e22a29bcae05ee832a90868ebf4ba26", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SampleProject.Models.VehicleModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77f2dcb83fb9ae848177c9cb7a935cb0d7df4cb63466", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<div class=\"container d-flex flex-wrap\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 18rem;\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 262, "\"", 304, 2);
            WriteAttributeValue("", 268, "https://i.pravatar.cc/150?u=", 268, 28, true);
#nullable restore
#line 11 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml"
WriteAttributeValue("", 296, item.Id, 296, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 326, "\"", 350, 1);
#nullable restore
#line 11 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml"
WriteAttributeValue("", 332, item.VehicleBrand, 332, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml"
                                  Write(item.VehicleBrand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml"
                                  Write(item.ModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml"
                                Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 610, "\"", 642, 2);
            WriteAttributeValue("", 617, "/Vehicle/Details/", 617, 17, true);
#nullable restore
#line 16 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml"
WriteAttributeValue("", 634, item.Id, 634, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">View details</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 704, "\"", 737, 2);
            WriteAttributeValue("", 711, "/Vehicle/EditForm/", 711, 18, true);
#nullable restore
#line 17 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml"
WriteAttributeValue("", 729, item.Id, 729, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 791, "\"", 822, 2);
            WriteAttributeValue("", 798, "/Vehicle/Delete/", 798, 16, true);
#nullable restore
#line 18 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml"
WriteAttributeValue("", 814, item.Id, 814, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\anton\Desktop\Tyrka\PNL\MVC\SampleProject\SampleProject\Views\Vehicle\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SampleProject.Models.VehicleModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
