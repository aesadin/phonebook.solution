#pragma checksum "/Users/frederickernest/Desktop/PhoneBook.Solution/PhoneBook/Views/Contacts/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9b4d3e56c07ec0e6d496b8525e2a2e2a7df7936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Show), @"mvc.1.0.view", @"/Views/Contacts/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contacts/Show.cshtml", typeof(AspNetCore.Views_Contacts_Show))]
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
#line 1 "/Users/frederickernest/Desktop/PhoneBook.Solution/PhoneBook/Views/Contacts/Show.cshtml"
using PhoneBook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b4d3e56c07ec0e6d496b8525e2a2e2a7df7936", @"/Views/Contacts/Show.cshtml")]
    public class Views_Contacts_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 40, true);
            WriteLiteral("\n<h3>Here are your contacts:</h3>\n\n<ol>\n");
            EndContext();
#line 6 "/Users/frederickernest/Desktop/PhoneBook.Solution/PhoneBook/Views/Contacts/Show.cshtml"
 foreach (Contact contact in @Model["contact"])
{

#line default
#line hidden
            BeginContext(115, 8, true);
            WriteLiteral("  <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 123, "\'", 151, 2);
            WriteAttributeValue("", 130, "/contacts/", 130, 10, true);
#line 8 "/Users/frederickernest/Desktop/PhoneBook.Solution/PhoneBook/Views/Contacts/Show.cshtml"
WriteAttributeValue("", 140, contact.Id, 140, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(152, 5, true);
            WriteLiteral("></a>");
            EndContext();
            BeginContext(158, 13, false);
#line 8 "/Users/frederickernest/Desktop/PhoneBook.Solution/PhoneBook/Views/Contacts/Show.cshtml"
                                     Write(contact.Email);

#line default
#line hidden
            EndContext();
            BeginContext(171, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 9 "/Users/frederickernest/Desktop/PhoneBook.Solution/PhoneBook/Views/Contacts/Show.cshtml"
}

#line default
#line hidden
            BeginContext(179, 9, true);
            WriteLiteral("</ol>\n\n\n\n");
            EndContext();
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