#pragma checksum "/Users/arthurbuck/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d24eb9ba7e55a4ca5b43e72d6603c958932da0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_Show), @"mvc.1.0.view", @"/Views/Pets/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24eb9ba7e55a4ca5b43e72d6603c958932da0ca", @"/Views/Pets/Show.cshtml")]
    public class Views_Pets_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 1 "/Users/arthurbuck/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Show.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<p>Food Level: ");
#nullable restore
#line 3 "/Users/arthurbuck/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Show.cshtml"
          Write(Model.Food);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Attention Level: ");
#nullable restore
#line 4 "/Users/arthurbuck/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Show.cshtml"
               Write(Model.Attention);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Rest Level: ");
#nullable restore
#line 5 "/Users/arthurbuck/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Show.cshtml"
          Write(Model.Rest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<p>What would you like to do with ");
#nullable restore
#line 7 "/Users/arthurbuck/Desktop/Tamagotchi.Solution/Tamagotchi/Views/Pets/Show.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?</p>

<form action=""/pets"" method=""post"">
  <label for=""interactive"">Would you like to ""Play"", ""Sleep"" or ""Eat""?</label>
  <input id=""interactive"" name=""interactive"" type=""text"">
  <button type=""submit"">Submit</button>
</form>

<a href='/pets'>See your other pets</a>
");
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
