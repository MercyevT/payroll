#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18beeac6e6a7a546f2d4203766dacb348628307f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_slipSalary_add), @"mvc.1.0.view", @"/Views/slipSalary/add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18beeac6e6a7a546f2d4203766dacb348628307f", @"/Views/slipSalary/add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_slipSalary_add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav aria-label='breadcrumb'>
    <ol class='breadcrumb breadcrumb-arrow'>
        <li class='breadcrumb-item'><a href='/slipsalary/index'>slipsalary</a></li>
        <li class='breadcrumb-item active' aria-current='page'>create</li>
    </ol>
</nav>
<div id='app1' v-cloak>

    <v-app>
         
        <v-card>
          <v-card-title>
          </v-card-title>
          <v-card-text>
             <v-select return-object
          v-model=""select_employee""
          :items=""employees""
          item-text=""employeeId""
          menu-props=""auto""
          single-line
          label=""employeeId""
          show=""employeeId"" 
           
  ></v-select>

 <v-select return-object
          v-model=""select_slipMaster			""
          :items=""slipMaster			s""
          item-text=""slipMasterName""
          menu-props=""auto""
          single-line
          label=""slipMasterId			""
          show=""slipMasterName"" 
           
  ></v-select>

<v-text-field v-model=""slipsalary.value"" label=""value"" ></v-text-field>




     ");
            WriteLiteral("     </v-card-text>\n          <v-card-actions>\n             <v-btn ");
            WriteLiteral("@click=\'add_slipsalary\' color=\'blue\' outlined>\n                <v-icon>\n                    mdi-content-save-edit\n                </v-icon>\n             </v-btn>\n          </v-card-actions>\n          \n        </v-card>\n    </v-app>\n</div>\n");
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
                    slipsalary:{},
                    employees:[] ,
                    select_employee:{},
                    slipMasters:[] ,
                    select_slipMaster:{},

                }//edata
                ,
                created(){
                    this.employees = ");
#nullable restore
#line 72 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\add.cshtml"
                                Write(Html.Raw(Json.Serialize(@ViewBag.employees)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                    this.select_employee = this.employees[0];\n                    this.slipMasters = ");
#nullable restore
#line 74 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\add.cshtml"
                                  Write(Html.Raw(Json.Serialize(@ViewBag.slipMasters)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                    this.select_slipMaster	= this.slipMasters[0];

                }//ecreated
                ,
                methods:{
                  add_slipsalary(){
                    this.slipsalary.employeeId = this.select_employee.employeeId;
                    this.slipsalary.slipMasterId = this.select_slipMaster.slipMasterId;

                    var url = '/slipsalary/add';
                    var param= this.slipsalary;
                    $.post(url,param)
                    .done(res =>{
                          if(res.error == -1){
                               window.location = '/slipsalary/index';
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
