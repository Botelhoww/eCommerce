#pragma checksum "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c34ff911f9ea86a76d2ad8fc799388f82a6f13e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Admin/ListaDeUsuarios.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c34ff911f9ea86a76d2ad8fc799388f82a6f13e", @"/Views/Admin/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92128fb403e95a7b6cb14b7fa992fc0b08814a91", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eCommerce_Inefavel.Models.UsuarioModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: #99B898;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
  
    ViewData["Title"] = "ListaDeUsuarios";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c34ff911f9ea86a76d2ad8fc799388f82a6f13e3901", async() => {
                WriteLiteral("\r\n    <script src=\"https://kit.fontawesome.com/a076d05399.js\"></script>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c34ff911f9ea86a76d2ad8fc799388f82a6f13e4946", async() => {
                WriteLiteral(@"

    <span style=""font-size: 25px; font-weight: 600;"">Lista de Usuários</span>

    <div style=""display: flex;"" class=""has-search2"">
        <span class=""fa fa-search form-control-feedback""></span>
        <input id=""myInput"" type=""text"" class=""form-control"" placeholder=""Pesquise por Código ou Nome do Usuário..."">
    </div>

    <table style=""background: white;"" class=""table"">
        <thead>
            <tr>
                <th style=""border-color: #355c7d;"">
                    Código do Usuário
                </th>
                <th style=""border-color: #355c7d;"">
                    ");
#nullable restore
#line 26 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
               Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th style=\"border-color: #355c7d;\">\r\n                    ");
#nullable restore
#line 29 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th style=\"border-color: #355c7d;\">\r\n                    ");
#nullable restore
#line 32 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
               Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th style=\"border-color: #355c7d;\">\r\n                    ");
#nullable restore
#line 35 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
               Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th style=\"border-color: #355c7d;\">\r\n                    Ações\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"myTable\">\r\n");
#nullable restore
#line 43 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td style=\"text-align: center;\">\r\n                        ");
#nullable restore
#line 47 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center;\">\r\n                        ");
#nullable restore
#line 50 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center;\">\r\n                        ");
#nullable restore
#line 53 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center;\">\r\n                        ");
#nullable restore
#line 56 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Senha));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center;\">\r\n                        ");
#nullable restore
#line 59 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center;\">\r\n                        <a class=\"icone-editar\"");
                BeginWriteAttribute("href", " href=\"", 2423, "\"", 2492, 1);
#nullable restore
#line 62 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 2430, Url.ActionLink("EditarUsuario","Admin", new { id = item.Id }), 2430, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-user-edit\"></i></a>\r\n                        <span style=\"color: #c5c5c5\">|</span>\r\n                        <a class=\"icone-remover\"");
                BeginWriteAttribute("href", " href=\"", 2643, "\"", 2713, 1);
#nullable restore
#line 64 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 2650, Url.ActionLink("RemoverUsuario","Admin", new { id = item.Id }), 2650, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-user-times\"></i></a>\r\n                        <span style=\"color: #c5c5c5\">|</span>\r\n                        <a class=\"icone-detalhes\"");
                BeginWriteAttribute("href", " href=\"", 2866, "\"", 2937, 1);
#nullable restore
#line 66 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 2873, Url.ActionLink("DetalhesUsuario","Admin", new { id = item.Id }), 2873, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-user-cog\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 69 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeUsuarios.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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

<script>
    $(document).ready(function () {
        $(""#myInput"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#myTable tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });
</script>

<style>
    th {
        background: #355C7D;
        color: white;
        text-align: center;
    }

    .icone-editar {
        color: cadetblue;
    }

    .icone-remover {
        color: tomato;
    }

    .icone-detalhes {
        color: #4d6dc5;
    }

    .icone-editar:hover {
        color: #337375;
    }

    .icone-remover:hover {
        color: #e24428;
    }

    .icone-detalhes:hover {
        color: #2852c7;
    }

    .has-search2 .form-control {
        padding-left: 85px;
        width: 40%;
    }

    .has-search2 .form-control-feedback {
        position: absolute;
        z-index: 2;
        display: block;
        w");
            WriteLiteral("idth: 4.375rem;\r\n        height: 2.375rem;\r\n        line-height: 2.375rem;\r\n        text-align: center;\r\n        pointer-events: none;\r\n        color: #aaa;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eCommerce_Inefavel.Models.UsuarioModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
