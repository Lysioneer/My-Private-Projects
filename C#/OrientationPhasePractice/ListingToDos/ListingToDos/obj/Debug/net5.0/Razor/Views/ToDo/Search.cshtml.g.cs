#pragma checksum "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ed514d1d3b5802cdf5a0805ba984efeec7149f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_Search), @"mvc.1.0.view", @"/Views/ToDo/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ed514d1d3b5802cdf5a0805ba984efeec7149f", @"/Views/ToDo/Search.cshtml")]
    public class Views_ToDo_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListingToDos.Models.ViewModel>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ed514d1d3b5802cdf5a0805ba984efeec7149f2778", async() => {
                WriteLiteral("\r\n    <title>Search result</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ed514d1d3b5802cdf5a0805ba984efeec7149f3780", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 9 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
Write(Html.ActionLink("Cancel", "List", "ToDo"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <form action=""/search"" method=""post"">
        <input type=""text"" placeholder=""Search for something else..."" name=""searchInput"" />
        <button type=""submit"">Search</button>
    </form>

    <table>
        <tr>
            <th>Id: </th>
            <th>Title: </th>
            <th>Description: </th>
            <th>Is It Urgent?</th>
            <th>Is It Done?</th>
            <th>Assignee: </th>
        </tr>
");
#nullable restore
#line 24 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
         for (int i = 0; i < Model.AllToDos.Count; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
               Write(Model.AllToDos[i].Key);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
               Write(Model.AllToDos[i].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
               Write(Model.AllToDos[i].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
                 if (Model.AllToDos[i].IsUrgent == true)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Yes</td>\r\n");
#nullable restore
#line 33 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>No</td>\r\n");
#nullable restore
#line 37 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
                 if (Model.AllToDos[i].IsDone == true)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>Yes</td>\r\n");
#nullable restore
#line 41 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>No</td>\r\n");
#nullable restore
#line 45 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td>");
#nullable restore
#line 46 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
               Write(Model.AllToDos[i].AssigneeId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1417, "\"", 1454, 3);
                WriteAttributeValue("", 1424, "/", 1424, 1, true);
#nullable restore
#line 48 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
WriteAttributeValue("", 1425, Model.AllToDos[i].Key, 1425, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1447, "/remove", 1447, 7, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n                </td>\r\n                <td>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1535, "\"", 1570, 3);
                WriteAttributeValue("", 1542, "/", 1542, 1, true);
#nullable restore
#line 51 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
WriteAttributeValue("", 1543, Model.AllToDos[i].Key, 1543, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1565, "/edit", 1565, 5, true);
                EndWriteAttribute();
                WriteLiteral(">Edit</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "C:\My Stuff\Documents\C#\OrientationPhasePractice\ListingToDos\ListingToDos\Views\ToDo\Search.cshtml"
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