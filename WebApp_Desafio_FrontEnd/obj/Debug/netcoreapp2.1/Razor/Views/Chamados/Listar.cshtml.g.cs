#pragma checksum "C:\Users\sandr\Downloads\wedappdesafio-main\wedappdesafio-main\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_FrontEnd\Views\Chamados\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cdde9ff74bcee572e66043a88e1fe0da44df8cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chamados_Listar), @"mvc.1.0.view", @"/Views/Chamados/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chamados/Listar.cshtml", typeof(AspNetCore.Views_Chamados_Listar))]
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
#line 1 "C:\Users\sandr\Downloads\wedappdesafio-main\wedappdesafio-main\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_FrontEnd\Views\_ViewImports.cshtml"
using WebApp_Desafio_FrontEnd;

#line default
#line hidden
#line 2 "C:\Users\sandr\Downloads\wedappdesafio-main\wedappdesafio-main\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_FrontEnd\Views\_ViewImports.cshtml"
using WebApp_Desafio_FrontEnd.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cdde9ff74bcee572e66043a88e1fe0da44df8cb", @"/Views/Chamados/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccfc0317c88268e3c5c18af6d6013c67a1807f57", @"/Views/_ViewImports.cshtml")]
    public class Views_Chamados_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp_Desafio_FrontEnd.ViewModels.ChamadoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert2/sweetalert2.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Chamados/Listar.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\sandr\Downloads\wedappdesafio-main\wedappdesafio-main\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_FrontEnd\Views\Chamados\Listar.cshtml"
  
    ViewData["Title"] = "Chamados";

#line default
#line hidden
            BeginContext(106, 26, true);
            WriteLiteral("\r\n<div class=\"row mt-3\">\r\n");
            EndContext();
            BeginContext(263, 948, true);
            WriteLiteral(@"    <div class=""col-lg-6 text-left"">
        <button type=""button"" class=""btn btn-outline btn-primary"" id=""btnRelatorio"">
            <i class=""fa fa-file-pdf-o""></i> Relatório
        </button>
    </div>
    <div class=""col-lg-6 text-right"">
        <button type=""button"" class=""btn btn-outline btn-primary"" id=""btnAdicionar"">
            <i class=""fa fa-plus""></i> Adicionar
        </button>
        <button type=""button"" class=""btn btn-outline btn-primary"" id=""btnEditar"">
            <i class=""fa fa-pencil""></i> Editar
        </button>
        <button type=""button"" class=""btn btn-outline btn-danger"" id=""btnExcluir"">
            <i class=""fa fa-trash""></i> Excluir
        </button>
    </div>
</div>

<div class=""row mt-3"">
    <div class=""col-lg-12"">

        <table class=""table table-striped table-bordered table-hover"" id=""dataTables-Chamados"">
            <thead>
                <tr>
                    <th>");
            EndContext();
            BeginContext(1212, 38, false);
#line 33 "C:\Users\sandr\Downloads\wedappdesafio-main\wedappdesafio-main\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_FrontEnd\Views\Chamados\Listar.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1282, 43, false);
#line 34 "C:\Users\sandr\Downloads\wedappdesafio-main\wedappdesafio-main\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_FrontEnd\Views\Chamados\Listar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Assunto));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1357, 47, false);
#line 35 "C:\Users\sandr\Downloads\wedappdesafio-main\wedappdesafio-main\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_FrontEnd\Views\Chamados\Listar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Solicitante));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1436, 48, false);
#line 36 "C:\Users\sandr\Downloads\wedappdesafio-main\wedappdesafio-main\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_FrontEnd\Views\Chamados\Listar.cshtml"
                   Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1516, 48, false);
#line 37 "C:\Users\sandr\Downloads\wedappdesafio-main\wedappdesafio-main\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_FrontEnd\Views\Chamados\Listar.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataAbertura));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 137, true);
            WriteLiteral("</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(1720, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1726, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2cdde9ff74bcee572e66043a88e1fe0da44df8cb9494", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1796, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1801, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1823, 32, true);
                WriteLiteral("\r\n    <!-- SweetAlert2 -->\r\n    ");
                EndContext();
                BeginContext(1855, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cdde9ff74bcee572e66043a88e1fe0da44df8cb11159", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1919, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1927, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cdde9ff74bcee572e66043a88e1fe0da44df8cb12419", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 57 "C:\Users\sandr\Downloads\wedappdesafio-main\wedappdesafio-main\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_Desenvolvimento\WebApp_Desafio_FrontEnd\Views\Chamados\Listar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2000, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp_Desafio_FrontEnd.ViewModels.ChamadoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
