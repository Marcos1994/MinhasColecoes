#pragma checksum "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4084558d0509c05d033bade8fa0d098aa4ba8dfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Colecao_Visualizar), @"mvc.1.0.view", @"/Views/Colecao/Visualizar.cshtml")]
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
#line 1 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\_ViewImports.cshtml"
using MinhasColecoes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\_ViewImports.cshtml"
using MinhasColecoes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
using MinhasColecoes.MinhasColecoesAPI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
using MinhasColecoes.MinhasColecoesAPI.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4084558d0509c05d033bade8fa0d098aa4ba8dfb", @"/Views/Colecao/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac95a78b42ec625fcf6434d9d6556263a04d17b", @"/Views/_ViewImports.cshtml")]
    public class Views_Colecao_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ColecaoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Colecao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Visualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadastroSubcolecao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary w-100 text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 100%; max-height: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top bg-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 120px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
  
	ViewData["Title"] = Model.Nome;
	

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
     if (Model.IdColecaoMaior != null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"d-flex\">\r\n\t\t\t<div class=\"d-flex flex-row-reverse\">\r\n");
#nullable restore
#line 14 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                   var c = Model.ColecaoMaior;
					do
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"pe-2\">\r\n");
#nullable restore
#line 18 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                             if (c.Publica || c.IdDono.ToString() == ViewBag.Usuario)
							{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4084558d0509c05d033bade8fa0d098aa4ba8dfb9638", async() => {
#nullable restore
#line 20 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                                          Write(c.Nome);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                           WriteLiteral(c.Id);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 20 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                                                          }
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-danger text-white btn-sm\">");
#nullable restore
#line 22 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                                    Write(c.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
#nullable restore
#line 22 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 24 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
						c = c.ColecaoPai;
					} while (c != null);
				

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"pe-2\"><h4>Subcoleção de</h4></div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 30 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"col-10 col-sm-11\">\r\n\t\t<div class=\"row col-12\">\r\n\t\t\t<h1 class=\"text-primary\">Coleção de ");
#nullable restore
#line 33 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                           Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t\t</div>\r\n");
#nullable restore
#line 35 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
         if (Model.Descricao != null && Model.Descricao.Length > 0)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"row col-12\">\r\n\t\t\t\t<p>");
#nullable restore
#line 38 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
              Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral(" asd</p>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 40 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n\t<div class=\"col-2 col-sm-1\">\r\n");
#nullable restore
#line 43 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
         if (Model.IdDono.ToString() == ViewBag.IdUsuario)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"d-flex flex-row-reverse justify-content-center justify-content-sm-start\">\r\n\t\t\t\t<input class=\"btn btn-sm btn-secondary\" type=\"button\" value=\"Editar\" />\r\n\t\t\t</div>\r\n");
#nullable restore
#line 48 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>\r\n\r\n<hr />\r\n");
            WriteLiteral("<p>\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-8 col-md-3 col-xxl-2\">\r\n\t\t\t<a class=\"btn btn-sm btn-primary w-100\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseSubcolecoes\" aria-expanded=\"false\" aria-controls=\"collapseSubcolecoes\">\r\n\t\t\t\t");
