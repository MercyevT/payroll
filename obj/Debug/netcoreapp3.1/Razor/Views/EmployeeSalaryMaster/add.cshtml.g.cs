#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\EmployeeSalaryMaster\add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87266e817be36a7c7a8c205f4bf8b261f5d7cb82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeSalaryMaster_add), @"mvc.1.0.view", @"/Views/EmployeeSalaryMaster/add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87266e817be36a7c7a8c205f4bf8b261f5d7cb82", @"/Views/EmployeeSalaryMaster/add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeSalaryMaster_add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav aria-label='breadcrumb'>
    <ol class='breadcrumb breadcrumb-arrow'>
        <li class='breadcrumb-item'><a href='/employeesalarymaster/index'>employeesalarymaster</a></li>
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
          v-model=""select_department""
          :items=""departments""
          item-text=""departmentName""
          menu-props=""auto""
          single-line
          label=""departmentId""
          show=""departmentName"" 
           
  ></v-select>

<v-text-field v-model=""employeesalarymaster.position"" label=""Position"" ></v-text-field>

<v-text-field v-model=""employeesalarymaster.employeestatus"" label=""employeestatus"" ></v-text-field>

<v-text-field v-model=""employeesalarymaster.basicSalary"" label=""Basic Salary"" ></v-text-field>

<v-text-field v-model=""employeesalarymaster");
            WriteLiteral(".salaryRate\" label=\"SalaryRate\" ></v-text-field>\n\n\n          </v-card-text>\n          <v-card-actions>\n             <v-btn ");
            WriteLiteral("@click=\'add_employeesalarymaster\' color=\'blue\' outlined>\n                <v-icon>\n                    mdi-content-save-edit\n                </v-icon>\n             </v-btn>\n          </v-card-actions>\n          \n        </v-card>\n    </v-app>\n</div>\n");
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
                    employeesalarymaster:{}
                    ,
                    departments:[] ,
select_department:{},

                }//edata
                ,
                created(){
                     this.departments = ");
#nullable restore
#line 64 "C:\Users\max_w\Desktop\projectpayroll\Views\EmployeeSalaryMaster\add.cshtml"
                                   Write(Html.Raw(Json.Serialize(@ViewBag.departments)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
this.select_department = this.departments[0];

                }//ecreated
                ,
                methods:{
                  add_employeesalarymaster(){
                   this.employeesalarymaster.departmentId = this.select_department.departmentId;

                    var url = '/employeesalarymaster/add';
                    var param= this.employeesalarymaster;
                    $.post(url,param)
                    .done(res =>{
                          if(res.error == -1){
                               window.location = '/employeesalarymaster/index';
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
