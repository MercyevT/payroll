#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\OT\import.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4590632c5a545d16628104fd49655f702a24ea70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OT_import), @"mvc.1.0.view", @"/Views/OT/import.cshtml")]
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
#line 1 "C:\Users\max_w\Desktop\projectpayroll\Views\_ViewImports.cshtml"
using projectpayroll;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\max_w\Desktop\projectpayroll\Views\_ViewImports.cshtml"
using projectpayroll.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4590632c5a545d16628104fd49655f702a24ea70", @"/Views/OT/import.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_OT_import : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h4>Import Employee ot</h4>
<nav aria-label='breadcrumb'>
    <ol class='breadcrumb breadcrumb-arrow'>
        <li class='breadcrumb-item'><a href='/clocking/index'> OT</a></li>
        <li class='breadcrumb-item active' aria-current='page'>import OT</li>
    </ol>
</nav>
<div id='app1' v-cloak>

    <v-app>
        <v-main>
        <v-file-input
           label=""file""
            v-model=""file1""
        ></v-file-input>
        <v-btn
         ");
            WriteLiteral("@click=\'upload\'\r\n        >\r\n            <v-icon>\r\n              mdi-import\r\n            </v-icon>\r\n            import\r\n        </v-btn>\r\n        </v-main>\r\n    </v-app>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var app;
            var component = {
                vuetify: new Vuetify()
                ,
                el:'#app1'
                ,
                data:{
                    file1:null
                ,
                   list1:[]
                }
                ,
                created(){
          
                }
                ,
                methods:{
                    upload(){
        // Create an FormData object 
        var data = new FormData();
        data.append(""file1"",this.file1);
        console.log(data);
                        $.ajax({
            type: ""POST"",
            enctype: 'multipart/form-data',
            url: ""/ot/importFile4"",
            data: data,
            processData: false,
            contentType: false,
            cache: false,
            timeout: 600000,
            success: function (data) {

                
                console.log(""SUCCESS : "", data);
 
            },
          ");
                WriteLiteral(@"  error: function (e) {

                $(""#result"").text(e.responseText);
                console.log(""ERROR : "", e);
                $(""#btnSubmit"").prop(""disabled"", false);

            }
        });
                    }//ef
                }//emethod
                ,
                 computed:{

                 }
            };
            app = new Vue(component);


    </script>

");
            }
            );
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
