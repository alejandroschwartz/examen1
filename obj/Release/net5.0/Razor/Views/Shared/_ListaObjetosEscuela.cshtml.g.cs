#pragma checksum "C:\Users\Augusto D.j\Desktop\Paginas\asp-net-core\Views\Shared\_ListaObjetosEscuela.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e4141023c2ec9d25471ec9cb8569d4ca329aa47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ListaObjetosEscuela), @"mvc.1.0.view", @"/Views/Shared/_ListaObjetosEscuela.cshtml")]
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
#line 1 "C:\Users\Augusto D.j\Desktop\Paginas\asp-net-core\Views\_ViewImports.cshtml"
using asp_net_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Augusto D.j\Desktop\Paginas\asp-net-core\Views\_ViewImports.cshtml"
using asp_net_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e4141023c2ec9d25471ec9cb8569d4ca329aa47", @"/Views/Shared/_ListaObjetosEscuela.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767e1d73e21edf8f8b2005de957439111a61a136", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ListaObjetosEscuela : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"" style=""background-color: f2f2f2;"">
    <div class=""row"">
        <div class=""col-6"">
            <li class=""list-group-item list-group-item-info"""">Nombre : </li>
        </div>
        <div class=""col-6"">
            <li class=""list-group-item list-group-item-info"""">Id : </li>
        </div>

");
#nullable restore
#line 12 "C:\Users\Augusto D.j\Desktop\Paginas\asp-net-core\Views\Shared\_ListaObjetosEscuela.cshtml"
             foreach (var obj in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"container-fluid\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-6\">\r\n                            <li class=\"list-group-item\"> ");
#nullable restore
#line 17 "C:\Users\Augusto D.j\Desktop\Paginas\asp-net-core\Views\Shared\_ListaObjetosEscuela.cshtml"
                                                    Write(obj.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        </div>\r\n                        <div class=\"col-6\">\r\n                            <li class=\"list-group-item\"> ");
#nullable restore
#line 20 "C:\Users\Augusto D.j\Desktop\Paginas\asp-net-core\Views\Shared\_ListaObjetosEscuela.cshtml"
                                                    Write(obj.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        </div>                 \r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\Augusto D.j\Desktop\Paginas\asp-net-core\Views\Shared\_ListaObjetosEscuela.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
