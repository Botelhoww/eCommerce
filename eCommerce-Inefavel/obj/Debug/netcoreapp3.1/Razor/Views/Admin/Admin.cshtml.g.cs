#pragma checksum "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1459ab0b5bca3c12d2f4cf85ec2e5ae8c2c36430"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Admin), @"mvc.1.0.view", @"/Views/Admin/Admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1459ab0b5bca3c12d2f4cf85ec2e5ae8c2c36430", @"/Views/Admin/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92128fb403e95a7b6cb14b7fa992fc0b08814a91", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #99B898;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\Admin.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"br\" dir=\"ltr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1459ab0b5bca3c12d2f4cf85ec2e5ae8c2c364303846", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <meta charset=\"utf-8\" />\r\n    <title>Página do Admin</title>\r\n    <script src=\"https://kit.fontawesome.com/a076d05399.js\"></script>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1459ab0b5bca3c12d2f4cf85ec2e5ae8c2c364305039", async() => {
                WriteLiteral("\r\n    <div class=\"sidebar\">\r\n        <header>Painel</header>\r\n        <ul style=\"text-align: center;\">\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 479, "\"", 521, 1);
#nullable restore
#line 17 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 486, Url.ActionLink("Index","Produtos"), 486, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fab fa-dashcube\"></i>Inicio</a></li>\r\n            <li></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 612, "\"", 662, 1);
#nullable restore
#line 19 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 619, Url.ActionLink("CadastrarProduto","Admin"), 619, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-tshirt\"></i>Adicionar Produto</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 739, "\"", 788, 1);
#nullable restore
#line 20 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 746, Url.ActionLink("ListaDeProdutos","Admin"), 746, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-stream\"></i>Lista de Produtos</a></li>\r\n            <li></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 888, "\"", 934, 1);
#nullable restore
#line 22 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 895, Url.ActionLink("Registrar","Registro"), 895, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-user-plus\"></i>Adicionar Usuário</a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 1014, "\"", 1063, 1);
#nullable restore
#line 23 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 1021, Url.ActionLink("ListaDeUsuarios","Admin"), 1021, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-stream\"></i>Lista de Usuários</a></li>\r\n\r\n        </ul>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<style>
    * {
        list-style: none;
        margin: 0;
        padding: 0;
        text-decoration: none;
    }

    .sidebar {
        /*position: fixed;*/
        /*left: 0;*/
        /*width: 270px;*/
        height: 100%;
        background-color: white;
    }

        .sidebar header {
            font-size: 22px;
            color: white;
            text-align: center;
            line-height: 70px;
            background: #355C7D;
            user-select: none;
        }

        .sidebar ul a {
            display: block;
            height: 100%;
            width: 100%;
            line-height: 65px;
            font-size: 20px;
            color: #4e4e4e;
            /*padding-left: 40px;*/
            box-sizing: border-box;
            border-top: 1px solid rgba(255,255,255, .1);
            border-bottom: 1px solid black;
            transition: .4s;
            text-decoration: none;
        }

    ul li:hover a {
        padding-left");
            WriteLiteral(": 10px;\r\n    }\r\n\r\n    .sidebar ul a i {\r\n        margin-right: 16px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
