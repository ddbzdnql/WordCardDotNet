#pragma checksum "/Users/shaozewang/Desktop/CSE/Industry/DotNet/Projects/WordCard/WordCard/Views/Admin/Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab84ac32e23827dcff292257d3e773cc5d75a98f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Display), @"mvc.1.0.view", @"/Views/Admin/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Display.cshtml", typeof(AspNetCore.Views_Admin_Display))]
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
#line 5 "/Users/shaozewang/Desktop/CSE/Industry/DotNet/Projects/WordCard/WordCard/Views/Admin/Display.cshtml"
using WordCard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab84ac32e23827dcff292257d3e773cc5d75a98f", @"/Views/Admin/Display.cshtml")]
    public class Views_Admin_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IWordRepository>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/shaozewang/Desktop/CSE/Industry/DotNet/Projects/WordCard/WordCard/Views/Admin/Display.cshtml"
  
    Layout = "../shared/_Layout";

#line default
#line hidden
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(75, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab84ac32e23827dcff292257d3e773cc5d75a98f3309", async() => {
                BeginContext(81, 70, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"css/admin.css\" />\r\n");
                EndContext();
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
            EndContext();
            BeginContext(158, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(186, 878, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab84ac32e23827dcff292257d3e773cc5d75a98f4550", async() => {
                BeginContext(192, 340, true);
                WriteLiteral(@"
    <table>
        <thead>
            <tr>
                <th colspan=""1"">Index</th>
                <th colspan=""2"">Word</th>
                <th colspan=""2"">Explanation</th>
                <th colspan=""2"">CorrectRate</th>
                <th colspan=""2"">operations</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 26 "/Users/shaozewang/Desktop/CSE/Industry/DotNet/Projects/WordCard/WordCard/Views/Admin/Display.cshtml"
             foreach (var w in Model.Words){

#line default
#line hidden
                BeginContext(578, 72, true);
                WriteLiteral("                <tr class=\"entry\">\r\n                    <td colspan=\"1\">");
                EndContext();
                BeginContext(651, 7, false);
#line 28 "/Users/shaozewang/Desktop/CSE/Industry/DotNet/Projects/WordCard/WordCard/Views/Admin/Display.cshtml"
                               Write(w.Index);

#line default
#line hidden
                EndContext();
                BeginContext(658, 63, true);
                WriteLiteral("</td>\r\n                    <td class=\"entry_title\" colspan=\"2\">");
                EndContext();
                BeginContext(722, 6, false);
#line 29 "/Users/shaozewang/Desktop/CSE/Industry/DotNet/Projects/WordCard/WordCard/Views/Admin/Display.cshtml"
                                                   Write(w.Name);

#line default
#line hidden
                EndContext();
                BeginContext(728, 69, true);
                WriteLiteral("</td>\r\n                    <td class=\"entry_explanation\" colspan=\"2\">");
                EndContext();
                BeginContext(798, 13, false);
#line 30 "/Users/shaozewang/Desktop/CSE/Industry/DotNet/Projects/WordCard/WordCard/Views/Admin/Display.cshtml"
                                                         Write(w.Explanation);

#line default
#line hidden
                EndContext();
                BeginContext(811, 43, true);
                WriteLiteral("</td>\r\n                    <td colspan=\"2\">");
                EndContext();
                BeginContext(855, 14, false);
#line 31 "/Users/shaozewang/Desktop/CSE/Industry/DotNet/Projects/WordCard/WordCard/Views/Admin/Display.cshtml"
                               Write(w.TimesCorrect);

#line default
#line hidden
                EndContext();
                BeginContext(869, 3, true);
                WriteLiteral(" / ");
                EndContext();
                BeginContext(873, 15, false);
#line 31 "/Users/shaozewang/Desktop/CSE/Industry/DotNet/Projects/WordCard/WordCard/Views/Admin/Display.cshtml"
                                                 Write(w.TimesAccessed);

#line default
#line hidden
                EndContext();
                BeginContext(888, 120, true);
                WriteLiteral("</td>\r\n                    <td colspan=\"2\"><button>Delete</button> <button>Change</button></td>\r\n                </tr>\r\n");
                EndContext();
#line 34 "/Users/shaozewang/Desktop/CSE/Industry/DotNet/Projects/WordCard/WordCard/Views/Admin/Display.cshtml"
            }

#line default
#line hidden
                BeginContext(1023, 34, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IWordRepository> Html { get; private set; }
    }
}
#pragma warning restore 1591
