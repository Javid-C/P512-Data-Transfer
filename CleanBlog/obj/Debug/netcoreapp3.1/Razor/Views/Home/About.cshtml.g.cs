#pragma checksum "C:\Users\Lenovo\source\repos\P512_DataTransfer\CleanBlog\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c995476bef2006d8293ffa70e743fbb48de7bfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\P512_DataTransfer\CleanBlog\Views\_ViewImports.cshtml"
using CleanBlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\P512_DataTransfer\CleanBlog\Views\_ViewImports.cshtml"
using CleanBlog.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c995476bef2006d8293ffa70e743fbb48de7bfd", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"016fa1ad8c0b200f691553552a007fb9bd6bf10d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\P512_DataTransfer\CleanBlog\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"masthead\"");
            BeginWriteAttribute("style", " style=\"", 69, "\"", 141, 4);
            WriteAttributeValue("", 77, "background-image:", 77, 17, true);
            WriteAttributeValue(" ", 94, "url(", 95, 5, true);
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\P512_DataTransfer\CleanBlog\Views\Home\About.cshtml"
WriteAttributeValue("", 99, Url.Content("~/assets/img/about-bg.jpg"), 99, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 140, ")", 140, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""container position-relative px-4 px-lg-5"">
        <div class=""row gx-4 gx-lg-5 justify-content-center"">
            <div class=""col-md-10 col-lg-8 col-xl-7"">
                <div class=""page-heading"">
                    <h1>About Me</h1>
                    <span class=""subheading"">This is what I do.</span>
                </div>
            </div>
        </div>
    </div>
</header>
<!-- Main Content-->
<main class=""mb-4"">
    <div class=""container px-4 px-lg-5"">
        <div class=""row gx-4 gx-lg-5 justify-content-center"">
            <div class=""col-md-10 col-lg-8 col-xl-7"">
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Saepe nostrum ullam eveniet pariatur voluptates odit, fuga atque ea nobis sit soluta odio, adipisci quas excepturi maxime quae totam ducimus consectetur?</p>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eius praesentium recusandae illo eaque architecto error, repellendus iusto reprehenderit,");
            WriteLiteral(@" doloribus, minus sunt. Numquam at quae voluptatum in officia voluptas voluptatibus, minus!</p>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aut consequuntur magnam, excepturi aliquid ex itaque esse est vero natus quae optio aperiam soluta voluptatibus corporis atque iste neque sit tempora!</p>
            </div>
        </div>
    </div>
</main>

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