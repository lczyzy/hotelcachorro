#pragma checksum "C:\Users\lcz-x\Desktop\auaudog\hotelcachorro\EcommerceAngelo\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bbc9c2a755c59adf9250d2a165bc3968beeea24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
#line 1 "C:\Users\lcz-x\Desktop\auaudog\hotelcachorro\EcommerceAngelo\Views\_ViewImports.cshtml"
using EcommerceAngelo;

#line default
#line hidden
#line 2 "C:\Users\lcz-x\Desktop\auaudog\hotelcachorro\EcommerceAngelo\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbc9c2a755c59adf9250d2a165bc3968beeea24", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12781d2c1073e9825f828d99aa78672d830f45c", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lcz-x\Desktop\auaudog\hotelcachorro\EcommerceAngelo\Views\Usuario\Index.cshtml"
  
    DateTime dataHora = ViewBag.DataHora;

#line default
#line hidden
            BeginContext(72, 38, true);
            WriteLiteral("\r\n<h2>Gerenciamento de Usuários</h2>\r\n");
            EndContext();
            BeginContext(110, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "989104d3a0b44ce6bfa9c04146865de7", async() => {
                BeginContext(157, 17, true);
                WriteLiteral("Cadastrar Usuário");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(178, 283, true);
            WriteLiteral(@"

<table style=""margin-bottom:15px;margin-top:15px""
       class=""table table-hover table-striped"">
    <thead>
        <tr class=""table-active"">
            <th>E-mail</th>
            <th>Senha</th>
            <th>Criado em</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\lcz-x\Desktop\auaudog\hotelcachorro\EcommerceAngelo\Views\Usuario\Index.cshtml"
         foreach (Usuario item in Model)
        {

#line default
#line hidden
            BeginContext(514, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(553, 10, false);
#line 22 "C:\Users\lcz-x\Desktop\auaudog\hotelcachorro\EcommerceAngelo\Views\Usuario\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(563, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(591, 10, false);
#line 23 "C:\Users\lcz-x\Desktop\auaudog\hotelcachorro\EcommerceAngelo\Views\Usuario\Index.cshtml"
               Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(601, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(629, 13, false);
#line 24 "C:\Users\lcz-x\Desktop\auaudog\hotelcachorro\EcommerceAngelo\Views\Usuario\Index.cshtml"
               Write(item.CriadoEm);

#line default
#line hidden
            EndContext();
            BeginContext(642, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\lcz-x\Desktop\auaudog\hotelcachorro\EcommerceAngelo\Views\Usuario\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(679, 63, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<p>\r\n    <b>Dados atualizados em: </b> ");
            EndContext();
            BeginContext(743, 8, false);
#line 30 "C:\Users\lcz-x\Desktop\auaudog\hotelcachorro\EcommerceAngelo\Views\Usuario\Index.cshtml"
                             Write(dataHora);

#line default
#line hidden
            EndContext();
            BeginContext(751, 6, true);
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
