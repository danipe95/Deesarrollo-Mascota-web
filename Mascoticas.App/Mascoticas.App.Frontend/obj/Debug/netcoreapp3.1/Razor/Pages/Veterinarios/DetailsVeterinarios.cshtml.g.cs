#pragma checksum "C:\Deesarrollo-Mascota-web\Deesarrollo-Mascota-web\Mascoticas.App\Mascoticas.App.Frontend\Pages\Veterinarios\DetailsVeterinarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a3974847e6d972f06c164594be56b3d187fb24e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mascoticas.App.Frontend.Pages.Veterinarios.Pages_Veterinarios_DetailsVeterinarios), @"mvc.1.0.razor-page", @"/Pages/Veterinarios/DetailsVeterinarios.cshtml")]
namespace Mascoticas.App.Frontend.Pages.Veterinarios
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
#line 1 "C:\Deesarrollo-Mascota-web\Deesarrollo-Mascota-web\Mascoticas.App\Mascoticas.App.Frontend\Pages\_ViewImports.cshtml"
using Mascoticas.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a3974847e6d972f06c164594be56b3d187fb24e", @"/Pages/Veterinarios/DetailsVeterinarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7a2c10a50329dd6ef301e3706fc288039d53a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinarios_DetailsVeterinarios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./FLisVeterinarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>vet</h2>\r\n<div>\r\n    TarjetaProfesional: ");
#nullable restore
#line 7 "C:\Deesarrollo-Mascota-web\Deesarrollo-Mascota-web\Mascoticas.App\Mascoticas.App.Frontend\Pages\Veterinarios\DetailsVeterinarios.cshtml"
                   Write(Model.Veterinarios.TarjetaProfesional);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Nombres: ");
#nullable restore
#line 10 "C:\Deesarrollo-Mascota-web\Deesarrollo-Mascota-web\Mascoticas.App\Mascoticas.App.Frontend\Pages\Veterinarios\DetailsVeterinarios.cshtml"
        Write(Model.Veterinarios.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Apellidos: ");
#nullable restore
#line 13 "C:\Deesarrollo-Mascota-web\Deesarrollo-Mascota-web\Mascoticas.App\Mascoticas.App.Frontend\Pages\Veterinarios\DetailsVeterinarios.cshtml"
          Write(Model.Veterinarios.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Celular: ");
#nullable restore
#line 16 "C:\Deesarrollo-Mascota-web\Deesarrollo-Mascota-web\Mascoticas.App\Mascoticas.App.Frontend\Pages\Veterinarios\DetailsVeterinarios.cshtml"
        Write(Model.Veterinarios.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Email: ");
#nullable restore
#line 19 "C:\Deesarrollo-Mascota-web\Deesarrollo-Mascota-web\Mascoticas.App\Mascoticas.App.Frontend\Pages\Veterinarios\DetailsVeterinarios.cshtml"
      Write(Model.Veterinarios.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a3974847e6d972f06c164594be56b3d187fb24e5473", async() => {
                WriteLiteral("Lista de Veterinarios ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mascoticas.App.Frontend.Pages.DetailsVeterinariosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mascoticas.App.Frontend.Pages.DetailsVeterinariosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mascoticas.App.Frontend.Pages.DetailsVeterinariosModel>)PageContext?.ViewData;
        public Mascoticas.App.Frontend.Pages.DetailsVeterinariosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
