#pragma checksum "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7cea81045199479904d5f16332e79460382825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7cea81045199479904d5f16332e79460382825", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\User\Index.cshtml"
   
    var users = (List<UserModel>)ViewData["users"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""h-72 my-auto w-screen pt-16"">
    <div class=""flex justify-around transform rotate-2 scale-110 w-screen text-lg py-1 mt-4 font-sans font-semibold uppercase mb-16"" style=""background-color: #f0ec2b "">
        <div>
            <h1>Bloggers</h1>
        </div>
        <div>
            <h1>Bloggers</h1>
        </div>
        <div>
            <h1>Bloggers</h1>
        </div>
    </div>
</section>
<div>
");
#nullable restore
#line 18 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\User\Index.cshtml"
     foreach(var u in users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"w-3/4 m-auto my-8\">\r\n                    <div class=\"rounded-full h-16 w-16 bg-gray-800\"");
            BeginWriteAttribute("style", " style=\"", 656, "\"", 691, 2);
            WriteAttributeValue("", 664, "background-image:", 664, 17, true);
#nullable restore
#line 21 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\User\Index.cshtml"
WriteAttributeValue("", 681, u.Picture, 681, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                    <h1 class=\"text-2xl\">");
#nullable restore
#line 22 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\User\Index.cshtml"
                                    Write(u.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h4 class=\"text-lg\">");
#nullable restore
#line 23 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\User\Index.cshtml"
                                   Write(u.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\User\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
