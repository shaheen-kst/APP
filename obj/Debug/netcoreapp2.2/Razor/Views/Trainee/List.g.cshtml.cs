#pragma checksum "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e420b06a5b521a90fbcdf3c4963c343b43b788ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trainee_List), @"mvc.1.0.view", @"/Views/Trainee/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Trainee/List.cshtml", typeof(AspNetCore.Views_Trainee_List))]
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
#line 1 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/_ViewImports.cshtml"
using AppProject;

#line default
#line hidden
#line 2 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/_ViewImports.cshtml"
using AppProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e420b06a5b521a90fbcdf3c4963c343b43b788ee", @"/Views/Trainee/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f974743dfdac9f2662d6b767297e7963f729dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Trainee_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppProject.Models.Trainee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("lead"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(89, 107, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 my-5\">\r\n        <h2 class=\"text-left text-success\" style=\"\"> ");
            EndContext();
            BeginContext(197, 20, false);
#line 9 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
                                                Write(Model.ToList().Count);

#line default
#line hidden
            EndContext();
            BeginContext(217, 119, true);
            WriteLiteral(" teachers have registered so far.</h2>\r\n       \r\n    </div>\r\n    <div class=\"col-md-4 my-5\">\r\n         <p> \r\n          ");
            EndContext();
            BeginContext(336, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e420b06a5b521a90fbcdf3c4963c343b43b788ee5875", async() => {
                BeginContext(372, 18, true);
                WriteLiteral("Click to Register ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(394, 221, true);
            WriteLiteral("\r\n       </p> \r\n    </div>\r\n</div>\r\n\r\n<table class=\"table-responsive\">\r\n<table class=\"table table-hover \">\r\n    <thead>\r\n        <tr>\r\n            <th>SL No.</th>\r\n            <th>Name</th>\r\n            \r\n            <th>");
            EndContext();
            BeginContext(616, 47, false);
#line 26 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
           Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(663, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(687, 52, false);
#line 27 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkplaceAddress));

#line default
#line hidden
            EndContext();
            BeginContext(739, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(763, 47, false);
#line 28 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
           Write(Html.DisplayNameFor(model => model.Course_Name));

#line default
#line hidden
            EndContext();
            BeginContext(810, 64, true);
            WriteLiteral(" </th>\r\n            <th>Registration Date</th>\r\n            <th>");
            EndContext();
            BeginContext(875, 52, false);
#line 30 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
           Write(Html.DisplayNameFor(model => model.ProfileImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(927, 78, true);
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n   <tbody>\r\n     \r\n");
            EndContext();
#line 36 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
      var list = Model.ToList();
        for(int i =0; i<list.Count; i++)
        {

#line default
#line hidden
            BeginContext(1092, 44, true);
            WriteLiteral("            <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1138, 3, false);
#line 41 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
        Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(1142, 62, true);
            WriteLiteral(".\r\n        </td>        \r\n        \r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1205, 42, false);
#line 45 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
       Write(Html.DisplayFor(modelItem =>list[i].Name ));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 52, true);
            WriteLiteral("\r\n        </td>\r\n      \r\n        <td>\r\n             ");
            EndContext();
            BeginContext(1300, 49, false);
#line 49 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
        Write(Html.DisplayFor(modelItem => list[i].Designation));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1393, 54, false);
#line 52 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
       Write(Html.DisplayFor(modelItem => list[i].WorkplaceAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1491, 49, false);
#line 55 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
       Write(Html.DisplayFor(modelItem => list[i].Course_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1584, 45, false);
#line 58 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
       Write(Html.DisplayFor(modelItem => list[i].RegDate));

#line default
#line hidden
            EndContext();
            BeginContext(1629, 49, true);
            WriteLiteral("\r\n        </td>\r\n          <td>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1678, "\"", 1739, 1);
#line 61 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
WriteAttributeValue("", 1684, Html.DisplayFor(modelItem => list[i].ProfileImagePath), 1684, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1740, 72, true);
            WriteLiteral(" width=\"180\" height=\"150\"/>\r\n        </td>\r\n        <td>\r\n              ");
            EndContext();
            BeginContext(1812, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e420b06a5b521a90fbcdf3c4963c343b43b788ee12482", async() => {
                BeginContext(1860, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
                                     WriteLiteral(list[i].ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1868, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1941, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1957, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e420b06a5b521a90fbcdf3c4963c343b43b788ee14893", async() => {
                BeginContext(2026, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
                                          WriteLiteral(list[i].ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 66 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
                                                                     WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2037, 26, true);
            WriteLiteral("|&nbsp;\r\n                 ");
            EndContext();
            BeginContext(2063, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e420b06a5b521a90fbcdf3c4963c343b43b788ee17901", async() => {
                BeginContext(2097, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2107, 21, true);
            WriteLiteral(" \r\n                \r\n");
            EndContext();
            BeginContext(2210, 52, true);
            WriteLiteral("              \r\n        </td>\r\n    \r\n        </tr>\r\n");
            EndContext();
#line 74 "/home/falcon/Documents/PROJECTS/30-04-19_19.55/AppProject/Views/Trainee/List.cshtml"
           
        }
   
   

#line default
#line hidden
            BeginContext(2297, 29, true);
            WriteLiteral("   </tbody>\r\n</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppProject.Models.Trainee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
