#pragma checksum "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abd1f3dd1ed0ecaf1dc420e828f1af57cd3f2f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListaDeProdutos), @"mvc.1.0.view", @"/Views/Admin/ListaDeProdutos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abd1f3dd1ed0ecaf1dc420e828f1af57cd3f2f78", @"/Views/Admin/ListaDeProdutos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92128fb403e95a7b6cb14b7fa992fc0b08814a91", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListaDeProdutos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eCommerce_Inefavel.Models.ProdutosModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadastrarProduto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Produto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("120"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("align-self: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #99B898;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
  
    ViewData["Title"] = "ListaDeProdutos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<span style=\"font-size: 25px; font-weight: 600;\">Lista dos Produtos</span>\r\n<span class=\"span-aviso\">*produtos ativos na loja*</span>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abd1f3dd1ed0ecaf1dc420e828f1af57cd3f2f786877", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abd1f3dd1ed0ecaf1dc420e828f1af57cd3f2f787922", async() => {
                WriteLiteral("\r\n\r\n    <div style=\"display: flex;\" class=\"has-search2\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abd1f3dd1ed0ecaf1dc420e828f1af57cd3f2f788252", async() => {
                    WriteLiteral("Cadastrar Novo Produto");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        <span class=""fa fa-search form-control-feedback""></span>
        <input id=""myInput"" type=""text"" class=""form-control"" placeholder=""Pesquise por Código ou Nome do Produto..."">
    </div>

    <table style=""background: white;"" class=""table"">
        <thead>
            <tr>
                <th style=""border-color: #355c7d;"">
                    Código do Produto
                </th>
                <th style=""border-color: #355c7d;"">
                    Imagem do Produto
                </th>
                <th style=""border-color: #355c7d;"">
                    Titulo do Produto
                </th>
                <th style=""border-color: #355c7d;"">
                    Preço
                </th>
                <th style=""border-color: #355c7d;"">
                    Ações
                </th>
            </tr>
        </thead>
        <tbody id=""myTable"">
");
#nullable restore
#line 44 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td class=\"text-uppercase\" style=\"padding-top: 5%;\">\r\n                        ");
#nullable restore
#line 48 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1768, "\"", 1831, 1);
#nullable restore
#line 51 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
WriteAttributeValue("", 1775, Url.Action("Detalhe", "Produtos", new { id = item.Id }), 1775, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "abd1f3dd1ed0ecaf1dc420e828f1af57cd3f2f7811930", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral("~/produtos_img/");
#nullable restore
#line 52 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
                                         WriteLiteral(item.ImagePath);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 56 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
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
                WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                    <td class=\"text-uppercase\" style=\"padding-top: 5%;\">\r\n                        ");
#nullable restore
#line 60 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td style=\"padding-top: 5%;\">\r\n                        ");
#nullable restore
#line 63 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td style=\"padding-top: 5%;\">\r\n                        <a class=\"icone-editar\"");
                BeginWriteAttribute("href", " href=\"", 2607, "\"", 2676, 1);
#nullable restore
#line 66 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
WriteAttributeValue("", 2614, Url.ActionLink("EditarProduto","Admin", new { id = item.Id }), 2614, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                        <span style=\"color: #c5c5c5\">|</span>\r\n                        <a class=\"icone-remover\"");
                BeginWriteAttribute("href", " href=\"", 2822, "\"", 2892, 1);
#nullable restore
#line 68 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
WriteAttributeValue("", 2829, Url.ActionLink("RemoverProduto","Admin", new { id = item.Id }), 2829, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-trash\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 71 "D:\source\repos\eCommerce-Inefavel\eCommerce-Inefavel\Views\Admin\ListaDeProdutos.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
    td {
        text-align: center;
        font-weight: 600;
    }

    th {
        background: #355C7D;
        color: white;
        text-align: center;
    }

    .span-aviso {
        display: flex;
        font-size: 14px;
        color: gray;
        justify-content: flex-end;
    }

    .icone-editar {
        color: cadetblue;
    }

    .icone-remover {
        color: tomato;
    }

    .icone-editar:hover {
        color: #337375;
    }

    .icone-remover:hover {
        color: #e24428;
    }

    .has-search2 .form-control {
        padding-left: 55px;
        width: 40%;
        margin-left: 468px;
    }

    .has-search2 .form-control-feedback {
        position: absolute;
        z-index: 2;
        display: block;
        width: 4.375rem;
        height: 2.375rem;
        line-height: 2.375rem;
        text-align: center;
        pointer-events: none;
        color: #aaa;
        padding-left: 36%;
    }

    ::-webkit-input-");
            WriteLiteral(@"placeholder {
        font-family: 'Roboto', sans-serif;
        opacity: 0.5;
    }
</style>

<script>
    $(document).ready(function () {
        $(""#myInput"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#myTable tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eCommerce_Inefavel.Models.ProdutosModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591