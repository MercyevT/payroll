#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\SSFRate\add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a6d754d7a59afc5088cc9ca44e81626566bfac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SSFRate_add), @"mvc.1.0.view", @"/Views/SSFRate/add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a6d754d7a59afc5088cc9ca44e81626566bfac1", @"/Views/SSFRate/add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_SSFRate_add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav aria-label='breadcrumb'>
    <ol class='breadcrumb breadcrumb-arrow'>
        <li class='breadcrumb-item'><a href='/ssfrate/index'>ssfrate</a></li>
        <li class='breadcrumb-item active' aria-current='page'>create</li>
    </ol>
</nav>
<div id='app1' v-cloak>

    <v-app>
         
        <v-card>
          <v-card-title>
          </v-card-title>
          <v-card-text>
            <v-text-field v-model=""ssfrate.SocialSecurityFundRate"" label=""ssfrate"" ></v-text-field>

<v-text-field v-model=""ssfrate.month					"" label=""month"" ></v-text-field>

<v-text-field v-model=""ssfrate.year						"" label=""year"" ></v-text-field>


          </v-card-text>
          <v-card-actions>
             <v-btn ");
            WriteLiteral("@click=\'add_ssfrate\' color=\'blue\' outlined>\n                <v-icon>\n                    mdi-content-save-edit\n                </v-icon>\n             </v-btn>\n          </v-card-actions>\n          \n        </v-card>\n    </v-app>\n</div>\n");
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
                    ssfrate:{}
                    ,
                    
                }//edata
                ,
                created(){
                     
                }//ecreated
                ,
                methods:{
                  add_ssfrate(){
                   
                    var url = '/ssfrate/add';
                    var param= this.ssfrate;
                    $.post(url,param)
                    .done(res =>{
                          if(res.error == -1){
                               window.location = '/ssfrate/index';
                          }
                          else{
                             alert(res.exception);
                          }
                    });
                    
                  }//emethod

                }//emethod
                ,
           ");
                WriteLiteral("      computed:{\n\n                 }//ecomputed\n            };\n            app = new Vue(component);\n\n\n    </script>\n\n");
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