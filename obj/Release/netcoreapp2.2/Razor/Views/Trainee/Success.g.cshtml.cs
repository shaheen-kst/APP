#pragma checksum "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0e7520390c2070509a5a7df7b78e354b5a744cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trainee_Success), @"mvc.1.0.view", @"/Views/Trainee/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Trainee/Success.cshtml", typeof(AspNetCore.Views_Trainee_Success))]
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
#line 1 "/home/office/Downloads/AppProject/Views/_ViewImports.cshtml"
using AppProject;

#line default
#line hidden
#line 2 "/home/office/Downloads/AppProject/Views/_ViewImports.cshtml"
using AppProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0e7520390c2070509a5a7df7b78e354b5a744cb", @"/Views/Trainee/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f974743dfdac9f2662d6b767297e7963f729dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Trainee_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppProject.Models.Trainee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
  
    ViewData["Title"] = "Success";

#line default
#line hidden
            BeginContext(78, 95, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\" col-md-10 alert alert-success\">\r\n    <h3 class=\"mb-0;pb-0\">");
            EndContext();
            BeginContext(174, 17, false);
#line 7 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(191, 41, true);
            WriteLiteral("!</h3>\r\n    <p class=\"mb-0;pb-0\"><strong>");
            EndContext();
            BeginContext(233, 36, false);
#line 8 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
                            Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(269, 84, true);
            WriteLiteral("</strong>, You have successfully registerd to attend<span class=\"font-weight-bold\"> ");
            EndContext();
            BeginContext(354, 39, false);
