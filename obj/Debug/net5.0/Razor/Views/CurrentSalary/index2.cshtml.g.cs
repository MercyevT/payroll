#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e52ef292d51955a0e5ac15982033506dfb44114e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CurrentSalary_index2), @"mvc.1.0.view", @"/Views/CurrentSalary/index2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52ef292d51955a0e5ac15982033506dfb44114e", @"/Views/CurrentSalary/index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_CurrentSalary_index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id='app1' v-cloak>

    <v-app>
        <v-main>
          <v-container>
          <v-row justify=""space-around"">
          
            <div style=""width: 200px;"">
             <v-menu
        ref=""menu""
        v-model=""menu""
        :close-on-content-click=""false""
        :return-value.sync=""date""
        transition=""scale-transition""
        offset-y
        min-width=""auto""
      >
        <template v-slot:activator=""{ on, attrs }"">
          <v-text-field
            v-model=""date""
            label=""Date:""
           
            readonly
            v-bind=""attrs""
            v-on=""on""
          ></v-text-field>
        </template>
        <v-date-picker
          v-model=""date""
          no-title
          scrollable
        >
          <v-spacer></v-spacer>
          <v-btn
            text
            color=""primary""
            ");
            WriteLiteral("@click=\"menu = false\"\n          >\n            Cancel\n          </v-btn>\n          <v-btn\n            text\n            color=\"primary\"\n            ");
            WriteLiteral(@"@click=""$refs.menu.save(date);add_date();""
          >
            OK
          </v-btn>
        </v-date-picker>
      </v-menu>
      </div>
      
        <div>
        Search By ID: <input type=""text"" v-model=""searchby"" style=""border: 2px solid black;"">
      </div>
      
        <v-btn
              ");
            WriteLiteral("@click=\"search\"\n             >\n                 search\n             </v-btn>\n      \n        <v-btn\n              ");
            WriteLiteral(@"@click='Import'
             >
                 Import
                 
             </v-btn>
             </v-row>
             </v-container>
             
             <v-col cols=""12"">
               <div id=""Hsalary"">
            <v-card class=""ma-2"">
                    <v-card-title class=""primary white--text"">
                        <h3 style=""text-align: center"">Employees Salary History</h3>
                    </v-card-title>
                    <v-card-text>
                    <v-chart :options=""option"" style=""width: 100%; height: 500px;""/>
                    </v-card-text>
                </v-card>
                </div>
            </v-col>
             <v-data-table
             :headers ='headers'
             :items   ='currentSalarysss'
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
       Vue.component('v-chart', VueECharts);
        var app;
            var component = {
                vuetify: new Vuetify()
                ,
                el:'#app1'
                ,
                data:{
                    
              
                   currentSalarys:[],employees:[],EmployeeSalaryMasters:[],currentSalaryss:[],filter1:[],Today:[],currentSalarysss:[]
                   ,
                   searchby:"" ""
                   ,
                   headers:[

                      {text:'Employee Name',value:'employeeName',align:'left',sortable:true},

                      {text:'Current Salary Amount',value:'currentSalaryAmount',align:'left',sortable:true},
                      {text:'year',value:'year',align:'left',sortable:true},
                      

					]
                    ,
                    date: new Date().toISOString().substr(0, 10),
                    menu: false,
                    option : {
                      toolbox: {
                      ");
                WriteLiteral(@"      show: true,
                            feature: {         
                                restore: {
                                    show: true,
                                    title: 'restore'
                                },
                                saveAsImage: {
                                    show: true,
                                    title: 'save image'
                                }
                            }
                        },
    xAxis: {
        type: 'category',
        data: []
    },
    yAxis: {
        type: 'value'
    },
    series: [{
        data: [],
        type: 'line'
    }]
}
                }//edata
                ,
                created(){
                  this.Today=this.date
                  var mound=this.Today.split(""-"");
                        var mound2={
                            month:parseInt(mound[1]),
                            year:parseInt(mound[0])
                        }
                        
               ");
                WriteLiteral("   this.currentSalarys = ");
#nullable restore
#line 169 "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\index2.cshtml"
                                   Write(Html.Raw(Json.Serialize(@ViewBag.currentSalarys)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                  this.employees = ");
#nullable restore
#line 170 "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\index2.cshtml"
                              Write(Html.Raw(Json.Serialize(@ViewBag.employees)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                  this.EmployeeSalaryMasters = ");
#nullable restore
#line 171 "C:\Users\max_w\Desktop\projectpayroll\Views\CurrentSalary\index2.cshtml"
                                          Write(Html.Raw(Json.Serialize(@ViewBag.EmployeeSalaryMasters)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                  this.currentSalaryss=this.currentSalarys;
                  console.log(this.currentSalarys)
                  function numberWithCommas(x) {
                  return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, "","");
                  }
                  for(i=0;i<this.currentSalaryss.length;i++){
                      this.currentSalaryss[i].currentSalaryAmount=numberWithCommas(this.currentSalaryss[i].currentSalaryAmount.toFixed(2))
                  }
                   
                   this.currentSalarysss=this.currentSalaryss.filter(x=>x.year==parseInt(mound2.year));
                   
                   
                  
                    console.log((1000).toFixed(2));
                  console.log()
                  
                  console.log(this.EmployeeSalaryMasters)
                  
                  
                }//ecreated
                ,
                methods:{
                    add_date(){
                        
                        var mound");
                WriteLiteral(@"=this.date.split(""-"");
                        var mound2={
                            month:parseInt(mound[1]),
                            year:parseInt(mound[0])
                        } 
                        
                       
                        
                        
                        
              
                        
                    }
                    ,
                    add_currentsalary(){
                        
                        
                        
                    }//ef
                    ,
                    Import(){
                        
                        window.location = '/currentsalary/importview/';
                        
                    }
                    ,
                    search(){
                      var mound=this.date.split(""-"");
                        var mound2={
                            month:parseInt(mound[1]),
                            year:parseInt(mound[0])
                        } 
         ");
                WriteLiteral(@"             console.log(this.searchby)
                      if(this.searchby==""""||this.searchby=="" ""){
                      this.currentSalarysss=this.currentSalaryss.filter(x=>x.year==parseInt(mound2.year))
                      }
                      else{
                        this.currentSalarysss=this.currentSalaryss.filter(x=>x.employeeId==parseInt(this.searchby))
                      }
                     
                      console.log(parseInt(this.currentSalarysss[0].currentSalaryAmount.replace("","", """")))
                      var x=[];
                      var y=[];
                      for(i=0;i<this.currentSalarysss.length;i++){  
                          x.push(this.currentSalarysss[i].year);
                          y.push(parseInt(this.currentSalarysss[i].currentSalaryAmount.replace("","", """")))
                      }
                      console.log(x)
                      console.log(y)
                      this.option.xAxis.data = x;
                    this.option.series=[");
                WriteLiteral(@"{
                            name: 'value',
                            type: 'line',
                            label: {
                show: true,
                position: 'top'
            },
                            data: y,
                            itemStyle: { color: '#4594E3'
                            }
                        },
                        ]

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
