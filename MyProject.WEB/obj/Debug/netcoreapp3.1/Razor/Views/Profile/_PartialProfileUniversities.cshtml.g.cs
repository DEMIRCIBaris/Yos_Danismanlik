#pragma checksum "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e297a4c38d5eee3728d5910f7ba813fd1a422a38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile__PartialProfileUniversities), @"mvc.1.0.view", @"/Views/Profile/_PartialProfileUniversities.cshtml")]
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
#line 2 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\_ViewImports.cshtml"
using MyProject.Entities.DTO.AppUserDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\_ViewImports.cshtml"
using MyProject.Entities.DTO.YosQuestionsDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\_ViewImports.cshtml"
using MyProject.Entities.DTO.YosQuotaDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\_ViewImports.cshtml"
using MyProject.Entities.DTO.BasePointDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\_ViewImports.cshtml"
using MyProject.Entities.DTO.UniversityDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\_ViewImports.cshtml"
using MyProject.Entities.DTO.UniversityTypeDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\_ViewImports.cshtml"
using MyProject.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e297a4c38d5eee3728d5910f7ba813fd1a422a38", @"/Views/Profile/_PartialProfileUniversities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2acc3b879e8c8618436616faa6231eece55d342b", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile__PartialProfileUniversities : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetViewModelUniversity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"myscroll\">\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-danger\"><i class=\"fas fa-times mr-2\"></i> Herhangi bir üniversite bulunamamıştır</p>\r\n");
#nullable restore
#line 7 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
    }
    else
    {
       

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-light table-bordered table-striped table-xs table-hover border-top-0"">
            <thead>
                <tr>
                    <th style=""position:sticky;top:0;background-color:#E9E8E6"" class=""border-top-0 text-center"">Üniversite Logosu</th>
                    <th style=""position:sticky;top:0;background-color:#E9E8E6"" class=""border-top-0 text-center"">Üniversite Adı</th>
                    <th style=""position:sticky;top:0;background-color:#E9E8E6"" class=""border-top-0 text-center"">Şehir</th>
                    <th style=""position:sticky;top:0;background-color:#E9E8E6"" class=""border-top-0 text-center"">Başvuru Tarihi</th>
                    <th style=""position:sticky;top:0;background-color:#E9E8E6"" class=""border-top-0 text-center"">Sınav Tarihi</th>
                    <th style=""position:sticky;top:0;background-color:#E9E8E6"" class=""border-top-0 text-center"">Sonuç Tarihi</th>
                    <th style=""position:sticky;top:0;background-color:#E9E8E6"" class=""b");
            WriteLiteral("order-top-0 text-center\"></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody class=\"my-auto\">\r\n");
#nullable restore
#line 24 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                 foreach (var type in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle text-center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e297a4c38d5eee3728d5910f7ba813fd1a422a387589", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1595, "~/Image/", 1595, 8, true);
#nullable restore
#line 28 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
AddHtmlAttributeValue("", 1603, type.PictureUrl, 1603, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle text-center\">");
#nullable restore
#line 30 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                                                        Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle text-center\">");
#nullable restore
#line 31 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                                                        Write(type.City.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle text-center\">");
#nullable restore
#line 32 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                                                        Write(type.BasvuruTarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle text-center\">");
#nullable restore
#line 33 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                                                        Write(type.SinavTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle text-center\">");
#nullable restore
#line 34 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                                                        Write(type.SonucTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle text-center\">\r\n");
#nullable restore
#line 36 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                             if (type.IsAdded)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"btn btn-danger btn-sm my-1 deleteButton\" data-id=\"");
#nullable restore
#line 38 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                                                                                            Write(type.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-ban mr-2\"></i>Çıkar</button>\r\n");
#nullable restore
#line 39 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"btn btn-primary btn-sm my-1 addButton\" data-id=\"");
#nullable restore
#line 42 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                                                                                          Write(type.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-edit mr-2\"></i>Ekle</button>\r\n");
#nullable restore
#line 43 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 49 "C:\Users\Barış DEMİRCİ\Desktop\MyProject\MyProject.WEB\Views\Profile\_PartialProfileUniversities.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetViewModelUniversity>> Html { get; private set; }
    }
}
#pragma warning restore 1591