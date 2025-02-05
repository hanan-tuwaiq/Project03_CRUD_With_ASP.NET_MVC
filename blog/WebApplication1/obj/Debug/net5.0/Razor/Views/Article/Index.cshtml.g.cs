#pragma checksum "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\Article\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ae8134557114691b1491e62daed0a1ddf0ef2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Index), @"mvc.1.0.view", @"/Views/Article/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ae8134557114691b1491e62daed0a1ddf0ef2e", @"/Views/Article/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\Article\Index.cshtml"
   
    var articles = (List<ArticleModel>)ViewData["articles"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""h-72 my-auto w-screen pt-16"">
    <div class=""flex justify-around transform -rotate-2 scale-110 w-screen text-lg py-1 mt-4 font-sans font-semibold uppercase mb-16"" style=""background-color: #f0ec2b "">
        <div>
            <h1>Articles</h1>
        </div>
        <div>
            <h1>Articles</h1>
        </div>
        <div>
            <h1>Articles</h1>
        </div>
    </div>
</section>
<section class=""w-3/4 m-auto"">
    <div class=""py-1 border-b border-black mb-4"">Number of articles: ");
#nullable restore
#line 18 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\Article\Index.cshtml"
                                                                Write(articles.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n    <div class=\"grid grid-cols-5 gap-4\">\r\n        <div class=\"col-span-4\">\r\n            <div class=\"grid grid-cols-2 gap-4\">\r\n\r\n");
#nullable restore
#line 24 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\Article\Index.cshtml"
                 foreach (var a in articles)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"border border-black text-lg w-5/6 m-auto\">\r\n                        <div");
            BeginWriteAttribute("style", " style=\"", 923, "\"", 977, 5);
            WriteAttributeValue("", 931, "background-image:url(", 931, 21, true);
#nullable restore
#line 27 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\Article\Index.cshtml"
WriteAttributeValue("", 952, a.Image, 952, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 960, ");", 960, 2, true);
            WriteAttributeValue(" ", 962, "height:", 963, 8, true);
            WriteAttributeValue(" ", 970, "300px;", 971, 7, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                             class=\"bg-center bg-cover bg-no-repeat w-full\"></div>\r\n                        <div class=\"p-2\">\r\n                            <div class=\"flex justify-between mb-4\">\r\n                                <div>");
#nullable restore
#line 31 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\Article\Index.cshtml"
                                Write(a.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"text-gray-700 text-sm italic\">");
#nullable restore
#line 32 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\Article\Index.cshtml"
                                                                     Write(a.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"py-1 text-center font-sans font-semibold uppercase\" style=\"background-color: #f0ec2b \">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1517, "\"", 1545, 2);
            WriteAttributeValue("", 1524, "article/details/", 1524, 16, true);
#nullable restore
#line 35 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\Article\Index.cshtml"
WriteAttributeValue("", 1540, a.Id, 1540, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read more</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 39 "C:\Users\SAFCSP\Desktop\hanan\projects\Project03_CRUD_With_ASP.NET_MVC\blog\WebApplication1\Views\Article\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        <div class=""font-sans font-semibold text-lg"">
            <a style=""background-color: #f0ec2b "" class=""fixed w-full py-1 pl-2 hover:font-semibold"" href=""article/create"">Create an Article</a>
        </div>
    </div>
</section>");
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
