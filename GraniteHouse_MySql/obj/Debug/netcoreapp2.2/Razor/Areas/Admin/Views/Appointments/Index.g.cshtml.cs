#pragma checksum "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f91b91671903fc238d1df6289164e8852ddd2b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Appointments_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Appointments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Appointments/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Appointments_Index))]
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
#line 1 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse_MySQL;

#line default
#line hidden
#line 2 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse_MySQL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f91b91671903fc238d1df6289164e8852ddd2b9", @"/Areas/Admin/Views/Appointments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d582f5e19e89a3a1401bc0bf4cb34c3475b56c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Appointments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GraniteHouse_MySQL.Models.ViewModel.AppointmentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-default active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-primary active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::GraniteHouse_MySQL.TagHelpers.PageLinkTagHelper __GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(155, 5088, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f91b91671903fc238d1df6289164e8852ddd2b96244", async() => {
                BeginContext(175, 162, true);
                WriteLiteral("\r\n    <br /><br />\r\n    <h2 class=\"text-info\">Appointment List</h2>\r\n    <br />\r\n    <div style=\"height: 150px; background-color: aliceblue;\" class=\"container\">\r\n");
                EndContext();
                BeginContext(378, 243, true);
                WriteLiteral("        <div class=\"col-12\">\r\n            <div class=\"row\" style=\"padding-top: 10px;\">\r\n                <div class=\"col-2\">\r\n                    Customer Name :\r\n                </div>\r\n                <div class=\"col-3\">\r\n                    ");
                EndContext();
                BeginContext(622, 83, false);
#line 19 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
               Write(Html.Editor("searchName", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(705, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(825, 234, true);
                WriteLiteral("                </div>\r\n                <div class=\"col-2\">\r\n\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    Email :\r\n                </div>\r\n                <div class=\"col-3\">\r\n                    ");
                EndContext();
                BeginContext(1060, 84, false);
#line 30 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
               Write(Html.Editor("searchEmail", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1144, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(1263, 256, true);
                WriteLiteral(@"                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-2"">
                    Phone Number :
                </div>
                <div class=""col-3"">
                    ");
                EndContext();
                BeginContext(1520, 84, false);
#line 39 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
               Write(Html.Editor("searchPhone", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1604, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(1731, 245, true);
                WriteLiteral("                </div>\r\n                <div class=\"col-2\">\r\n\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    Appointment Date :\r\n                </div>\r\n                <div class=\"col-3\">\r\n                    ");
                EndContext();
                BeginContext(1977, 103, false);
#line 50 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
               Write(Html.Editor("searchDate", new { htmlAttributes = new { @class = "form-control", @id = "datepicker" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2080, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2201, 816, true);
                WriteLiteral(@"                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-2"">
                </div>
                <div class=""col-3"">

                </div>
                <div class=""col-2"">

                </div>
                <div class=""col-2"">
                </div>
                <div class=""col-3"">
                    <button type=""submit"" name=""submit"" value=""Search"" class=""btn btn-primary form-control"">
                        <i class=""fas fa-search""></i> Search
                    </button>
                </div>
            </div>
        </div>
    </div>
    <br />
    <div>
        <table class=""table table-striped border"">
            <tr class=""table-info"">
                <th>
                    ");
                EndContext();
                BeginContext(3018, 74, false);
#line 78 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().SalesPerson.Name));

#line default
#line hidden
                EndContext();
                BeginContext(3092, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(3160, 73, false);
#line 81 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().AppointmentDate));

#line default
#line hidden
                EndContext();
                BeginContext(3233, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(3301, 70, false);
#line 84 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().CustomerName));

#line default
#line hidden
                EndContext();
                BeginContext(3371, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(3439, 71, false);
#line 87 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().CustomerEmail));

#line default
#line hidden
                EndContext();
                BeginContext(3510, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(3578, 77, false);
#line 90 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().CustomerPhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(3655, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(3723, 69, false);
#line 93 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().isComfirmed));

#line default
#line hidden
                EndContext();
                BeginContext(3792, 116, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n");
                EndContext();
#line 99 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
             foreach (var item in @Model.Appointments)
            {

#line default
#line hidden
                BeginContext(3979, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4052, 43, false);
#line 103 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.SalesPerson.Name));

#line default
#line hidden
                EndContext();
                BeginContext(4095, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4175, 42, false);
#line 106 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.AppointmentDate));

#line default
#line hidden
                EndContext();
                BeginContext(4217, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4297, 39, false);
#line 109 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerName));

#line default
#line hidden
                EndContext();
                BeginContext(4336, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4416, 40, false);
#line 112 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerEmail));

#line default
#line hidden
                EndContext();
                BeginContext(4456, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4536, 46, false);
#line 115 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerPhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(4582, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4662, 38, false);
#line 118 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
                   Write(Html.DisplayFor(m => item.isComfirmed));

#line default
#line hidden
                EndContext();
                BeginContext(4700, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4779, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f91b91671903fc238d1df6289164e8852ddd2b917435", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 121 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4833, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 124 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(4900, 40, true);
                WriteLiteral("        </table>\r\n    </div>\r\n    \r\n    ");
                EndContext();
                BeginContext(4940, 294, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f91b91671903fc238d1df6289164e8852ddd2b919572", async() => {
                    BeginContext(5220, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                }
                );
                __GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::GraniteHouse_MySQL.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper);
#line 128 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
__GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 130 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Areas\Admin\Views\Appointments\Index.cshtml"
__GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper.PageClassesEnable = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enable", __GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper.PageClassesEnable, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __GraniteHouse_MySQL_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5234, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5243, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5264, 279, true);
                WriteLiteral(@"
    <script>

        $(function() {
            $(""#datepicker"").datepicker({
                maxDate: ""+3M"",
                minDate: ""+1M"",
                showOtherMonths: true,
                selectOtherMonths: true
            });
        });

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GraniteHouse_MySQL.Models.ViewModel.AppointmentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
