#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\OT\check.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c11cfa7da6154d49b60fc2707fe28c99dc689a8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OT_check), @"mvc.1.0.view", @"/Views/OT/check.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c11cfa7da6154d49b60fc2707fe28c99dc689a8d", @"/Views/OT/check.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_OT_check : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav aria-label=""breadcrumb"">
    <ol class=""breadcrumb breadcrumb-arrow"">
        <li class=""breadcrumb-item active"" aria-current=""page"">clocking</li>
    </ol>
</nav>
<div id='app1' v-cloak>

    <v-app>
        <v-main>
             
             <v-data-table
             :headers ='headers'
             :items   ='startTimes'
              class='elevation-1'
             />
                  <template v-slot:item.actions='{item}'>
                        <v-btn 
                        class=""white--text""
                        color=""blue darken-1""
                        ");
            WriteLiteral(@"@click=""edit_clocking(item)""
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
              
                   clockings:[],ot:[], clocking:[],startTimes:[]
                   ,
                   headers:[

                      {text:'employeeId',value:'employeeId',align:'center',sortable:true},
                      {text:'clockingIn',value:'clockingIn',align:'center',sortable:true},
                      {text:'breakIn',value:'breakIn',align:'center',sortable:true},
                      {text:'breakOut',value:'breakOut',align:'center',sortable:true},
                      {text:'clockingOut',value:'clockingOut',align:'center',sortable:true},
                      {text:'Date',value:'date',align:'center',sortable:true},
                      {text:'actions',value:'actions',align:'center',sortable:true}

					]
                }//edata
                ,
                creat");
                WriteLiteral("ed(){\r\n                    this.ot = ");
#nullable restore
#line 58 "C:\Users\max_w\Desktop\projectpayroll\Views\OT\check.cshtml"
                         Write(Html.Raw(Json.Serialize(@ViewBag.ot)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    this.clocking = ");
#nullable restore
#line 59 "C:\Users\max_w\Desktop\projectpayroll\Views\OT\check.cshtml"
                               Write(Html.Raw(Json.Serialize(@ViewBag.clockings)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    this.employees = ");
#nullable restore
#line 60 "C:\Users\max_w\Desktop\projectpayroll\Views\OT\check.cshtml"
                                Write(Html.Raw(Json.Serialize(@ViewBag.employees)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    this.select_employee = ");
#nullable restore
#line 61 "C:\Users\max_w\Desktop\projectpayroll\Views\OT\check.cshtml"
                                      Write(Html.Raw(Json.Serialize(@ViewBag.select_employee)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                     console.log(this.ot)
                     
                    this.clockings = this.clocking.filter(x=>x.employeeId==this.ot.employeeId);
                    for(i=0;i<this.clockings.length;i++){
                    var Time = this.clockings[i].clockingIn.split("":"");
                    var TimeSelect = this.ot.oTStart.split("":"");
                        if(Time[0]==TimeSelect[0]){
                        this.startTimes.push(this.clockings[i]);
                        }
                    }                      
                     console.log(this.clocking)
                     console.log(this.clockings)
                     console.log(this.startTimes)
                     
                   

                }//ecreated
                ,
                methods:{
                    
                    
                    edit_clocking(item){
                        window.location = '/clocking/edit/'+item.clockingId;
                    }

         ");
                WriteLiteral("       }//emethods\r\n                ,\r\n                computed:{\r\n\r\n                }//ecomputed\r\n            };\r\n            app = new Vue(component);\r\n\r\n\r\n    </script>\r\n\r\n");
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
