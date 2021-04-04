#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\ssfund\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7655d7eec33aa899db47b78778b748466adc0ca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ssfund_index), @"mvc.1.0.view", @"/Views/ssfund/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7655d7eec33aa899db47b78778b748466adc0ca7", @"/Views/ssfund/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_ssfund_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id='app1' v-cloak>

    <v-app style=""background-color:#EDF1F2; "">
        <v-main>
          <table style=""margin:20px""> 
            <tr>
              <td>
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
            label=""date""
            prepend-icon=""mdi-calendar""
            readonly
            v-bind=""attrs""
            v-on=""on""
          ></v-text-field>
        </template>
        <v-date-picker
          v-model=""date""
          type=""month""
          no-title
          scrollable
        >
          <v-spacer></v-spacer>
          <v-btn
            text
            color=""primary""
            ");
            WriteLiteral("@click=\"menu = false\"\n          >\n            Cancel\n          </v-btn>\n          <v-btn\n            text\n            color=\"primary\"\n            ");
            WriteLiteral("@click=\"$refs.menu.save(date);selectdate()\"\n          >\n            OK\n          </v-btn>\n        </v-date-picker>\n      </v-menu>\n      </div>\n              </td>\n              <td>\n                <v-btn\n              ");
            WriteLiteral(@"@click='save()'
             >
                Save
                 
             </v-btn>
              </td>
            
            <td>
              <div>
    <v-menu
      v-model=""menu2""
      :close-on-content-click=""false""
      :nudge-width=""300""
      offset-y
    >
      <template v-slot:activator=""{ on, attrs }"">
        <v-btn
          
          v-bind=""attrs""
          v-on=""on""
          rounded style=""color:white; background-color:#8C001A; margin:10px""
        >
          Setting
        </v-btn>
      </template>

      <v-card>
        <v-divider></v-divider>
        <v-list>
          <v-list-item>
            <v-list-item-title>Social security fund rate for employee :</v-list-item-title>   
            <div style=""position: absolute; left: 300px;"">
            <input type=""number"" style=""border: 2px solid black;width:50px;"" v-model=""ssfe""> %
            </div>
          </v-list-item>

          <v-list-item>
            <v-list-item-title>Social security fund rate for company :</v-li");
            WriteLiteral(@"st-item-title>
            <div style=""position: absolute; left: 300px;"">
            <input type=""number"" style=""border: 2px solid black;width:50px;"" v-model=""ssfm""> %
            </div>
          </v-list-item>
        </v-list>

        <v-card-actions>
          <v-spacer></v-spacer>

          <v-btn
            text
            ");
            WriteLiteral("@click=\"menu2 = false\"\n          >\n            Cancel\n          </v-btn>\n          <v-btn\n            color=\"primary\"\n            text\n            ");
            WriteLiteral(@"@click=""menu2 = false;add_ssfund()""
          >
            Save
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-menu>
  </div>
            </td>
            </tr> 
          </table>
              <v-card class=""size"">
              <v-card-text style=""background-color:#F5F5F5"">
                
                <v-chart :options=""option"" style=""width: 100%; height:500px;"" :series=""pieEs""/>
                <v-chart :options=""option"" style=""width: 100%; height:500px;""  :series=""pieMs""/>
            </v-card-text>
            <br>
             <v-data-table
             :headers ='headers'
             :items   ='ssfund'
              class='elevation-1'
             />
                  <template v-slot:item.actions='{item}'>
                        <v-btn 
                        class=""white--text""
                        color=""blue darken-1""
                        ");
            WriteLiteral(@"@click=""edit_ssfund(item)""
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
       
            var component ={
                vuetify: new Vuetify()
                ,
                el:'#app1'
                ,
                data:{
                  
                  
                    date: new Date().toISOString().substr(0, 7),
                    menu: false,menu2:false,
                   
                   ssfunds:[],employee:[],salary:[],ssfund:[],ssfundDB:[]
                   ,
                   headers:[

                      {text:'Employee Nmae',value:'employeeName',align:'left',sortable:true},      
                      {text:'Employee Social Security Funds',value:'amountE',align:'left',sortable:true},
                      {text:'Company Social Security Funds',value:'amountM',align:'left',sortable:true},
                      {text:'Month',value:'month',align:'left',sortable:true},
                      {text:'Year',value:'year',align:'left',sortable:true},
					          ]
    ");
                WriteLiteral(@"                ,
                  pieEs:[]
                  ,
                  pieMs:[]
                  ,
                    ssfe:5,
                    ssfm:5
                   ,
                   test:[]
                  ,
                    option: {
                      
                      toolbox: {
                            show: true,
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
                        
    
                    title: [{
                        text: 'The Pure Water & Ice Company Limited',
                        subtext1:"""",
                        lef");
                WriteLiteral(@"t: 'center',
                        
                        textStyle: {
                                      fontWeight: ""bold"",
                                      fontSize: 40,
                                      
                                    },
                        subtextStyle: {
                                      fontWeight: ""bold"",
                                      
                                      fontSize: 25,
                                      color:""black""
                                      
                                    }
                    }, {
                        subtext: 'Employees',
                        left: '25%',
                        top: '90%',
                        textAlign: 'center',
                        subtextStyle: {
                        fontWeight: ""bold"",
                        fontSize: 25,
                        color:""#1D1D1D""
            
          }
                        
                        
                 ");
                WriteLiteral(@"   }, {
                        subtext: 'Company',
                        left: '80%',
                        top: '90%',
                        textAlign: 'center',
                        subtextStyle: {
                        fontWeight: ""bold"",
                        fontSize: 25,
                        color:""#1D1D1D""
            
          }
                    } ],
                    series: [
                    {
                        type: 'pie',
                        radius: '40%',
                        center: [ '25%', '40%'],
                        data: [],
                        label: {
                          position: 'outer',
                          alignTo: 'amount',
                          bleedMargin: 5
                          
                      },
                        left: 0,
                        right: '66.6667%',
                        top: 0,
                        bottom: 0
                    }, {
                        type: 'pie',
           ");
                WriteLiteral(@"             radius: '40%',
                        center: ['80%', '40%'],
                        data: [],  
                        label: {
                            position: 'outer',
                            alignTo: 'amount2',
                            bleedMargin: 5
                        },
                        left: '33.3333%',
                        right: '33.3333%',
                        top: 0,
                        bottom: 0
                    }]
                 }//eoption
                  ,
                  }//edata
                  ,
                    
                created(){
                  this.ssfunds = ");
#nullable restore
#line 284 "C:\Users\max_w\Desktop\projectpayroll\Views\ssfund\index.cshtml"
                            Write(Html.Raw(Json.Serialize(@ViewBag.ssfunds)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                  this.employee = ");
#nullable restore
#line 285 "C:\Users\max_w\Desktop\projectpayroll\Views\ssfund\index.cshtml"
                             Write(Html.Raw(Json.Serialize(@ViewBag.employees)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                  this.salary = ");
#nullable restore
#line 286 "C:\Users\max_w\Desktop\projectpayroll\Views\ssfund\index.cshtml"
                           Write(Html.Raw(Json.Serialize(@ViewBag.currentSalarys)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                  var mound=this.date.split(""-"");
                        var mound2={
                            month:parseInt(mound[1]),
                            year:parseInt(mound[0])
                        }
                  this.ssfund=this.ssfunds;
                  console.log(this.salary)
                  console.log(this.ssfund)
                  for(i=0;i<this.employee.length;i++){
                      this.ssfund[i].month=select(parseInt(this.ssfunds[i].month))
                  }
                  this.pieEs = ");
#nullable restore
#line 298 "C:\Users\max_w\Desktop\projectpayroll\Views\ssfund\index.cshtml"
                          Write(Html.Raw(Json.Serialize(@ViewBag.pieE)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n                  this.pieMs =");
#nullable restore
#line 299 "C:\Users\max_w\Desktop\projectpayroll\Views\ssfund\index.cshtml"
                         Write(Html.Raw(Json.Serialize(@ViewBag.pieM)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                  console.log(this.pieEs,'pieE');
                  console.log(this.pieMs,'pieM');
                  this.test= [{value: 108, name: '75'}]
                  console.log(this.pieEs);
                  console.log(this.test);
                  this.option.title[0].subtext=""Social Security Funds""+mound2.year+"" ""+select(mound2.month)
                  this.option.series=[{
                            type: 'pie',
                        radius: '60%',
                        center: [ '25%', '50%'],
                        data: this.pieEs,
                        label: {
                formatter: '{hr|}\n  {b|{b}} ({per|{d}%}) ',
                backgroundColor: '#F6F8FC',
                borderColor: '#8C8D8E',
                borderWidth: 1,
                borderRadius: 4,
                
                rich: {
                    
                    hr: {
                        borderColor: '#8C8D8E',
                        width: '100%',
                        borderWidth: 1,
    ");
                WriteLiteral(@"                    height: 0
                    },
                    b: {
                        color: '#4C5058',
                        fontSize: 14,
                        fontWeight: 'bold',
                        lineHeight: 33
                    },
                    per: {
                        color: '#4C5058',
                        
                        padding: [3, 4],
                        borderRadius: 4
                    }
                }
            },
                        left: 0,
                        right: '66.6667%',
                        top: 0,
                        bottom: 0
                            
                        },
                        {
                        type: 'pie',
                        radius: '60%',
                        center: ['80%', '50%'],
                        data: this.pieMs,  
                        label: {
                formatter: '{hr|}\n  {b|{b}} ({per|{d}%}) ',
                backgroundColor: '#F6F8FC',
");
                WriteLiteral(@"                borderColor: '#8C8D8E',
                borderWidth: 1,
                borderRadius: 4,
                
                rich: {
                    
                    hr: {
                        borderColor: '#8C8D8E',
                        width: '100%',
                        borderWidth: 1,
                        height: 0
                    },
                    b: {
                        color: '#4C5058',
                        fontSize: 14,
                        fontWeight: 'bold',
                        lineHeight: 33
                    },
                    per: {
                        color: '#4C5058',
                        
                        padding: [3, 4],
                        borderRadius: 4
                    }
                }
            },
                        left: '33.3333%',
                        right: '33.3333%',
                        top: 0,
                        bottom: 0
                    }];  
                     function");
                WriteLiteral(@" select(x){
                    if(x==1){
                        return ""January""
                    }
                    else if(x==2){
                        return  ""February""
                    }
                    else if(x==3){
                        return  ""March""
                    }
                    else if(x==4){
                        return  ""April""
                    }
                    else if(x==5){
                        return  ""May""
                    }
                    else if(x==6){
                        return  ""June""
                    }
                    else if(x==7){
                        return  ""July""
                    }
                    else if(x==8){
                        return  ""August""
                    }
                    else if(x==9){
                        return  ""September""
                    }
                    else if(x==10){
                        return  ""October""
                    }
                    else if(x==11){
   ");
                WriteLiteral(@"                     return  ""November""
                    }
                    else if(x==12){
                        return  ""December""
                    }

                  }
                 
               
                }//ecreated
                ,
                methods:{
                    add_ssfund(){
                        
                        var mound=this.date.split(""-"");
                        var mound2={
                            month:parseInt(mound[1]),
                            year:parseInt(mound[0])
                        } 
                        this.ssfundDB=[];
                        for(i=0;i<this.employee.length;i++){                  
                              this.filter1 =  this.salary.filter(x=>x.year==mound2.year)
                                var p={
                                        
                                        employeeId              :   this.employee[i].employeeId,
                                        amountE              ");
                WriteLiteral(@"   :   this.filter1[i].currentSalaryAmount*this.ssfe/100,
                                        amountM	                :   this.filter1[i].currentSalaryAmount*this.ssfm/100,
                                        month                   :   mound2.month,
                                        year                    :   mound2.year,
                                        ssfundMR                :   this.ssfm,
                                        ssfundER                :  this.ssfe
                                }  
                            this.ssfundDB.push(p);
                            
                        }
                        for(i=0;i<this.ssfundDB.length;i++){
                            if(this.ssfundDB[i].amountE>(15000*this.ssfe/100)){
                                this.ssfundDB[i].amountE=(15000*this.ssfe/100);
                            }
                        }
                        for(i=0;i<this.ssfundDB.length;i++){
                            if(this.ssfundDB[i].");
                WriteLiteral(@"amountM>(15000*this.ssfm/100)){
                                this.ssfundDB[i].amountM=(15000*this.ssfm/100);
                            }
                        }
                        console.log(this.ssfundDB)
                        
                  
                    
                    }//ef
                    ,
                    save(){
                        var url = '/ssfund/Edit';
                        var param= this.ssfundDB;
                        for(i=0;i<param.length;i++){
                        $.post(url,param[i])
                        .done(res =>{
                          if(res.error == -1){
                               window.location = '/ssfund/index';
                          }
                          else{
                            alert(res.exception);
                          }
                    });
                        }
                    }
                    ,
                    selectdate(){
                      var mound=this.date.split(""");
                WriteLiteral(@"-"");
                        var mound2={
                            month:parseInt(mound[1]),
                            year:parseInt(mound[0])
                        } 
                        this.ssfund=[];
                        
                        this.ssfund=this.ssfunds.filter(x=>x.year==mound2.year&&x.month==mound2.month)
                        for(i=0;i<this.ssfund.length;i++){
                      this.ssfund[i].month=select(mound2.month)
                  }

                        function select(x){
                    if(x==1){
                        return ""January""
                    }
                    else if(x==2){
                        return  ""February""
                    }
                    else if(x==3){
                        return  ""March""
                    }
                    else if(x==4){
                        return  ""April""
                    }
                    else if(x==5){
                        return  ""May""
                    }
           ");
                WriteLiteral(@"         else if(x==6){
                        return  ""June""
                    }
                    else if(x==7){
                        return  ""July""
                    }
                    else if(x==8){
                        return  ""August""
                    }
                    else if(x==9){
                        return  ""September""
                    }
                    else if(x==10){
                        return  ""October""
                    }
                    else if(x==11){
                        return  ""November""
                    }
                    else if(x==12){
                        return  ""December""
                    }

                  }
                        

                    }
                     ,
                     
                    edit_ssfund(item){
                        window.location = '/ssfund/edit/'+item.ssfundId;
                    }

                }//emethods
                ,
                computed:{

                }//");
                WriteLiteral("ecomputed\n                ,\n                \n            };\n            app = new Vue(component);\n\n\n    </script>\n\n");
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