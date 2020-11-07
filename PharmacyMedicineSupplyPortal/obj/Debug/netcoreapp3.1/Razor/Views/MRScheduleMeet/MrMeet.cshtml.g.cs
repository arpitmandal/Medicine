#pragma checksum "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0843de72b7651675e475c37bfb22ac335973937e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MRScheduleMeet_MrMeet), @"mvc.1.0.view", @"/Views/MRScheduleMeet/MrMeet.cshtml")]
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
#line 1 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\_ViewImports.cshtml"
using PharmacyMedicineSupplyPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\_ViewImports.cshtml"
using PharmacyMedicineSupplyPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0843de72b7651675e475c37bfb22ac335973937e", @"/Views/MRScheduleMeet/MrMeet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9685d027ff493b0e119fe978bfd7137e24be02cc", @"/Views/_ViewImports.cshtml")]
    public class Views_MRScheduleMeet_MrMeet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PharmacyMedicineSupplyPortal.Models.RepSchedule>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
  
    ViewData["Title"] = "MrMeet";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Medical Reprentaive Schedule Meet</h1>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"


    <script type=""text/javascript"">
        $(function () {
            var dtToday = new Date();

            var month = dtToday.getMonth() + 1;
            var day = dtToday.getDate();
            var year = dtToday.getFullYear();
            if (month < 10)
                month = '0' + month.toString();
            if (day < 10)
                day = '0' + day.toString();

            var maxDate = year + '-' + month + '-' + day;
            
            $('#txtDate').attr('min', maxDate);
        });
    </script>

");
            }
            );
            WriteLiteral(@"<style>
    input[type = date] {
        width: 100%;
        padding: 12px 20px;
        margin: 8px 0;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
    }

    input[type = submit] {
        width: 100%;
        background-color: #4CAF50;
        color: white;
        padding: 14px 20px;
        margin: 8px 0;
        border: none;
        border-radius: 4px;
        cursor: pointer;
    }

        input[type = submit]:hover {
            background-color: #45a049;
        }

    .intro {
        border-radius: 5px;
        background-color: #f2f2f2;
        padding: 20px;
    }
</style>
");
#nullable restore
#line 63 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
 using (Html.BeginForm("Index", "MRScheduleMeet", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""intro"">
    <table cellpadding=""5"">
        <tr>

            <td><h4>Enter Start Date</h4></td>

        </tr>
    </table>
    <input type=""date"" id=""txtDate"" name=""startDate""/>
   

    <input type=""submit"" value=""Submit"" />



    <br />

</div>
");
#nullable restore
#line 83 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<table class=""table text-center table-striped table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th>
                MR Name
            </th>
            <th>
                Doctor Name
            </th>
            <th>
                Treating Ailment
            </th>
            <th>
                Target Medicine
            </th>
            <th>
                Meeting Slot
            </th>
            <th>
                Date of Meeting
            </th>
            <th>
                Doctor Contact Number
            </th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 113 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 117 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
               Write(Html.DisplayFor(modelItem => item.MRName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 120 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
               Write(Html.DisplayFor(modelItem => item.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 123 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
               Write(Html.DisplayFor(modelItem => item.TreatingAilment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 126 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
               Write(Html.DisplayFor(modelItem => item.Medicine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 129 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
               Write(Html.DisplayFor(modelItem => item.MeetingSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 132 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateofMeeting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 135 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
               Write(Html.DisplayFor(modelItem => item.DoctorContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 138 "F:\MFRFv1\PharmacyMedicineSupplyPortal\Views\MRScheduleMeet\MrMeet.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PharmacyMedicineSupplyPortal.Models.RepSchedule>> Html { get; private set; }
    }
}
#pragma warning restore 1591
