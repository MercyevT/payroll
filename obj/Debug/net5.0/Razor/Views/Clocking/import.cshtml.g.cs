#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\Clocking\import.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb71c424dad1d04a8bb009aed6a05b7cf54268a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clocking_import), @"mvc.1.0.view", @"/Views/Clocking/import.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb71c424dad1d04a8bb009aed6a05b7cf54268a9", @"/Views/Clocking/import.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_Clocking_import : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id='app1' v-cloak>

    <v-app style=""background-color:#EDF1F2;"">
        <v-main>
              <v-card>
            <v-navigation-drawer
                    permanent
                    :mini-variant.sync=""mini""
                    fixed
                    app
                    style=""background-color:#002952""
                    >
                    <v-list
                    nav
                    dense
                    >
                    <v-btn
                    icon
                    ");
            WriteLiteral("@click.stop=\"mini = !mini\"\r\n                    >\r\n                    <v-icon style=\"color:white\">mdi-chevron-left</v-icon>\r\n                    </v-btn>\r\n                    <v-list-item ");
            WriteLiteral(@"@click='clocking_p' >
                        <v-list-item-icon>
                        <v-icon style=""color:white"">mdi-timetable</v-icon>
                        </v-list-item-icon>
                        <v-list-item-title style=""color:white"">CLOCKING</v-list-item-title>
                    </v-list-item>
                    <v-list-item ");
            WriteLiteral(@"@click='clocking_i'>
                        <v-list-item-icon>
                        <v-icon style=""color:white"">mdi-file-import</v-icon>
                        </v-list-item-icon>
                        <v-list-item-title style=""color:white"">IMPORT</v-list-item-title>
                    </v-list-item>
                </v-navigation-drawer>
                </v-card>	
        <v-card class=""size"">
         <v-card-title class=""white--text"" style=""background-color:#001f3d;"">
                        <h3 style=""text-align: center"">IMPORT EMPLOYEE Clocking</h3>
        </v-card-title>
        <br>
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
                   list1:[],
                   mini:true,
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
            url: ""/clocking/importFile4"",
            data: data,
            processData: false,
            contentType: false,
            cache: false,
            timeout: 600000,
            success: function (data) {

                
                console.log(""SUCCESS : "",");
                WriteLiteral(@" data);
 
            },
            error: function (e) {

                $(""#result"").text(e.responseText);
                console.log(""ERROR : "", e);
                $(""#btnSubmit"").prop(""disabled"", false);

            }
        });
                    }//ef
                     ,
                      clocking_p(){
                        window.location='/clocking/index'
                      }
                      ,
                      clocking_i(){
                         window.location='/clocking/importview'
                      }
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
