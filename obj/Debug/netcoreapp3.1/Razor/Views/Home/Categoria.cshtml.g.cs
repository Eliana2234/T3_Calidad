#pragma checksum "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "296dfff851f8da1cf719918c16ba839c2e9ebd7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Categoria), @"mvc.1.0.view", @"/Views/Home/Categoria.cshtml")]
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
#line 1 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\_ViewImports.cshtml"
using T3ESOT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\_ViewImports.cshtml"
using T3ESOT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296dfff851f8da1cf719918c16ba839c2e9ebd7b", @"/Views/Home/Categoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764cfbb013da26ca3b327c97306fe94efa3c98b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Categoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex me-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("compartirf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("CompartirForm(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Compartir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
   var nota = (List<EtiquetaNota>)Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296dfff851f8da1cf719918c16ba839c2e9ebd7b6583", async() => {
                WriteLiteral(@"
    <div class=""input-group"">
        <input class=""form-control me-2"" id=""Nombre"" type=""search"" name=""search"" placeholder=""Search for..."" aria-label=""Search for..."" aria-describedby=""btnNavbarSearch"" />
        <button class=""btn btn-primary"" id=""buscar"" type=""submit""><i class=""fas fa-search""></i></button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />
<div class=""dropdown"">
    <a class=""btn btn-secondary dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
        MENU
    </a>

    <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
        <li><a class=""dropdown-item"" href=""/Home/Amigos"">Compartido conmigo</a></li>
        <li><a class=""dropdown-item"" href=""/"">Todas las categorias</a></li>
");
#nullable restore
#line 19 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
         foreach (var item in ViewBag.Etiquetas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 964, "\"", 1007, 2);
            WriteAttributeValue("", 971, "/Home/Categoria?idCategoria=", 971, 28, true);
#nullable restore
#line 21 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
WriteAttributeValue("", 999, item.Id, 999, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                                                                    Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>            ");
#nullable restore
#line 21 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                                                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </ul>
    <a href=""#"" data-toggle=""modal"" data-target=""#crear"" class=""btn btn-primary float-right"">
        Tomar notas
    </a>
</div>

<br />

<div class=""container-fluid px-4"">
    <br />
    <div class=""text-center"">
        <h1 class=""display-4"">Notas</h1>
    </div>
    <br />
    <div id=""Lista"">
        <div class=""card"">
");
#nullable restore
#line 38 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
             foreach (var item in nota)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"list-group list-group-flush\">\n    <li class=\"list-group-item\">\n        <h5><a class=\"text-dark\" style=\"text-transform: uppercase; text-decoration:none; outline:none\"");
            BeginWriteAttribute("href", " href=\"", 1610, "\"", 1647, 2);
            WriteAttributeValue("", 1617, "/Home/Detalle?Id=", 1617, 17, true);
#nullable restore
#line 42 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
WriteAttributeValue("", 1634, item.Nota.Id, 1634, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>");
#nullable restore
#line 42 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                                                                                                                                                Write(item.Nota.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></a></h5>\n        <p class=\"float-left\">\n            <strong>Cuerpo: </strong>\n");
#nullable restore
#line 45 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
             if (item.Nota.Cuerpo.Length > 50)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<parcial>");
#nullable restore
#line 47 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
    Write(item.Nota.Cuerpo.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</parcial> ");
#nullable restore
#line 47 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                                                          }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<parcial>");
#nullable restore
#line 50 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
    Write(item.Nota.Cuerpo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</parcial>");
#nullable restore
#line 50 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\n        <div align=\"right\" class=\"float-right\">\n            <a style=\"margin-right:5px;\" class=\"btn btn-danger float-lg-right\"");
            BeginWriteAttribute("href", " href=\"", 2099, "\"", 2137, 2);
            WriteAttributeValue("", 2106, "/Home/Eliminar?id=", 2106, 18, true);
#nullable restore
#line 53 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
WriteAttributeValue("", 2124, item.Nota.Id, 2124, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2138, "\"", 2176, 3);
            WriteAttributeValue("", 2148, "elimina(event,", 2148, 14, true);
#nullable restore
#line 53 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
WriteAttributeValue("", 2162, item.Nota.Id, 2162, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2175, ")", 2175, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-trash-alt\"></i></a>\n            <a style=\"margin-right:5px;\" class=\"btn btn-primary float-lg-right\" href=\"#\" data-toggle=\"modal\" data-target=\"#edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2343, "\"", 2419, 7);
            WriteAttributeValue("", 2353, "selCuenta(\'", 2353, 11, true);
#nullable restore
#line 54 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
WriteAttributeValue("", 2364, item.Nota.Id, 2364, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2377, "\',\'", 2377, 3, true);
#nullable restore
#line 54 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
WriteAttributeValue("", 2380, item.Nota.Titulo, 2380, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2397, "\',\'", 2397, 3, true);
#nullable restore
#line 54 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
WriteAttributeValue("", 2400, item.Nota.Cuerpo, 2400, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2417, "\')", 2417, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\n            <a style=\"margin-right:5px;\" class=\"btn btn-success float-lg-right\" href=\"#\" data-toggle=\"modal\" data-target=\"#compartir\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2586, "\"", 2622, 3);
            WriteAttributeValue("", 2596, "Compartir(\'", 2596, 11, true);
#nullable restore
#line 55 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
WriteAttributeValue("", 2607, item.Nota.Id, 2607, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2620, "\')", 2620, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-share-square\"></i></a>\n        </div>\n    </li>\n</ul>            ");
#nullable restore
#line 58 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- Modal crear -->
<div class=""modal fade"" id=""crear"" tabindex=""-1"" aria-labelledby=""crear"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel_create"">Crear Nota</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""crearNotita"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""submitFormCreate()"">Guardar</button>
            </div>
        </div>
    </div>
</div>

<!-- Modal editar -->
<div class=""modal fade"" id=""edit"" tabindex=""-1"" aria-labelledby=""edit"" aria-hidden=""true""");
            WriteLiteral(@">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel_edit"">Editar Nota</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""editNotita"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""submitForm()"">Guardar</button>
            </div>
        </div>
    </div>
</div>

<!-- Modal compartir -->
<div class=""modal fade"" id=""compartir"" tabindex=""-1"" aria-labelledby=""compartir"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal");
            WriteLiteral(@"-title"" id=""exampleModalLabel_edit"">Compartir Nota</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296dfff851f8da1cf719918c16ba839c2e9ebd7b19404", async() => {
                WriteLiteral(@"
                    <input id=""IdNota"" type=""hidden"" name=""IdNota"" />
                    <div class=""form-group"">
                        <label>Compartir con: </label>
                        <div class=""form-group"" id=""contrasena-group"">
                            <select name=""IdUser"" class=""form-select"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296dfff851f8da1cf719918c16ba839c2e9ebd7b20021", async() => {
                    WriteLiteral("-- Selecciona un usuario --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 120 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                                 foreach (var item in ViewBag.Usuarios)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296dfff851f8da1cf719918c16ba839c2e9ebd7b21595", async() => {
#nullable restore
#line 122 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                                        Write(item.Username);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 122 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
#nullable restore
#line 123 "C:\Users\selen\OneDrive\Documentos\GitHub\T3_Calidad\T3ESOT\Views\Home\Categoria.cshtml"
                           Write(Html.ValidationMessage("Compartido"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </select>\n                        </div>\n                    </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""submitFormCompartir()"">Compartir</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $.ajax({
            url: '/Home/Create',
            type: 'get'
        }).done(function (html) {
            $('#crearNotita').html(html);
        })

        function submitFormCreate() {
            $('#createNota').submit();
        }

        function guardar(event) {
            event.preventDefault();
            var dataString = new FormData($('#crear form')[0]);
            $.ajax({
                url: ""/Home/Create"",
                type: ""post"",
                processData: false,
                contentType: false,
                cache: false,
                data: dataString
            }).done(function (html) {
                location.reload();
            }).fail(function (html) {
                $('#crearNotita').html(html.responseText);
            });
        }
        function elimina(e, id) {
            e.preventDefault();
            $.ajax({
                url: '/Home/Eliminar?id=' + id,
                type: 'get',
            }).done(function (html) {
    ");
                WriteLiteral(@"            location.reload();
            });
        }

        function selCuenta(id, titulo, cuerpo) {
            $('#mtxtId').val(id);
            $('#mtxtTitulo').val(titulo);
            $('#mtxtCuerpo').val(cuerpo);
        };

        $.ajax({
            url: '/Home/Edit',
            type: 'get'
        }).done(function (html) {
            $('#editNotita').html(html);
        })

        function submitForm() {
            $('#editNota').submit();
        }

        function editar(event) {
            event.preventDefault();
            var idE = $('#mtxtId').val();
            var dataString = new FormData($('#edit form')[0]);
            dataString.append(""idE"", idE);
            $.ajax({
                url: ""/Home/Edit"",
                type: ""post"",
                processData: false,
                contentType: false,
                cache: false,
                data: dataString
            }).done(function (html) {
                location.reload();
            }).fail(function (html) {");
                WriteLiteral(@"
                $('#editNotita').html(html.responseText);
            });
        }
        function Compartir(id) {
            $('#IdNota').val(id);
        };

        function submitFormCompartir() {
            $('#compartirf').submit();
        }

        function CompartirForm(event) {
            event.preventDefault();
            var dataString = new FormData($('#compartir form')[0]);
            $.ajax({
                url: ""/Home/Compartir"",
                type: ""post"",
                processData: false,
                contentType: false,
                cache: false,
                data: dataString
            }).done(function (html) {
                location.reload();
            }).fail(function (html) {
                $('#compartirf').html(html.responseText);
            });
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
