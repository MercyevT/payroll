#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\Clocking\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8271dea8baeb9f37af6b07008cc857d3519a91b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clocking_index), @"mvc.1.0.view", @"/Views/Clocking/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8271dea8baeb9f37af6b07008cc857d3519a91b2", @"/Views/Clocking/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_Clocking_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
          <v-row>
             <v-btn
              ");
            WriteLiteral(@"@click='add_clocking'
             >
                 Import Clocking    
             </v-btn>
             <div style=""width: 200px;"">
             <v-select
          :items=""department""
          label=""Standard""
          dense
          v-model=""depart""
        ></v-select>
        </div>
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
            label=""Picker in menu""
            prepend-icon=""mdi-calendar""
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
   ");
            WriteLiteral("         color=\"primary\"\n            ");
            WriteLiteral("@click=\"menu = false\"\n          >\n            Cancel\n          </v-btn>\n          <v-btn\n            text\n            color=\"primary\"\n            ");
            WriteLiteral("@click=\"$refs.menu.save(date);\"\n          >\n            OK\n          </v-btn>\n        </v-date-picker>\n      </v-menu>\n      </div>\n      <v-btn\n              ");
            WriteLiteral(@"@click='add_data'
             >
                 Search    
             </v-btn>
             <template>
  <div>
    <v-menu
      v-model=""menu2""
      :close-on-content-click=""false""
      :nudge-width=""200""
      offset-y
    >
      <template v-slot:activator=""{ on, attrs }"">
        <v-btn
          
          v-bind=""attrs""
          v-on=""on""
        >
          Setting
        </v-btn>
      </template>

      <v-card>
        <v-divider></v-divider>
        <v-list>
          <v-list-item>
            <v-list-item-title>Late allowance :</v-list-item-title>   
            <div style=""position: absolute; left: 175px;"">
            <input type=""number"" min=""1"" max=""60"" style=""border: 2px solid black;"" v-model=""on""> minute
            </div>
          </v-list-item>

          <v-list-item>
            <v-list-item-title>Late :</v-list-item-title>
            <div style=""position: absolute; left: 175px;"">
            <input type=""number"" min=""1"" max=""60"" style=""border: 2px solid black;"" v-model=""late"">");
            WriteLiteral(" minute\n            </div>\n          </v-list-item>\n        </v-list>\n\n        <v-card-actions>\n          <v-spacer></v-spacer>\n\n          <v-btn\n            text\n            ");
            WriteLiteral("@click=\"menu2 = false\"\n          >\n            Cancel\n          </v-btn>\n          <v-btn\n            color=\"primary\"\n            text\n            ");
            WriteLiteral(@"@click=""menu2 = false;check();""
          >
            Save
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-menu>
  </div>
</template>
      </v-row>
      <v-col cols=""12"">
            <v-card class=""ma-2"">
                    <v-card-title class=""primary white--text"">
                        <h3 style=""text-align: center"">Employees By Department</h3>
                    </v-card-title>
                    <v-card-text>
                    <v-chart :options=""plot"" style=""width: 100%; height: 500px;""/>
                    </v-card-text>
                </v-card>
            </v-col>
             <v-data-table
             :headers ='headers'
             :items   ='clocking'
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
      Vue.component('v-chart', VueECharts);
        var app;
            var component = {
                vuetify: new Vuetify()
                ,
                el:'#app1'
                ,
                data:{
              
                   clockings:[],workingTimes:[],clocking:[],onTime:[],LastTime:[],departments:[],department:[""All""],depart:"" "",work1:[],work2:[],work3:[]
                   ,
                   headers:[

                      {text:'employeeId',value:'employeeId',align:'center',sortable:true},
                      {text:'clockingIn',value:'clockingIn',align:'center',sortable:true},
                      {text:'breakIn',value:'breakIn',align:'center',sortable:true},
                      {text:'breakOut',value:'breakOut',align:'center',sortable:true},
                      {text:'clockingOut',value:'clockingOut',align:'center',sortable:true},
                      {text:'Date',value:'date',align:'center',sortable:true},
                      {text:'actions',value:'act");
                WriteLiteral(@"ions',align:'center',sortable:true}

					          ],
                    itemX:[""on Time"","" "","" ""],
                    itemY:[],
                    date: new Date().toISOString().substr(0, 10),
                    menu: false,
                    menu2: false,
                    on:0,
                    late:0,
                    
                    plot: {
                        toolbox: {
                            show: true,
                            feature: {
                                dataView: {
                                    show: true,
                                    readOnly: false,
                                    title: 'Data View'
                                },
                                magicType: {
                                    show: true,
                                    type: ['line', 'bar'],
                                    title: {
                                        line: ""Line"",
                                        bar: ""Bar"",
    ");
                WriteLiteral(@"                                }
                    
                                },
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
                        title: {
                            text: 'Employees',
                        },
                        tooltip: {},
                        legend: {
                            data: ['Employees'],
                        },
                        xAxis: {
                            data: [],
                            axisLabel: {
                                
                                textStyle: {
                                    color: '#4b2c20'
                ");
                WriteLiteral(@"                }
                            },
                    
                            axisTick: {
                                show: false
                            },
                            axisLine: {
                                show: false
                            },
                            z: 10
                        },
                        yAxis: [
                            {
                                type: 'value'
                            }
                        ]
                    }
                }//edata
                ,
                created(){
                    this.clockings = ");
#nullable restore
#line 254 "C:\Users\max_w\Desktop\projectpayroll\Views\Clocking\index.cshtml"
                                Write(Html.Raw(Json.Serialize(@ViewBag.clockings)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                    this.workingTimes = ");
#nullable restore
#line 255 "C:\Users\max_w\Desktop\projectpayroll\Views\Clocking\index.cshtml"
                                   Write(Html.Raw(Json.Serialize(@ViewBag.workingTimes)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                    this.departments = ");
#nullable restore
#line 256 "C:\Users\max_w\Desktop\projectpayroll\Views\Clocking\index.cshtml"
                                  Write(Html.Raw(Json.Serialize(@ViewBag.departments)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                    this.clocking =  this.clockings;   
                    console.log(this.workingTimes);
                    console.log(this.clocking);
                    

                    for(i=0;i<this.departments.length;i++){
                        this.department.push(this.departments[i].departmentName)
                    }
                    console.log(this.department);
                    
                    
                }//ecreated
                ,
                methods:{
                    add_clocking(){
                        window.location= '/clocking/importview';
                  
                        
                    }//ef
                    
                    ,
                    edit_clocking(item){
                        window.location = '/clocking/edit/'+item.clockingId;
                    }
                    ,
                    add_data(){
                      this.work1=[];
                       this.work2=[];
                       this.work3=");
                WriteLiteral(@"[];
                       this.itemX=[""on Time"",""Less than ""+this.late+"" minutes"",""more than ""+this.late+"" minutes""];
                       this.itemY=[];
                        console.log(this.date)
                        var mound=this.date.split(""-"");
                        var mound2={
                            day:mound[2],
                            month:mound[1],
                            year:mound[0]
                        }
                        if(this.depart==""All""||this.depart=="" ""){
                        this.clocking=this.clockings.filter(x=>x.date==mound2.day+""/""+mound2.month+""/""+mound2.year)
                        }
                        else{
                          this.clocking=this.clockings.filter(x=>x.date==mound2.day+""/""+mound2.month+""/""+mound2.year&&x.department==this.depart)
                        }
                        console.log(this.clocking)
                        console.log(this.depart)
                        for(i=0;i<this.clocking.length;i++){
   ");
                WriteLiteral(@"                       for(a=0;a<this.workingTimes.length;a++){
                          if(this.clocking[i].departmentId==this.workingTimes[a].departmentId
                              &&this.clocking[i].clockingIn.split("":"")[0]==this.workingTimes[a].start.split("":"")[0]
                              &&parseInt(this.clocking[i].clockingIn.split("":"")[1])<=this.on
                              ){
                            this.work1.push(this.clocking[i])
                          }
                          else if(this.clocking[i].departmentId==this.workingTimes[a].departmentId
                              &&this.clocking[i].clockingIn.split("":"")[0]==this.workingTimes[a].start.split("":"")[0]
                              &&parseInt(this.clocking[i].clockingIn.split("":"")[1])<=this.late
                              ){
                            this.work2.push(this.clocking[i])
                          }
                          else if(this.clocking[i].departmentId==this.workingTimes[a].departmentId
  ");
                WriteLiteral(@"                            &&this.clocking[i].clockingIn.split("":"")[0]==this.workingTimes[a].start.split("":"")[0]
                              &&parseInt(this.clocking[i].clockingIn.split("":"")[1])>this.late

                          ){
                            this.work3.push(this.clocking[i])
                          }
                          }
                        }
                        this.work1.sort((a,b) => { 
					              if(a.employeeId > b.employeeId) return 1;
					              else if(a.employeeId == b.employeeId) return 0; 
					              else return -1;
				                });
                        this.work2.sort((a,b) => { 
					              if(a.employeeId > b.employeeId) return 1;
					              else if(a.employeeId == b.employeeId) return 0; 
					              else return -1;
				                });
                        this.work3.sort((a,b) => { 
					              if(a.employeeId > b.employeeId) return 1;
					              else if(a.employeeId == b.empl");
                WriteLiteral(@"oyeeId) return 0; 
					              else return -1;
				                });
                          console.log(this.work1)
                          console.log(this.work2)
                          console.log(this.work3)
                          this.itemY=[this.work1.length,this.work2.length,this.work3.length]
                          console.log(this.itemX)
                          console.log(this.itemY)
                          this.plot.xAxis.data = this.itemX;
                    this.plot.series=[{
                            name: 'value',
                            type: 'bar',
                            data: this.itemY,
                            itemStyle: { color: '#81d4fa'
                            }
                        }];
                    console.log(this.plot);
                    }
                    ,
                    check(){
                            console.log(this.on)
                            this.itemX[1]=""Less than ""+this.late+"" minutes""
              ");
                WriteLiteral(@"              this.itemX[2]=""more than ""+this.late+"" minutes""
                            console.log(this.itemX)
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
