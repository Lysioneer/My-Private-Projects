#pragma checksum "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f0c16149c6bff16ba250fe62e1798bf97b8736"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assignee_ListAssignees), @"mvc.1.0.view", @"/Views/Assignee/ListAssignees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f0c16149c6bff16ba250fe62e1798bf97b8736", @"/Views/Assignee/ListAssignees.cshtml")]
    public class Views_Assignee_ListAssignees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListingToDos.Models.ViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3f0c16149c6bff16ba250fe62e1798bf97b87362833", async() => {
                WriteLiteral("\r\n    <title>List Of Assignees</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3f0c16149c6bff16ba250fe62e1798bf97b87363839", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 9 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml"
Write(Html.ActionLink("Back", "List", "ToDo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <h1>List of Assignees</h1>\r\n\r\n    ");
#nullable restore
#line 13 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml"
Write(Html.ActionLink("Add assignee", "AddAssignee", "Assignee"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <table>\r\n        <tr>\r\n            <th>Id: </th>\r\n            <th>Name: </th>\r\n            <th>Gender: </th>\r\n            <th>Email: </th>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml"
         for (int i = 0; i < Model.AllAssignees.Count; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml"
               Write(Model.AllAssignees[i].Key);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml"
               Write(Model.AllAssignees[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml"
               Write(Model.AllAssignees[i].Gender);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml"
               Write(Model.AllAssignees[i].Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 810, "\"", 859, 3);
                WriteAttributeValue("", 817, "/", 817, 1, true);
#nullable restore
#line 30 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml"
WriteAttributeValue("", 818, Model.AllAssignees[i].Key, 818, 26, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 844, "/deleteAssignee", 844, 15, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n                </td>\r\n                <td>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 940, "\"", 987, 3);
                WriteAttributeValue("", 947, "/", 947, 1, true);
#nullable restore
#line 33 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml"
WriteAttributeValue("", 948, Model.AllAssignees[i].Key, 948, 26, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 974, "/editAssignee", 974, 13, true);
                EndWriteAttribute();
                WriteLiteral(">Edit</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\Assignee\ListAssignees.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListingToDos.Models.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
