#pragma checksum "/Users/gabrielgiroud/Documents/VisualStudio/Projet/ProjetC#/C# MVC/projet_MVC/projet_MVC/Views/ProfilUser/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2daf70ee2d077fc01c23002ecdfd974aa831519a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProfilUser_Index), @"mvc.1.0.view", @"/Views/ProfilUser/Index.cshtml")]
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
#line 1 "/Users/gabrielgiroud/Documents/VisualStudio/Projet/ProjetC#/C# MVC/projet_MVC/projet_MVC/Views/_ViewImports.cshtml"
using projet_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gabrielgiroud/Documents/VisualStudio/Projet/ProjetC#/C# MVC/projet_MVC/projet_MVC/Views/_ViewImports.cshtml"
using projet_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2daf70ee2d077fc01c23002ecdfd974aa831519a", @"/Views/ProfilUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f35fdb23b19c6abceb767efaa3572c7940781f9d", @"/Views/_ViewImports.cshtml")]
    public class Views_ProfilUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProjetCoreData.Models.Utilisateur>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "/Users/gabrielgiroud/Documents/VisualStudio/Projet/ProjetC#/C# MVC/projet_MVC/projet_MVC/Views/ProfilUser/Index.cshtml"
  
    ViewData["Tittle"] = "INDEX";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 9 "/Users/gabrielgiroud/Documents/VisualStudio/Projet/ProjetC#/C# MVC/projet_MVC/projet_MVC/Views/ProfilUser/Index.cshtml"
Write(ViewBag.Titre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProjetCoreData.Models.Utilisateur>> Html { get; private set; }
    }
}
#pragma warning restore 1591