#line 8 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
                                                                                                                                                     Write(Html.DisplayFor(model => model.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(393, 3, true);
            WriteLiteral("th ");
            EndContext();
            BeginContext(397, 43, false);
#line 8 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
                                                                                                                                                                                                Write(Html.DisplayFor(model => model.Course_Name));

#line default
#line hidden
            EndContext();
            BeginContext(440, 378, true);
            WriteLiteral(@" </span> of NAEM.</p>
    </div>
    <div class=""col-md-2""><h3 style=""text-align:right"" class=""print""><a href=""#""><i class=""fas fa-print""></i></a></h3></div>
</div>
<div class=""row"">
    <h3 class=""col-md-6 text-left"">Trainee Info</h3>
  
</div>
<h3></h3>
 <hr>
<dl class=""row"">
            <!--  DSHE SERIAL -->
             <dt class=""col-sm-4"">
                 ");
            EndContext();
            BeginContext(819, 42, false);
#line 21 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
            Write(Html.DisplayNameFor(model => model.DsheSL));

#line default
#line hidden
            EndContext();
            BeginContext(861, 127, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(989, 38, false);
#line 24 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
           Write(Html.DisplayFor(model => model.DsheSL));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 73, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                 ");
            EndContext();
            BeginContext(1101, 47, false);
#line 27 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
            Write(Html.DisplayNameFor(model => model.TraineeType));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 127, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1276, 43, false);
#line 30 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
           Write(Html.DisplayFor(model => model.TraineeType));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 107, true);
            WriteLiteral("\r\n            </dd>\r\n           <!--  Course Info -->\r\n            <dt class=\"col-sm-4\">\r\n                 ");
            EndContext();
            BeginContext(1427, 47, false);
#line 34 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
            Write(Html.DisplayNameFor(model => model.Course_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 127, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1602, 43, false);
#line 37 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
           Write(Html.DisplayFor(model => model.Course_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 77, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n             <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(1723, 43, false);
#line 41 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayNameFor(model => model.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 127, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1894, 39, false);
#line 44 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
           Write(Html.DisplayFor(model => model.BatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 75, true);
            WriteLiteral("\r\n            </dd>\r\n             <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(2009, 47, false);
#line 47 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayNameFor(model => model.OpeningDate));

#line default
#line hidden
            EndContext();
            BeginContext(2056, 132, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                From ");
            EndContext();
            BeginContext(2189, 43, false);
#line 50 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
                Write(Html.DisplayFor(model => model.OpeningDate));

#line default
#line hidden
            EndContext();
            BeginContext(2232, 5, true);
            WriteLiteral(" to  ");
            EndContext();
            BeginContext(2238, 43, false);
#line 50 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
                                                                 Write(Html.DisplayFor(model => model.ClosingDate));

#line default
#line hidden
            EndContext();
            BeginContext(2281, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
            BeginContext(2637, 108, true);
            WriteLiteral("            \r\n            <!-- Personal Info -->\r\n               <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(2746, 40, false);
#line 61 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2786, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(2920, 36, false);
#line 64 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2956, 80, true);
            WriteLiteral("\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(3037, 52, false);
#line 67 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayNameFor(model => model.ProfileImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(3089, 137, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3226, "\"", 3281, 1);
#line 70 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
WriteAttributeValue("", 3232, Html.DisplayFor(model => model.ProfileImagePath), 3232, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3282, 108, true);
            WriteLiteral(" width=\"180\" height=\"150\"/>\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(3391, 46, false);
#line 73 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(3437, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(3572, 42, false);
#line 76 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayFor(model => model.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(3614, 81, true);
            WriteLiteral("\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(3696, 46, false);
#line 79 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.MotherName));

#line default
#line hidden
            EndContext();
            BeginContext(3742, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(3877, 42, false);
#line 82 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayFor(model => model.MotherName));

#line default
#line hidden
            EndContext();
            BeginContext(3919, 80, true);
            WriteLiteral("\r\n              </dd>\r\n              <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(4000, 42, false);
#line 85 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(4042, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(4176, 38, false);
#line 88 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(4214, 79, true);
            WriteLiteral("\r\n              </dd>\r\n              <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(4294, 47, false);
#line 91 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(4341, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(4475, 43, false);
#line 94 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(4518, 82, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n\r\n             <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(4601, 46, false);
#line 99 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayNameFor(model => model.BloodGroup));

#line default
#line hidden
            EndContext();
            BeginContext(4647, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(4782, 42, false);
#line 102 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayFor(model => model.BloodGroup));

#line default
#line hidden
            EndContext();
            BeginContext(4824, 93, true);
            WriteLiteral("\r\n              </dd>\r\n             \r\n             <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(4918, 49, false);
#line 106 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
            EndContext();
            BeginContext(4967, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(5101, 45, false);
#line 109 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.MaritalStatus));

#line default
#line hidden
            EndContext();
            BeginContext(5146, 81, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n               <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(5228, 39, false);
#line 113 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(5267, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(5401, 35, false);
#line 116 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(5436, 80, true);
            WriteLiteral("\r\n              </dd>\r\n              <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(5517, 42, false);
#line 119 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.CellNo));

#line default
#line hidden
            EndContext();
            BeginContext(5559, 131, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(5691, 38, false);
#line 122 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
           Write(Html.DisplayFor(model => model.CellNo));

#line default
#line hidden
            EndContext();
            BeginContext(5729, 77, true);
            WriteLiteral("\r\n              </dd>\r\n             <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(5807, 41, false);
#line 125 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(5848, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(5983, 37, false);
#line 128 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(6020, 81, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n              <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(6102, 39, false);
#line 132 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayNameFor(model => model.NID));

#line default
#line hidden
            EndContext();
            BeginContext(6141, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(6275, 35, false);
#line 135 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.NID));

#line default
#line hidden
            EndContext();
            BeginContext(6310, 82, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n              <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(6393, 52, false);
#line 139 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.PermanentAddress));

#line default
#line hidden
            EndContext();
            BeginContext(6445, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(6579, 48, false);
#line 142 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.PermanentAddress));

#line default
#line hidden
            EndContext();
            BeginContext(6627, 127, true);
            WriteLiteral("\r\n              </dd>\r\n             \r\n            <!--  JOB INFO -->\r\n               <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(6755, 47, false);
#line 147 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(6802, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(6936, 43, false);
#line 150 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(6979, 82, true);
            WriteLiteral("\r\n              </dd>\r\n                <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(7062, 43, false);
#line 153 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(7105, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(7240, 39, false);
#line 156 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(7279, 80, true);
            WriteLiteral("\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(7360, 43, false);
#line 159 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayNameFor(model => model.IndexNo));

#line default
#line hidden
            EndContext();
            BeginContext(7403, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(7537, 39, false);
#line 162 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.IndexNo));

#line default
#line hidden
            EndContext();
            BeginContext(7576, 83, true);
            WriteLiteral("\r\n              </dd>\r\n                  <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(7660, 47, false);
#line 165 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayNameFor(model => model.NameOfCadre));

#line default
#line hidden
            EndContext();
            BeginContext(7707, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(7842, 43, false);
#line 168 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayFor(model => model.NameOfCadre));

#line default
#line hidden
            EndContext();
            BeginContext(7885, 80, true);
            WriteLiteral("\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(7966, 46, false);
#line 171 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayNameFor(model => model.BCSBatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(8012, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(8146, 42, false);
#line 174 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.BCSBatchNo));

#line default
#line hidden
            EndContext();
            BeginContext(8188, 81, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n             <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(8270, 52, false);
#line 178 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.WorkplaceAddress));

#line default
#line hidden
            EndContext();
            BeginContext(8322, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(8457, 48, false);
#line 181 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayFor(model => model.WorkplaceAddress));

#line default
#line hidden
            EndContext();
            BeginContext(8505, 80, true);
            WriteLiteral("\r\n              </dd>\r\n              <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(8586, 42, false);
#line 184 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.EiinNo));

#line default
#line hidden
            EndContext();
            BeginContext(8628, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(8763, 38, false);
#line 187 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayFor(model => model.EiinNo));

#line default
#line hidden
            EndContext();
            BeginContext(8801, 81, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n             <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(8883, 57, false);
#line 191 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.AcademicQualification));

#line default
#line hidden
            EndContext();
            BeginContext(8940, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(9075, 53, false);
#line 194 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayFor(model => model.AcademicQualification));

#line default
#line hidden
            EndContext();
            BeginContext(9128, 157, true);
            WriteLiteral("\r\n              </dd>\r\n\r\n             \r\n\r\n              <!-- EMMERGENCY CONTACT INFO -->\r\n            \r\n            <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(9286, 57, false);
#line 202 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayNameFor(model => model.EmmergencyContactName));

#line default
#line hidden
            EndContext();
            BeginContext(9343, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(9477, 53, false);
#line 205 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.EmmergencyContactName));

#line default
#line hidden
            EndContext();
            BeginContext(9530, 93, true);
            WriteLiteral("\r\n              </dd>\r\n             \r\n              <dt class=\"col-sm-4\">\r\n                  ");
            EndContext();
            BeginContext(9624, 59, false);
#line 209 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayNameFor(model => model.EmmergencyContactCellNo));

#line default
#line hidden
            EndContext();
            BeginContext(9683, 133, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                  ");
            EndContext();
            BeginContext(9817, 55, false);
#line 212 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
             Write(Html.DisplayFor(model => model.EmmergencyContactCellNo));

#line default
#line hidden
            EndContext();
            BeginContext(9872, 93, true);
            WriteLiteral("\r\n              </dd>\r\n          \r\n               <dt class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(9966, 52, false);
#line 216 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
               Write(Html.DisplayNameFor(model => model.SignatureImgPath));

#line default
#line hidden
            EndContext();
            BeginContext(10018, 138, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 10156, "\"", 10211, 1);
#line 219 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
WriteAttributeValue("", 10162, Html.DisplayFor(model => model.SignatureImgPath), 10162, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10212, 107, true);
            WriteLiteral(" width=\"180\" height=\"150\"/>\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n                   ");
            EndContext();
            BeginContext(10320, 43, false);
#line 222 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayNameFor(model => model.RegDate));

#line default
#line hidden
            EndContext();
            BeginContext(10363, 134, true);
            WriteLiteral("<span style=\"display:inline-block;float:right\">:</span>\r\n              </dt>\r\n              <dd class=\"col-sm-6\">\r\n                   ");
            EndContext();
            BeginContext(10498, 39, false);
#line 225 "/home/office/Downloads/AppProject/Views/Trainee/Success.cshtml"
              Write(Html.DisplayFor(model => model.RegDate));

#line default
#line hidden
            EndContext();
            BeginContext(10537, 104, true);
            WriteLiteral("\r\n              </dd>\r\n               <dt class=\"col-sm-4\">\r\n\r\n               </dt>\r\n        </dl>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppProject.Models.Trainee> Html { get; private set; }
    }
}
#pragma warning restore 1591
