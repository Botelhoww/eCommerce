#pragma checksum "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "775f6ebb6c21aff61694c82f55dbc9ad56af8c21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Index), @"mvc.1.0.view", @"/Views/Produtos/Index.cshtml")]
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
#line 1 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\_ViewImports.cshtml"
using eCommerce_Inefavel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\_ViewImports.cshtml"
using eCommerce_Inefavel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775f6ebb6c21aff61694c82f55dbc9ad56af8c21", @"/Views/Produtos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92128fb403e95a7b6cb14b7fa992fc0b08814a91", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eCommerce_Inefavel.Models.ProdutosModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Produto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("align-self: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/infos.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Tarjaa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "775f6ebb6c21aff61694c82f55dbc9ad56af8c215722", async() => {
                WriteLiteral("\r\n    <link href=\"https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@1,900&display=swap\" rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"div-ultimos-lancamentos\">\r\n    <p class=\"titulo-ultimos-lancamentos\"> Últimos Lançamentos </p>\r\n</div>\r\n\r\n<div class=\"Cards\">\r\n");
#nullable restore
#line 15 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
     foreach (var item in ViewBag.produtos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a style=\"text-decoration: none; color: #000\"");
            BeginWriteAttribute("href", " href=\"", 631, "\"", 694, 1);
#nullable restore
#line 17 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
WriteAttributeValue("", 638, Url.Action("Detalhe", "Produtos", new { id = item.Id }), 638, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            <div class=\"Card\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "775f6ebb6c21aff61694c82f55dbc9ad56af8c217737", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/produtos_img/");
#nullable restore
#line 20 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
                             WriteLiteral(item.ImagePath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 24 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <div class=\"Title\">\r\n                    <span class=\"titulo-uppercase\">");
#nullable restore
#line 27 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
                                              Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n\r\n                <div class=\"Valor\" style=\"text-align: center\">\r\n                    <span>R$ ");
#nullable restore
#line 31 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
                        Write(item.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 35 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"span12 banner tarja\">\r\n    <a href=\"#\" target=\"_self\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "775f6ebb6c21aff61694c82f55dbc9ad56af8c2111556", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </a>\r\n</div>\r\n\r\n<div style=\"padding-top: 40px;\" class=\"Cards1\">\r\n");
#nullable restore
#line 45 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
     foreach (var item in ViewBag.produtos2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a style=\"text-decoration: none; color: #000\"");
            BeginWriteAttribute("href", " href=\"", 1593, "\"", 1656, 1);
#nullable restore
#line 47 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
WriteAttributeValue("", 1600, Url.Action("Detalhe", "Produtos", new { id = item.Id }), 1600, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n            <div class=\"Card\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "775f6ebb6c21aff61694c82f55dbc9ad56af8c2113524", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/produtos_img/");
#nullable restore
#line 50 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
                             WriteLiteral(item.ImagePath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 54 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <div class=\"Title\">\r\n                    <span class=\"titulo-uppercase\">");
#nullable restore
#line 57 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
                                              Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n\r\n                <div class=\"Valor1\" style=\"text-align: center\">\r\n                    <span>R$ ");
#nullable restore
#line 61 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
                        Write(item.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 65 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<style>
    .div-ultimos-lancamentos {
        background: black;
        color: white;
        height: 40px;
    }

    .titulo-ultimos-lancamentos {
        font-size: 25px;
        font-weight: 700;
        padding-left: 20px;
        padding-top: 3px;
        font-family: 'Montserrat', sans-serif;
    }

    .tarja * {
        color: #fff;
        flex: 1;
        display: flex;
        justify-content: center;
        padding-top: 3px;
    }

    .titulo-uppercase {
        text-transform: uppercase;
    }

    .Cards1 {
        display: flex;
        justify-content: center;
        flex-wrap: wrap;
        background: #eee;
    }

    .Cards {
        display: flex;
        justify-content: center;
        flex-wrap: wrap;
        background: #fff;
    }

    .Card {
        overflow: hidden;
        margin: 10px;
        display: flex;
        flex-direction: column;
        max-width: 500px;
        min-width: 300px;
    }

        .Card .Ti");
            WriteLiteral(@"tle {
            padding: 5px 0px;
            display: flex;
            justify-content: center;
            max-width: 300px;
            text-align-last: center;
            text-align: center;
            color: #484848;
            font-weight: 600;
        }

        .Card .Content {
            flex: 1;
            background-color: white;
            color: black;
            padding: 20px;
            text-align: center;
        }

        .Card .Valor {
            flex: 1;
            color: #6d6d6d;
            padding: 20px;
            font-weight: 500;
            font-size: 18px;
        }

        .Card .Valor1 {
            flex: 1;
            color: #6d6d6d;
            padding: 20px;
            font-weight: 500;
            font-size: 18px;
        }
</style>

");
#nullable restore
#line 154 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
  
    if (this.Context.Session.GetString("isFiltered") != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\"btnEntrar\").style.display = \"none\";\r\n            document.getElementById(\"btnReg\").style.display = \"none\";\r\n        </script>\r\n");
#nullable restore
#line 161 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\"btnLogout\").style.display = \"none\";\r\n            document.getElementById(\"nomeUsuario\").style.display = \"none\";\r\n        </script>\r\n");
#nullable restore
#line 168 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Produtos\Index.cshtml"
    };

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eCommerce_Inefavel.Models.ProdutosModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
