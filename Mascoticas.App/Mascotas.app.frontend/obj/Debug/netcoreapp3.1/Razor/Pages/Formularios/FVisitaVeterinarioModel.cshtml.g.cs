#pragma checksum "C:\Deesarrollo-Mascota-web\Mascoticas.App\Mascotas.app.frontend\Pages\Formularios\FVisitaVeterinarioModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb105023cd380ce64fd7a1da0ca1564e754f589"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mascotas.app.frontend.Pages.Formularios.Pages_Formularios_FVisitaVeterinarioModel), @"mvc.1.0.razor-page", @"/Pages/Formularios/FVisitaVeterinarioModel.cshtml")]
namespace Mascotas.app.frontend.Pages.Formularios
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
#line 1 "C:\Deesarrollo-Mascota-web\Mascoticas.App\Mascotas.app.frontend\Pages\_ViewImports.cshtml"
using Mascotas.app.frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb105023cd380ce64fd7a1da0ca1564e754f589", @"/Pages/Formularios/FVisitaVeterinarioModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb17e293e66b081a47ec7e84b216dbe5d1bb158", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Formularios_FVisitaVeterinarioModel : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("on"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>
    <div align=""center""><img src=""Imagen1.jpeg"" width=""200"" height=""150"">
        <div align=""center""><font size=""10"">VISITA DOMICILIARIA</font></div>
    </div>
    <!-- <img src=""perro_veterinario.jpg"" alt=""purrito"" > -->
    
    </h2>
    <!-- <div align=""center""><h1>VISITA DOMICILIARIA</h1></div> -->
    
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb105023cd380ce64fd7a1da0ca1564e754f5894718", async() => {
                WriteLiteral(@" 
        <!-- fecha -->        
        <label for=""start"">Fecha visita domiciliaria:</label><br>                
        <input style=""width:712px;"" type=""date"" name=""fecha"" min=""2018-01-01"" max=""2022-12-31""/><br>
        <!-- numero de visita -->
        <label for=""name"">Visita N°:</label><br>
        <input style=""width:712px;"" type=""number""><br>
    <!--  selecciona si se efectuo o no la visita con los diferentes radiobuttons -->
        <h3>Visita:</h3>
            <label><input type=""radio""  name=""radio"" id=""Atendida"" value=""Atendida""></label>
            <label for=""atendida""> Atendida </label>
            <label><input type=""radio"" name=""radio"" id=""Solicitante ausente"" value=""Solicitante ausente""></label>
            <label for=""Solicitante""> Solicitante ausente </label>
            <label><input type=""radio"" name=""radio"" id=""No abrieron"" value=""No abrieron""></label>
            <label for=""no_abrieron"">No abrieron</label>
            <label><input type=""radio"" name=""radio"" id=""No hab");
                WriteLiteral(@"itan la vivienda"" value=""No habitan la vivienda""></label>
            <label for=""no_habita""> No habitan la vivienda </label>
            <label><input type=""radio"" name=""radio"" id=""La dirección no corresponde"" value=""La dirección no corresponde""></label>
            <label for=""direccion""> La dirección no corresponde </label>
            <label><input type=""radio"" name=""radio"" id=""Visita rechazada"" value=""Visita rechazada""></label>
            <label for=""rechazada""> Visita rechazada </label>
        <br>
        <!-- caja de texto para colocar el motivo por el cual se realiza la visita -->
        
            <h3>Motivo de la visita</h3>
            <textarea cols=""96"" rows=""7"">            
            </textarea><br>
            <button>Enviar Motivo</button><br><br><br>
        
        
        <!-- datos de la persona que solicita la visita -->
        
            <h3>Datos del Solicitante de la Visita:</h3>                  

            <label for=""name"">Propietario:</label>
    ");
                WriteLiteral("        <input");
                BeginWriteAttribute("class", " class=", 2521, "", 2528, 0);
                EndWriteAttribute();
                WriteLiteral(" texto style=\"width:710px;\" type=\"text\" id=\"nombre\"><br><br>\r\n            \r\n            <label for=\"name\">Direccion:</label>\r\n            <input");
                BeginWriteAttribute("class", " class=", 2672, "", 2679, 0);
                EndWriteAttribute();
                WriteLiteral(" texto style=\"width:710px;\" type=\"text\" id=\"direccion\"><br><br>\r\n\r\n            <label for=\"name\">Telefono Celular:</label>\r\n            <input");
                BeginWriteAttribute("class", " class=", 2821, "", 2828, 0);
                EndWriteAttribute();
                WriteLiteral(" texto style=\"width:710px;\" type=\"text\" id=\"celu\"><br><br>\r\n           \r\n            <label for=\"name\">Nombre de la Mascota:</label>\r\n            <input");
                BeginWriteAttribute("class", " class=", 2980, "", 2987, 0);
                EndWriteAttribute();
                WriteLiteral(@" texto style=""width:710px;"" type=""text"" id=""nombreMascota""><br><br>
            
            <label for=""name"">Tipo de Mascota:</label>
            <label><input type=""radio"" name=""radio"" id=""perro"" value=""Perro""></label>
            <label for=""perro""> Perro </label>
            <label><input type=""radio"" name=""radio"" id=""gato"" value=""Gato""></label>
            <label for=""gato""> Gato </label>
            <label><input type=""radio"" name=""radio"" id=""ave"" value=""Ave""></label>
            <label for=""ave""> Ave </label>
            <label><input type=""radio"" name=""radio"" id=""otro"" value=""Otro""></label>
            <label for=""otro""> Otro </label>
            <label><p>cual?<input");
                BeginWriteAttribute("class", " class=", 3683, "", 3690, 0);
                EndWriteAttribute();
                WriteLiteral(" texto style=\"width:710px;\" type=\"text\" id=\"cual\"><br></p> </label> \r\n\r\n            <label for=\"name\">Raza de la Mascota:</label>\r\n            <input");
                BeginWriteAttribute("class", " class=", 3839, "", 3846, 0);
                EndWriteAttribute();
                WriteLiteral(" texto style=\"width:710px;\" type=\"text\" id=\"razaMascota\"><br><br>\r\n\r\n            <label for=\"name\">Peso de la Mascota:</label>\r\n            <input");
                BeginWriteAttribute("class", " class=", 3992, "", 3999, 0);
                EndWriteAttribute();
                WriteLiteral(" texto style=\"width:710px;\" type=\"text\" id=\"pesoMascota\"><br><br>\r\n\r\n            <label for=\"name\">Temperatura de la Mascota:</label>\r\n            <input");
                BeginWriteAttribute("class", " class=", 4152, "", 4159, 0);
                EndWriteAttribute();
                WriteLiteral(" texto style=\"width:710px;\" type=\"text\" id=\"temperaturaMascota\"><br><br>\r\n\r\n            <label for=\"name\">Frecuencia Cardiaca de la Mascota:</label>\r\n            <input");
                BeginWriteAttribute("class", " class=", 4327, "", 4334, 0);
                EndWriteAttribute();
                WriteLiteral(" texto style=\"width:710px;\" type=\"text\" id=\"cardioMascota\"><br><br>\r\n\r\n            <label for=\"name\">Frecuencia Respiratoria de la Mascota:</label>\r\n            <input");
                BeginWriteAttribute("class", " class=", 4501, "", 4508, 0);
                EndWriteAttribute();
                WriteLiteral(" texto style=\"width:710px;\" type=\"text\" id=\"respiracionMascota\"><br><br>\r\n\r\n            <label for=\"name\">Estado Animico de la Mascota:</label>\r\n            <input");
                BeginWriteAttribute("class", " class=", 4671, "", 4678, 0);
                EndWriteAttribute();
                WriteLiteral(@" texto style=""width:710px;"" type=""text"" id=""animoMascota""><br><br>

            <button>Enviar formulario</button><br><br><br>       
        
       
            <h3>Observaciones y Recomendaciones</h3>
            <textarea cols=""96"" rows=""7"">            
            </textarea><br>
            <button>Enviar</button><br><br>   

        <button>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb105023cd380ce64fd7a1da0ca1564e754f58911466", async() => {
                    WriteLiteral("Volver");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</button><br><br><br>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mascotas.app.frontend.pages.FVisitaVeterinarioModelModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mascotas.app.frontend.pages.FVisitaVeterinarioModelModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mascotas.app.frontend.pages.FVisitaVeterinarioModelModel>)PageContext?.ViewData;
        public Mascotas.app.frontend.pages.FVisitaVeterinarioModelModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
