#pragma checksum "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "978609b183051b62a239bc8b43f68b0150092281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Id_ShowIDPage), @"mvc.1.0.view", @"/Views/Id/ShowIDPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Id/ShowIDPage.cshtml", typeof(AspNetCore.Views_Id_ShowIDPage))]
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
#line 1 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/_ViewImports.cshtml"
using AppProject;

#line default
#line hidden
#line 2 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/_ViewImports.cshtml"
using AppProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"978609b183051b62a239bc8b43f68b0150092281", @"/Views/Id/ShowIDPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f974743dfdac9f2662d6b767297e7963f729dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Id_ShowIDPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppProject.Models.Trainee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 4 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
  
    ViewData["ID Generation"] = "ID Generation";

#line default
#line hidden
            BeginContext(102, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 8 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
  
    var batch = Model.ToList()[1];
   // string duration = 

#line default
#line hidden
            BeginContext(168, 331, true);
            WriteLiteral(@"<div class=""container header"">
    <div class=""row"">
        <div class=""col-md-12 justify-content-center"">
            <p class=""text-center"">Government of People's Republic of Bangladesh<br><span class=""h5"">National Academy for Educational Management(NAEM)</span><br>
            NAEM Road, Dhanmondi, Dhaka-1205<br>
            ");
            EndContext();
            BeginContext(500, 39, false);
#line 17 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
       Write(Html.DisplayFor(model => batch.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(539, 54, true);
            WriteLiteral(" Foundation Training Course<br>\n            Duration: ");
            EndContext();
            BeginContext(594, 43, false);
#line 18 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
                 Write(Html.DisplayFor(model => batch.OpeningDate));

#line default
#line hidden
            EndContext();
            BeginContext(637, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(641, 43, false);
#line 18 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
                                                                Write(Html.DisplayFor(model => batch.ClosingDate));

#line default
#line hidden
            EndContext();
            BeginContext(684, 848, true);
            WriteLiteral(@"
            </p>
        </div> 
    </div> <!-- end of row -->
     <div class=""row"">
            <div class=""col-md-12 justify-content-right"">
                <p class=""text-right mr-3"">Date :.........................</p>
     </div>

</div>

<div id=""bdr"" class=""table-responsive table-bordered"">
<table class=""table table-hover "">
    <thead>
        <tr>
            <th class=""text-center"">ID</th> 
            <th class=""text-center"" style=""width:500px"">Name, Designation & Address</th>
            <th class=""text-center"" style=""padding-left:5;padding-right:5"">1st</th>
            <th class=""text-center"">2<span style="""" class=""pb-1"">nd</span></th>
            <th class=""text-center"">3rd</th>
            <th class=""text-center"">4th</th>
            <th class=""text-center"">5th</th>
         
        </tr>
    </thead>
   <tbody>
     
");
            EndContext();
#line 45 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
      var list = Model.ToList();
        for(int i =0; i<list.Count; i++)
        {

#line default
#line hidden
            BeginContext(1616, 64, true);
            WriteLiteral("            <tr>\n        <td class=\"text-center\">\n              ");
            EndContext();
            BeginContext(1681, 50, false);
#line 50 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
         Write(Html.DisplayFor(modelItem =>list[i].TraineeSerial));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 64, true);
            WriteLiteral("\n        </td> \n             \n        \n        <td>\n            ");
            EndContext();
            BeginContext(1796, 41, false);
#line 55 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
       Write(Html.DisplayFor(modelItem =>list[i].Name));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 18, true);
            WriteLiteral("<br>\n             ");
            EndContext();
            BeginContext(1856, 49, false);
#line 56 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
        Write(Html.DisplayFor(modelItem => list[i].Designation));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1908, 45, false);
#line 56 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
                                                            Write(Html.DisplayFor(modelItem => list[i].Subject));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 18, true);
            WriteLiteral(" <br>\n            ");
            EndContext();
            BeginContext(1972, 54, false);
#line 57 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
       Write(Html.DisplayFor(modelItem => list[i].WorkplaceAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2026, 222, true);
            WriteLiteral("\n           \n        </td>\n        <td class=\"text-center\"></td>  \n        <td class=\"text-center\"></td> \n        <td class=\"text-center\"></td> \n        <td class=\"text-center\"></td> \n        <td class=\"text-center\"></td>\n");
            EndContext();
            BeginContext(2449, 19, true);
            WriteLiteral("    \n        </tr>\n");
            EndContext();
#line 71 "/home/shaheen/Documents/BACKUP_18-12-19/APP/AppProject/Views/Id/ShowIDPage.cshtml"
           
        }
   
   

#line default
#line hidden
            BeginContext(2499, 27, true);
            WriteLiteral("   </tbody>\n</table>\n</div>");
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
