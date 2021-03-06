#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dffa7676c7ae9033a9c912bcf7fe62a25c6612a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CurrentSalary_index), @"mvc.1.0.view", @"/Views/CurrentSalary/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dffa7676c7ae9033a9c912bcf7fe62a25c6612a6", @"/Views/CurrentSalary/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_CurrentSalary_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav aria-label=""breadcrumb"">
    <ol class=""breadcrumb breadcrumb-arrow"">
        <li class=""breadcrumb-item active"" aria-current=""page"">currentSalary</li>
    </ol>
</nav>
<div id='app1' v-cloak>

    <v-app>
        <v-main>
            <v-btn
          ");
            WriteLiteral("@click=\"overlay = !overlay\"\n        >\n          Select Date: {{date}}\n        </v-btn>\n\n        <v-overlay\n          :value=\"overlay\"\n        >\n        <v-date-picker v-model=\"date\" type=\"month\"/>\n          <v-btn\n           ");
            WriteLiteral("@click=\"overlay = false;add_date(); \"\n          >\n            Submit\n          </v-btn>\n        </v-overlay>\n             <v-btn\n              ");
            WriteLiteral(@"@click='generate'
             >
                 Save
                 
             </v-btn>
             <v-data-table
             :headers ='headers'
             :items   ='currentSalarys'
              class='elevation-1'
             />
                  <template v-slot:item.actions='{item}'>
                        <v-btn 
                        class=""white--text""
                        color=""blue darken-1""
                        ");
            WriteLiteral(@"@click=""edit_currentsalary(item)""
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
                    absolute: true,
                    overlay: false,
                    date: null,
              
                   currentSalarys:[],employees:[],EmployeeSalaryMasters:[],currentSalaryss:[],filter1:[]
                   ,
                   headers:[

                      {text:'employeeId',value:'employeeId',align:'center',sortable:true},
                      {text:'employeeSalaryMasterId',value:'employeeSalaryMasterId',align:'center',sortable:true},
                      {text:'currentSalaryAmount',value:'currentSalaryAmount',align:'center',sortable:true},
                      {text:'month',value:'month',align:'center',sortable:true},
                      {text:'year',value:'year',align:'center',sortable:true},
                      {text:'actions',value:'actions',align:'center',sortable:true}

			");
                WriteLiteral("\t\t]\n                }//edata\n                ,\n                created(){\n                  this.currentSalarys = ");
#nullable restore
#line 81 "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\index.cshtml"
                                   Write(Html.Raw(Json.Serialize(@ViewBag.currentSalarys)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                  this.employees = ");
#nullable restore
#line 82 "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\index.cshtml"
                              Write(Html.Raw(Json.Serialize(@ViewBag.employees)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                  this.EmployeeSalaryMasters = ");
#nullable restore
#line 83 "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\index.cshtml"
                                          Write(Html.Raw(Json.Serialize(@ViewBag.EmployeeSalaryMasters)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

                  console.log(this.currentSalarys)
                  console.log(this.employees)
                  console.log(this.EmployeeSalaryMasters)
                }//ecreated
                ,
                methods:{
                    add_date(){
                        
                        var mound=this.date.split(""-"");
                        var mound2={
                            month:mound[1],
                            year:mound[0]
                        } 
                        this.currentSalaryss=[];
                        
                        for(i=0;i<this.employees.length;i++){
                            if(this.currentSalarys.find(x=>x.employeeId==this.employees[i].employeeId)){
                                this.filter1 =  this.EmployeeSalaryMasters.filter(x=>x.departmentId==this.employees[i].departmentId&&x.position==this.employees[i].position)
                                var p={
                                        employeeId              :   this.empl");
                WriteLiteral(@"oyees[i].employeeId,
                                        employeeSalaryMasterId  :   this.filter1[0].employeeSalaryMasterId,
                                        currentSalaryAmount     :   this.filter1[0].basicSalary*this.filter1[1].salaryRate,
                                        month                   :   mound2.month,
                                        year                    :   parseInt(mound2.year)
                                }  
                            this.currentSalaryss.push(p);
                            }
                            else{
                                this.filter1 =  this.EmployeeSalaryMasters.filter(x=>x.departmentId==this.employees[i].departmentId&&x.position==this.employees[i].position)
                                var p={
                                        employeeId              :   this.employees[i].employeeId,
                                        employeeSalaryMasterId  :   this.filter1[0].employeeSalaryMasterId,
                      ");
                WriteLiteral(@"                  currentSalaryAmount     :   this.filter1[0].basicSalary*this.filter1[0].salaryRate,
                                        month                   :   mound2.month,
                                        year                    :   parseInt(mound2.year)
                                }  
                            this.currentSalaryss.push(p);
                            console.log(this.currentSalaryss);
                            }                  
                              
                            
                        }
                        this.currentSalarys=this.currentSalaryss;
                        console.log(this.currentSalaryss);
                        
                    }
                    ,
                    add_currentsalary(){
                        
                        
                        
                    }//ef
                    ,
                    generate(){
                        
                        var url = '/currents");
                WriteLiteral(@"alary/Edit';
                        var param= this.currentSalaryss;
                        for(i=0;i<param.length;i++){
                        $.post(url,param[i])
                        .done(res =>{
                          if(res.error == -1){
                               window.location = '/currentsalary/index';
                          }
                          else{
                             alert(res.exception);
                          }
                    });
                        }
                        
                    }
                    ,
                    edit_currentsalary(item){
                        window.location = '/currentsalary/edit/'+item.currentSalaryId;
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
