#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b4d4d089c81879e6505b2ea075756716d5dcd1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CurrentSalary_add), @"mvc.1.0.view", @"/Views/CurrentSalary/add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b4d4d089c81879e6505b2ea075756716d5dcd1c", @"/Views/CurrentSalary/add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_CurrentSalary_add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav aria-label='breadcrumb'>
    <ol class='breadcrumb breadcrumb-arrow'>
        <li class='breadcrumb-item'><a href='/currentsalary/index'>currentsalary</a></li>
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
          v-model=""select_employeeSalaryMaster""
          :items=""employeeSalaryMasters""
          item-text=""employeeSalaryMasterId""
          menu-props=""auto""
          single-line
          label=""employeeSalaryMasterId""
          show=""employeeSalaryMasterId"" 
           
  ></v-select>

<v-text-field v-model=""currentsalary.c");
            WriteLiteral(@"urrentSalaryAmount"" label=""currentSalaryAmount"" ></v-text-field>

<v-text-field v-model=""currentsalary.month"" label=""month"" ></v-text-field>

<v-text-field v-model=""currentsalary.year"" label=""year"" ></v-text-field>


          </v-card-text>
          <v-card-actions>
             <v-btn ");
            WriteLiteral("@click=\'add_currentsalary\' color=\'blue\' outlined>\n                <v-icon>\n                    mdi-content-save-edit\n                </v-icon>\n             </v-btn>\n          </v-card-actions>\n          \n        </v-card>\n    </v-app>\n</div>\n");
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
                    currentsalary:{}
                    ,
                    employees:[] ,
select_employee:{},
employeeSalaryMasters:[] ,
select_employeeSalaryMaster:{},

                }//edata
                ,
                created(){
                     this.employees = ");
#nullable restore
#line 75 "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\add.cshtml"
                                 Write(Html.Raw(Json.Serialize(@ViewBag.employees)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\nthis.select_employee = this.employees[0];\nthis.employeeSalaryMasters = ");
#nullable restore
#line 77 "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\add.cshtml"
                        Write(Html.Raw(Json.Serialize(@ViewBag.employeeSalaryMasters)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
this.select_employeeSalaryMaster = this.employeeSalaryMasters[0];

                }//ecreated
                ,
                methods:{
                  add_currentsalary(){
                   this.currentsalary.employeeId = this.select_employee.employeeId;
this.currentsalary.employeeSalaryMasterId = this.select_employeeSalaryMaster.employeeSalaryMasterId;

                    var url = '/currentsalary/add';
                    var param= this.currentsalary;
                    $.post(url,param)
                    .done(res =>{
                          if(res.error == -1){
                               //window.location = '/currentsalary/index';
                               console.log(param)
                          }
                          else{
                             alert(res.exception);
                          }
                    });
                    
                  }//emethod

                }//emethod
                ,
                 computed:{

                 }//eco");
                WriteLiteral("mputed\n            };\n            app = new Vue(component);\n\n\n    </script>\n\n");
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
