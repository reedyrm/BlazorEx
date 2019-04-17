#pragma checksum "/Users/gianni/src/BlazorEx/Pages/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138881c090f2020fa88485201e602550952960b4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorEx.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazorEx;
    using BlazorEx.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Profile</h1>\r\n\r\n");
            builder.AddMarkupContent(1, "<p>Pulling data from another API.</p>\r\n\r\n");
#line 13 "/Users/gianni/src/BlazorEx/Pages/Profile.cshtml"
 if (currentProfile == null)
{


#line default
#line hidden
            builder.AddContent(2, "    ");
            builder.AddMarkupContent(3, "<div>Loading...</div>\r\n");
#line 17 "/Users/gianni/src/BlazorEx/Pages/Profile.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(4, "    ");
            builder.OpenElement(5, "div");
            builder.AddContent(6, "\r\n        ");
            builder.AddMarkupContent(7, "<span>First Name:</span>\r\n        ");
            builder.OpenElement(8, "span");
            builder.AddContent(9, currentProfile.Name);
            builder.CloseElement();
            builder.AddContent(10, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(11, "\r\n    ");
            builder.OpenElement(12, "div");
            builder.AddContent(13, "\r\n        ");
            builder.AddMarkupContent(14, "<span>Last Name:</span>\r\n        ");
            builder.OpenElement(15, "span");
            builder.AddContent(16, currentProfile.Surname);
            builder.CloseElement();
            builder.AddContent(17, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(18, "\r\n    ");
            builder.OpenElement(19, "div");
            builder.AddContent(20, "\r\n        ");
            builder.AddMarkupContent(21, "<span>Region:</span>\r\n        ");
            builder.OpenElement(22, "span");
            builder.AddContent(23, currentProfile.Region);
            builder.CloseElement();
            builder.AddContent(24, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(25, "\r\n");
#line 32 "/Users/gianni/src/BlazorEx/Pages/Profile.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 38 "/Users/gianni/src/BlazorEx/Pages/Profile.cshtml"
            
    //holds data retrieved from the GET call
    ProfileData currentProfile;

    protected override async Task OnInitAsync()
    {
        currentProfile = await Http.GetJsonAsync<ProfileData>("https://uinames.com/api/?&amount=1&ext");
    }

    // Declares class called ProfileData that defines what data will be parsed from response
    class ProfileData
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Gender { get; set; }

        public string Region { get; set; }

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
