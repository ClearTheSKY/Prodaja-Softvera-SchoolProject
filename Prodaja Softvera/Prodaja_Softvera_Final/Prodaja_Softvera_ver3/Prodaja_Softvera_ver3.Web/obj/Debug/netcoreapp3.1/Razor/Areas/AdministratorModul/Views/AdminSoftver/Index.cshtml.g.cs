#pragma checksum "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85bfe99fabf307765685fd37a17dfa7c5b2c2099"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministratorModul_Views_AdminSoftver_Index), @"mvc.1.0.view", @"/Areas/AdministratorModul/Views/AdminSoftver/Index.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\_ViewImports.cshtml"
using Prodaja_Softvera_ver3.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\_ViewImports.cshtml"
using Prodaja_Softvera_ver3.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
using Prodaja_Softvera_ver3.Web.Areas.AdministratorModul.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85bfe99fabf307765685fd37a17dfa7c5b2c2099", @"/Areas/AdministratorModul/Views/AdminSoftver/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1020a9d58bfb8df98d3c5a402938537697a2c9c", @"/Areas/AdministratorModul/Views/_ViewImports.cshtml")]
    public class Areas_AdministratorModul_Views_AdminSoftver_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cloudscribe.Pagination.Models.PagedResult<SoftverIndexVM.Row>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Obrisi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminSoftver", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AdministratorModul", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalji", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PaginationPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Controller"] = "AdminSoftver";
    ViewData["Action"] = "Index";

    var porukaSuccess = (string)TempData["porukaSuccess"];
    var porukaWarning = (string)TempData["porukaWarning"];
    var porukaError = (string)TempData["porukaError"];

    Layout = "~/Areas/AdministratorModul/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div class=\"content-wrapper p-4\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
         if (porukaError != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\" id=\"porukaBox\">\r\n                ");
#nullable restore
#line 24 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
           Write(porukaError);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
         if (porukaWarning != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning\" role=\"alert\" id=\"porukaBox\">\r\n                ");
#nullable restore
#line 31 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
           Write(porukaWarning);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
         if (porukaSuccess != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success\" role=\"alert\" id=\"porukaBox\">\r\n                ");
#nullable restore
#line 38 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
           Write(porukaSuccess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 40 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        <p class=\"h1\">Prikaz softvera:</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85bfe99fabf307765685fd37a17dfa7c5b2c209911888", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-5"">
                    <input name=""pretragaString"" class=""form-control"" placeholder=""Unesite naziv softvera"" />
                </div>
                <div class=""col-md-2"">
                    <button style=""width:50px"" class=""btn btn-primary""><i class=""fa fa-search""></i></button>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85bfe99fabf307765685fd37a17dfa7c5b2c209912540", async() => {
                    WriteLiteral("\r\n                        <i class=\"fa fa-times-circle\"></i>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <br /><br />\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


        <table class=""table table-striped border"">
            <thead class=""thead-dark"">
                <tr>
                    <th> Naziv </th>
                    <th> Verzija </th>
                    <th> Cijena </th>
                    <th> Tip softvera </th>
                    <th> Specifikacije </th>
                    <th> Akcija </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 73 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                 foreach (var x in Model.Data)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 76 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                       Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 77 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                       Write(x.Verzija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 78 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                       Write(x.Cijena);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM</td>\r\n                        <td>\r\n");
#nullable restore
#line 80 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                             if (x.TipSoftvera == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label>Nema zapisa</label>\r\n");
#nullable restore
#line 83 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label>");
#nullable restore
#line 86 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                                  Write(x.TipSoftvera);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 87 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 90 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                             if (x.Specifikacija == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label>Nema zapisa</label>\r\n");
#nullable restore
#line 93 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <label>");
#nullable restore
#line 96 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                                  Write(x.Specifikacija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 97 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n\r\n\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85bfe99fabf307765685fd37a17dfa7c5b2c209920392", async() => {
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                                                                                                                 WriteLiteral(x.SoftverID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <br /><br />\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85bfe99fabf307765685fd37a17dfa7c5b2c209923309", async() => {
                WriteLiteral("<i class=\"fa fa-info\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                                                                                                                  WriteLiteral(x.SoftverID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 107 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85bfe99fabf307765685fd37a17dfa7c5b2c209926584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 110 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 110 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\AdminSoftver\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cloudscribe.Pagination.Models.PagedResult<SoftverIndexVM.Row>> Html { get; private set; }
    }
}
#pragma warning restore 1591
