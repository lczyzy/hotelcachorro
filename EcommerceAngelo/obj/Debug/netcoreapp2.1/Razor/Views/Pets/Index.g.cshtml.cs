#pragma checksum "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8174814f1e3ab6b93efe8293538de82be6dca82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_Index), @"mvc.1.0.view", @"/Views/Pets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pets/Index.cshtml", typeof(AspNetCore.Views_Pets_Index))]
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
#line 1 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\_ViewImports.cshtml"
using EcommerceAngelo;

#line default
#line hidden
#line 2 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8174814f1e3ab6b93efe8293538de82be6dca82", @"/Views/Pets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b82787046c3e52aea3345accd86da13882ba60f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Pets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Pet>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alterar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(95, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f070b5a511c44a78b352a0416b9d745", async() => {
                BeginContext(121, 10, true);
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
            BeginContext(135, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(222, 40, false);
#line 16 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(262, 53, true);
            WriteLiteral("\n            </th>\n\n            <th>\n                ");
            EndContext();
            BeginContext(316, 47, false);
#line 20 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cliente.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(363, 53, true);
            WriteLiteral("\n            </th>\n\n            <th>\n                ");
            EndContext();
            BeginContext(417, 42, false);
#line 24 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Imagem));

#line default
#line hidden
            EndContext();
            BeginContext(459, 53, true);
            WriteLiteral("\n            </th>\n\n            <th>\n                ");
            EndContext();
            BeginContext(513, 40, false);
#line 28 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Raca));

#line default
#line hidden
            EndContext();
            BeginContext(553, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(606, 45, false);
#line 31 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Castragem));

#line default
#line hidden
            EndContext();
            BeginContext(651, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(704, 43, false);
#line 34 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pelagem));

#line default
#line hidden
            EndContext();
            BeginContext(747, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(800, 41, false);
#line 37 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(841, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(894, 41, false);
#line 40 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Porte));

#line default
#line hidden
            EndContext();
            BeginContext(935, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(988, 40, false);
#line 43 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Peso));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 49 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1139, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1186, 39, false);
#line 52 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 53, true);
            WriteLiteral("\n            </td>\n\n            <td>\n                ");
            EndContext();
            BeginContext(1279, 46, false);
#line 56 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cliente.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 53, true);
            WriteLiteral("\n            </td>\n\n            <td>\n                ");
            EndContext();
            BeginContext(1378, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f2d9c7f93bf1468899092b181230a3b7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1388, "~/ecommerceimagens/", 1388, 19, true);
#line 60 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
AddHtmlAttributeValue("", 1407, item.Imagem, 1407, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1505, 53, true);
            WriteLiteral("\n            </td>\n\n            <td>\n                ");
            EndContext();
            BeginContext(1559, 39, false);
#line 66 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Raca));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1651, 44, false);
#line 69 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Castragem));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1748, 42, false);
#line 72 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pelagem));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1843, 40, false);
#line 75 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1936, 40, false);
#line 78 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Porte));

#line default
#line hidden
            EndContext();
            BeginContext(1976, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2029, 39, false);
#line 81 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Peso));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2120, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74d8007cf93c46b08fb1099876ff5b7e", async() => {
                BeginContext(2171, 4, true);
                WriteLiteral("Edit");
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
#line 84 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
                                          WriteLiteral(item.IdPet);

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
            BeginContext(2179, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2198, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31f1585d3fb345b3b4628e04e7d1dbcd", async() => {
                BeginContext(2249, 6, true);
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
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
                                          WriteLiteral(item.IdPet);

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
            BeginContext(2259, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 88 "C:\Users\lcz-x\Desktop\auauaudog\hotelcachorro-new_07_02_web\EcommerceAngelo\Views\Pets\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2294, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Pet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