#nullable restore
#line 58 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
            Write(Model.Colecoes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Subcoleções\r\n\t\t\t</a>\r\n\t\t</div>\r\n");
#nullable restore
#line 61 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
         if (ViewBag.Usuario != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"col-4 col-md-2 col-xxl-1\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4084558d0509c05d033bade8fa0d098aa4ba8dfb16702", async() => {
                WriteLiteral("\r\n\t\t\t\t\tAdicionar ");
                WriteLiteral("\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 69 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</p>\r\n");
#nullable restore
#line 72 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
 if (Model.Colecoes.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"collapse\" id=\"collapseSubcolecoes\">\r\n\t\t<div class=\"row row-cols-2 row-cols-md-3 row-cols-lg-4 row-cols-xl-5 row-cols-xxl-6 g-3\">\r\n");
#nullable restore
#line 76 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
             foreach (ColecaoBasicViewModel c in Model.Colecoes)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t<div class=\"card h-100\">\r\n");
#nullable restore
#line 80 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                         if (!c.Publica)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<i class=\"bi-eye-slash-fill position-absolute end-0 p-2 text-primary\" title=\"Coleção particular\"\r\n\t\t\t\t\t\t\t   style=\"font-size: 20px; line-height: 20px;\"></i>\r\n");
#nullable restore
#line 84 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4084558d0509c05d033bade8fa0d098aa4ba8dfb21192", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4084558d0509c05d033bade8fa0d098aa4ba8dfb21462", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2807, "~/img/fotos/Colecao/", 2807, 20, true);
#nullable restore
#line 87 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
AddHtmlAttributeValue("", 2827, c.Foto, 2827, 9, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2836, ".jpg", 2836, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                                                           WriteLiteral(c.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t<h6 class=\"card-title truncate-2l text-center\">");
#nullable restore
#line 91 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                                       Write(c.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\t\t\t\t\t\t\t<p class=\"card-text truncate-3l\">");
#nullable restore
#line 92 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                         Write(c.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 96 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 99 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
            WriteLiteral("<p>\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-8 col-md-3 col-xxl-2\">\r\n\t\t\t<a class=\"btn btn-outline-primary btn-sm w-100\">\r\n\t\t\t\t");
#nullable restore
#line 107 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
            Write(Model.Itens.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Itens\r\n\t\t\t</a>\r\n\t\t</div>\r\n");
#nullable restore
#line 110 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
         if (ViewBag.Usuario != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"col-4 col-md-2 col-xxl-1\">\r\n\t\t\t\t<a class=\"btn btn-sm btn-secondary w-100 text-white\">\r\n\t\t\t\t\tAdicionar ");
            WriteLiteral("\r\n\t\t\t\t</a>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 117 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</p>\r\n");
#nullable restore
#line 120 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
 if (Model.Itens.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"row row-cols-2 row-cols-md-3 row-cols-lg-4 row-cols-xl-5 row-cols-xxl-6 g-3\">\r\n");
#nullable restore
#line 123 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
         foreach (ItemBasicViewModel i in Model.Itens)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"col\">\r\n\t\t\t\t<div class=\"card h-100\">\r\n\t\t\t\t\t<a href=\"#\" class=\"position-absolute end-0 p-2 text-primary\">\r\n");
#nullable restore
#line 128 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                         switch (i.Relacao)
						{
							case EnumRelacaoUsuarioItem.NaoPossuo:

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"bi-circle\" title=\"Não Possuo\"\r\n\t\t\t\t\t\t\t\t   style=\"font-size: 20px; line-height: 20px;\"></i>\r\n");
#nullable restore
#line 133 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
								break;
							case EnumRelacaoUsuarioItem.Desejo:

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"bi-heart\" title=\"Desejo\"\r\n\t\t\t\t\t\t\t\t   style=\"font-size: 20px; line-height: 20px;\"></i>\r\n");
#nullable restore
#line 137 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
								break;
							case EnumRelacaoUsuarioItem.AguardandoRecebimento:

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"bi-heart-half\" title=\"Aguardando Receber\"\r\n\t\t\t\t\t\t\t\t   style=\"font-size: 20px; line-height: 20px;\"></i>\r\n");
#nullable restore
#line 141 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
								break;
							case EnumRelacaoUsuarioItem.Possuo:

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"bi-heart-fill\" title=\"Possuo\"\r\n\t\t\t\t\t\t\t\t   style=\"font-size: 20px; line-height: 20px;\"></i>\r\n");
#nullable restore
#line 145 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
								break;
							case EnumRelacaoUsuarioItem.Trocar:

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"bi-arrow-left-right\" title=\"Tenho Para Trocar\"\r\n\t\t\t\t\t\t\t\t   style=\"font-size: 20px; line-height: 20px;\"></i>\r\n");
#nullable restore
#line 149 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
								break;
							case EnumRelacaoUsuarioItem.Vender:

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<i class=\"bi-currency-dollar\" title=\"Tenho Para Vender\"\r\n\t\t\t\t\t\t\t\t   style=\"font-size: 20px; line-height: 20px;\"></i>\r\n");
#nullable restore
#line 153 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
								break;
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</a>\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4084558d0509c05d033bade8fa0d098aa4ba8dfb31755", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4084558d0509c05d033bade8fa0d098aa4ba8dfb32023", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5219, "~/img/fotos/Item/", 5219, 17, true);
#nullable restore
#line 158 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
AddHtmlAttributeValue("", 5236, i.Foto, 5236, 9, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 5245, ".jpg", 5245, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 156 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                                                    WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-text truncate-2l text-center\">");
#nullable restore
#line 162 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                                                                  Write(i.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 164 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                     if (i.Comentario != null && i.Comentario.Length > 0)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"card-footer\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 167 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
                        Write(i.Comentario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 169 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 172 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n");
#nullable restore
#line 174 "F:\Projetos\MinhasColecoes\MinhasColecoes\MinhasColecoes\Views\Colecao\Visualizar.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ColecaoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
