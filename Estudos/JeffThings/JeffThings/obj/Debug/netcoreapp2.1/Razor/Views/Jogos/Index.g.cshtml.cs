#pragma checksum "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "205b4b55b6a8176d67aa69f21f6b77b702d9f229"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jogos_Index), @"mvc.1.0.view", @"/Views/Jogos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jogos/Index.cshtml", typeof(AspNetCore.Views_Jogos_Index))]
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
#line 1 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\_ViewImports.cshtml"
using JeffThings;

#line default
#line hidden
#line 2 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\_ViewImports.cshtml"
using JeffThings.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"205b4b55b6a8176d67aa69f21f6b77b702d9f229", @"/Views/Jogos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2388e45a860fd8422bf964aaa63854f0f2d8555", @"/Views/_ViewImports.cshtml")]
    public class Views_Jogos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JeffThings.Domains.Jogos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(165, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "787a9acb13ea4086ba0a90eb7ba44bf3", async() => {
                BeginContext(188, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(202, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(295, 40, false);
#line 17 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(335, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(391, 50, false);
#line 20 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataLancamento));

#line default
#line hidden
            EndContext();
            BeginContext(441, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(497, 45, false);
#line 23 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(542, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(598, 41, false);
#line 26 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(639, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(695, 40, false);
#line 29 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Coop));

#line default
#line hidden
            EndContext();
            BeginContext(735, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(791, 46, false);
#line 32 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TiposJogos));

#line default
#line hidden
            EndContext();
            BeginContext(837, 94, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <p>\r\n                    TEMPO PARADO\r\n");
            EndContext();
            BeginContext(1016, 106, true);
            WriteLiteral("                </p>\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1154, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1203, 39, false);
#line 47 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1298, 49, false);
#line 50 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataLancamento));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1403, 44, false);
#line 53 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1503, 40, false);
#line 56 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1599, 39, false);
#line 59 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Coop));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1694, 50, false);
#line 62 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TiposJogos.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 65 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
                  
                    var dataFim = DateTime.Now;
                    var dataInicio = new DateTime(2019, 11, 6, 16, 40, 00);
                    var diferenca = dataFim.Subtract(dataInicio);
                    //var res = String.Format("{00}:{11}:{22}", diff.Hours,diff.Minutes,diff.Seconds);
                    var resultado = diferenca.ToString(@"hh\:mm\:ss");
                    //DateTime a = new DateTime(2019, 11, 6, 16, 40, 00);
                    //var a = new DateTime().Now;
                    //DateTime b = new DateTime(2019, 11, 6, 17, 50, 00);
                    //DateTime resultado = b.Subtract(a);

#line default
#line hidden
            BeginContext(2432, 25, true);
            WriteLiteral("                    <p>\r\n");
            EndContext();
            BeginContext(2525, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2550, 9, false);
#line 77 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
                   Write(resultado);

#line default
#line hidden
            EndContext();
            BeginContext(2559, 30, true);
            WriteLiteral("\r\n                    </p>  \r\n");
            EndContext();
            BeginContext(2608, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2661, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17ceaa42a9c74c68b991768b931a8da8", async() => {
                BeginContext(2706, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(2714, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2734, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf852eceaf7a47538f8fa534ed6149fd", async() => {
                BeginContext(2782, 7, true);
                WriteLiteral("Details");
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
#line 83 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(2793, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2813, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d33ca3e00036420eb2ccfea9ebdcdb5d", async() => {
                BeginContext(2860, 6, true);
                WriteLiteral("Delete");
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
#line 84 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(2870, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 87 "C:\Users\ccgm1\Documents\Jefferson\CURSO\SAEP\Code\Saep-Treinamento\Estudos\JeffThings\JeffThings\Views\Jogos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2909, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JeffThings.Domains.Jogos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
