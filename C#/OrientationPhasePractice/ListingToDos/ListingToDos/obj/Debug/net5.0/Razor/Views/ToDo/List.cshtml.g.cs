#pragma checksum "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4503138253b1a2b8eb61c1dea0ac4eef834663b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_List), @"mvc.1.0.view", @"/Views/ToDo/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4503138253b1a2b8eb61c1dea0ac4eef834663b", @"/Views/ToDo/List.cshtml")]
    public class Views_ToDo_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListingToDos.Models.ViewModel>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4503138253b1a2b8eb61c1dea0ac4eef834663b2768", async() => {
                WriteLiteral("\r\n    <title>List of ToDos</title>\r\n    <link href=\"./wwwroot/output.css\" rel=\"stylesheet\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4503138253b1a2b8eb61c1dea0ac4eef834663b3833", async() => {
                WriteLiteral(@"
    <div class=""text-3xl font-bold underline"">
        <form action=""/search"" method=""post"">
            <input type=""text"" placeholder=""Search..."" name=""searchInput"" />
            <button type=""submit"">Search</button>
        </form>

        <h1>ToDos for today: </h1>
        ");
#nullable restore
#line 16 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
   Write(Html.ActionLink("See Undone", "ListUndone", "ToDo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
   Write(Html.ActionLink("See All", "List", "ToDo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
   Write(Html.ActionLink("Add a ToDo", "Add", "ToDo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 19 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
   Write(Html.ActionLink("See Assignees", "ListAssignees", "Assignee"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <table>
            <tr>
                <th>Id: </th>
                <th>Title: </th>
                <th>Description: </th>
                <th>Is it urgent? </th>
                <th>Is it done? </th>
                <th>Assignee: </th>
            </tr>
");
#nullable restore
#line 29 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
             for (int i = 0; i < Model.AllToDos.Count; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 32 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
                   Write(Model.AllToDos[i].Key);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
                   Write(Model.AllToDos[i].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
                   Write(Model.AllToDos[i].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
                     if (Model.AllToDos[i].IsUrgent == true)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>Yes</td>\r\n");
#nullable restore
#line 38 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>No</td>\r\n");
#nullable restore
#line 42 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
                     if (Model.AllToDos[i].IsDone == true)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>Yes</td>\r\n");
#nullable restore
#line 46 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>No</td>\r\n");
#nullable restore
#line 50 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>");
#nullable restore
#line 51 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
                   Write(Model.AllToDos[i].Assignee.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1888, "\"", 1925, 3);
                WriteAttributeValue("", 1895, "/", 1895, 1, true);
#nullable restore
#line 53 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
WriteAttributeValue("", 1896, Model.AllToDos[i].Key, 1896, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1918, "/remove", 1918, 7, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n                    </td>\r\n                    <td>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2018, "\"", 2053, 3);
                WriteAttributeValue("", 2025, "/", 2025, 1, true);
#nullable restore
#line 56 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
WriteAttributeValue("", 2026, Model.AllToDos[i].Key, 2026, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2048, "/edit", 2048, 5, true);
                EndWriteAttribute();
                WriteLiteral(">Edit</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 59 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\List.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    </div>\r\n");
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
