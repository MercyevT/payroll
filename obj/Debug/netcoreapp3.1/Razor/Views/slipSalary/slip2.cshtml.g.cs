#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f9d8f8b98bcbdf32700e308f61f2d340957f885"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_slipSalary_slip2), @"mvc.1.0.view", @"/Views/slipSalary/slip2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f9d8f8b98bcbdf32700e308f61f2d340957f885", @"/Views/slipSalary/slip2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_slipSalary_slip2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id='app1' v-cloak>

    <v-app>
         
        <v-card>
          <v-card-title class=""justify-center"" style=""font-size: 30px;"">
              Salary Slip
          </v-card-title>
          <v-card-text>
              <table  style=""font-size: 25px;""> 
              <tr>
                  <td class=""employee"">Employee Name</td>
                  <td class=""employee"">: {{employee.employeeName}}</td>
              </tr>
              <tr>
                  <td class=""employee"">Department</td>
                  <td class=""employee"">: {{employee.departmentName}}</td>
              </tr>
              <tr>
                  <td class=""employee"">Position</td>
                  <td class=""employee"">: {{employee.position}}</td>
              </tr>
              </table>
          </v-card-text>
          <div>
              <v-card>
                  <v-divider></v-divider>
                  sdasdad
              </v-card>
          </div>
          <v-card-actions>
         ");
            WriteLiteral("    <v-btn ");
            WriteLiteral(@"@click='edit_slipsalary' >
                Back
             </v-btn>
          </v-card-actions>
          
        </v-card>
    </v-app>
</div>
<style>
    td.employee {
  height: 50px;
}
    td.data2{
         margin: 0;
    padding: 0;
    border: 0;
    }
</style>
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
                    
                    employees:{},employee:[],departments:[],all:[],Earning:[],valueE:[],Deduction:[],valueD:[],slip:[]
                    
                    

                }//edata
                ,
                created(){
                  var Date2 = new Date();
                  this.ot           = ");
#nullable restore
#line 69 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml"
                                 Write(Html.Raw(Json.Serialize(@ViewBag.OTCs)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                  this.tax          = ");
#nullable restore
#line 70 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml"
                                 Write(Html.Raw(Json.Serialize(@ViewBag.taxs)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                  this.salary       = ");
#nullable restore
#line 71 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml"
                                 Write(Html.Raw(Json.Serialize(@ViewBag.CurrentSalarys)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                  this.ssf          = ");
#nullable restore
#line 72 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml"
                                 Write(Html.Raw(Json.Serialize(@ViewBag.ssfunds)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                  this.slipMaster   = ");
#nullable restore
#line 73 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml"
                                 Write(Html.Raw(Json.Serialize(@ViewBag.slipMasters)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                  this.employees    = ");
#nullable restore
#line 74 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml"
                                 Write(Html.Raw(Json.Serialize(@ViewBag.employee)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                  this.departments  = ");
#nullable restore
#line 75 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml"
                                 Write(Html.Raw(Json.Serialize(@ViewBag.departments)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                  console.log(Date2)
                  this.employee     =  {
                        employeeId      : this.employees.employeeId,
                        employeeName    : this.employees.firstName+"" ""+this.employees.lastName,
                        departmentName  : this.departments.filter(x=>x.departmentId==this.employees.departmentId)[0].departmentName,
                        position        : this.employees.position 
                  }
                  if(this.ot[0]==null){
                     this.all.push(this.tax[0],this.salary[0],this.ssf[0])
                  }
                  else{
                  this.all.push(this.ot[0],this.tax[0],this.salary[0],this.ssf[0])
                  }
                 for(i=0;i<this.all.length;i++){
                      for(a=0;a<this.slipMaster.length;a++){
                        if(this.all[i].slipMasterId==this.slipMaster[a].slipMasterId){
                            if(this.slipMaster[a].slipMasterType==1){
            ");
                WriteLiteral(@"                     this.Earning.push({
                                     title : this.slipMaster.filter(x=>x.slipMasterId==this.all[i].slipMasterId)[0].slipMasterName,
                                     value : this.all[i].value
                                 })
                            }
                            else{
                                
                                this.Deduction.push({
                                     title : this.slipMaster.filter(x=>x.slipMasterId==this.all[i].slipMasterId)[0].slipMasterName,
                                     value : this.all[i].value
                                 })
                                
                            }
                        }
                      }
                  }
                  
                  console.log(this.Earning)
                  console.log(this.slip)
                  
                  
                  //this.select_employee = ");
#nullable restore
#line 114 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml"
                                      Write(Html.Raw(Json.Serialize(@ViewBag.select_employee)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                  //this.slipMasters = ");
#nullable restore
#line 115 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml"
                                  Write(Html.Raw(Json.Serialize(@ViewBag.slipMasters)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                  //this.select_slipMaster = ");
#nullable restore
#line 116 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\slip2.cshtml"
                                        Write(Html.Raw(Json.Serialize(@ViewBag.select_slipMaster)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

                     
                }//ecreated
                ,
                methods:{
                  edit_slipsalary(){
                    window.location= '/slipsalary/index';
                    
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
