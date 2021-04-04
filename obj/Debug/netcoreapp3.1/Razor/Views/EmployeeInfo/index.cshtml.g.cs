#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\EmployeeInfo\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0455196b244f9d2d49685808d71c26a6dc66bbd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeInfo_index), @"mvc.1.0.view", @"/Views/EmployeeInfo/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0455196b244f9d2d49685808d71c26a6dc66bbd8", @"/Views/EmployeeInfo/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeInfo_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav aria-label=""breadcrumb"">
    <ol class=""breadcrumb breadcrumb-arrow"">
        <li class=""breadcrumb-item active"" aria-current=""page"">employeeInfo</li>
    </ol>
</nav>
<div id='app1' v-cloak>

    <v-app>
        <v-main>
             <v-btn
              ");
            WriteLiteral(@"@click='add_employeeinfo'
             >
                 <v-icon>
                   mdi-plus
                 </v-icon>
                 
             </v-btn>
             <v-data-table
             :headers ='headers'
             :items   ='employeeInfos'
              class='elevation-1'
             />
                  <template v-slot:item.actions='{item}'>
                        <v-btn 
                        class=""white--text""
                        color=""blue darken-1""
                        ");
            WriteLiteral(@"@click=""edit_employeeinfo(item)""
                        >
                            <v-icon>
                            mdi-pencil
                            </v-icon>
                            
                        </v-btn>
                </template>
             </v-data-table>
        </v-main>
    </v-app>
</div>
");
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
              
                   employeeInfos:[]
                   ,
                   headers:[

                      {text:'employeeId',value:'employeeId',align:'center',sortable:true},

                      {text:'InfoMasterId',value:'infoMasterId',align:'center',sortable:true},

                      {text:'actions',value:'actions',align:'center',sortable:true}

					]
                }//edata
                ,
                created(){
                  this.employeeInfos = ");
#nullable restore
#line 63 "C:\Users\max_w\Desktop\projectpayroll\Views\EmployeeInfo\index.cshtml"
                                  Write(Html.Raw(Json.Serialize(@ViewBag.employeeInfos)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                  console.log(this.employeeInfos)
                }//ecreated
                ,
                methods:{
                    add_employeeinfo(){
                        window.location= '/employeeinfo/add';
                  
                        
                    }//ef
                    
                    ,
                    edit_employeeinfo(item){
                        window.location = '/employeeinfo/edit/'+item.employeeInfoId;
                    }

                }//emethods
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