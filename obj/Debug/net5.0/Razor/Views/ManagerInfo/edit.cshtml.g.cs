#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\ManagerInfo\edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66e4b93837dd9a2496ecfb4fd40ac016d2ecaba3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagerInfo_edit), @"mvc.1.0.view", @"/Views/ManagerInfo/edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e4b93837dd9a2496ecfb4fd40ac016d2ecaba3", @"/Views/ManagerInfo/edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagerInfo_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav aria-label='breadcrumb'>
    <ol class='breadcrumb breadcrumb-arrow'>
        <li class='breadcrumb-item'><a href='/managerinfo/index'>managerinfo</a></li>
        <li class='breadcrumb-item active' aria-current='page'>edit</li>
    </ol>
</nav>
<div id='app1' v-cloak>

    <v-app>
         
        <v-card>
          <v-card-title>
          </v-card-title>
          <v-card-text>
            <v-text-field v-model=""managerinfo.managerInfoFname"" label=""managerInfoFname"" ></v-text-field>

<v-text-field v-model=""managerinfo.managerInfoLname"" label=""managerInfoLname"" ></v-text-field>

<v-text-field v-model=""managerinfo.managerCZId	"" label=""managerCZId"" ></v-text-field>

<v-text-field v-model=""managerinfo.managerAddress	"" label=""managerAddress"" ></v-text-field>

<v-text-field v-model=""managerinfo.managerCode		"" label=""managerCode"" ></v-text-field>


          </v-card-text>
          <v-card-actions>
             <v-btn ");
            WriteLiteral("@click=\'edit_managerinfo\' color=\'yellow\' outlined>\n                <v-icon>\n                    mdi-content-save-edit\n                </v-icon>\n             </v-btn>\n          </v-card-actions>\n          \n        </v-card>\n    </v-app>\n</div>\n");
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
                    managerinfo:{}
                    ,
                    
                }//edata
                ,
                created(){
                  this.managerinfo = ");
#nullable restore
#line 53 "C:\Users\max_w\Desktop\projectpayroll\Views\ManagerInfo\edit.cshtml"
                                Write(Html.Raw(Json.Serialize(@ViewBag.managerinfo)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                     
                     
                }//ecreated
                ,
                methods:{
                  edit_managerinfo(){
                   
                    var url = '/managerinfo/edit';
                    var param= this.managerinfo;
                    $.post(url,param)
                    .done(res =>{
                          if(res.error == -1){
                               window.location = '/managerinfo/index';
                          }
                          else{
                             alert(res.exception);
                          }
                    });
                    
                  }//emethod

                }//emethod
                ,
                 computed:{

                 }//ecomputed
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
