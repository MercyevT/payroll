#pragma checksum "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\export.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5363aabc35822737ef77698d75596991360ddbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_slipSalary_export), @"mvc.1.0.view", @"/Views/slipSalary/export.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5363aabc35822737ef77698d75596991360ddbe", @"/Views/slipSalary/export.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55231f8b2935cf16ee23a3deb1ef016831686df2", @"/Views/_ViewImports.cshtml")]
    public class Views_slipSalary_export : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id='app1' v-cloak>
    <div>
<button id=""btnPdf"">Create PDF</button>
</div>
    <div class=""imgc"">
                <v-img
      src=""https://mis3141001.s3-ap-southeast-1.amazonaws.com/picture/attach1.jpg""
      contain
     
        width=""1500px""
        style=""position: absolute; margin-left: -.5em; margin-top: -.5em;""
    >
    <div class=""num1""><!--เลขผู้เสีย-->
        1 2 3 4 5 6 7 8 9 1 2 3 4
    </div>
    </v-img> 
                
</div>
</div>

<style>
.imgc{
    margin: 0;
    position: relative;
    
    top: 50px;
    left: 25%;
    margin-left: -.5em;
    margin-top: -.5em;
}
.num1{
    margin: 0;
    position: absolute;
    top: 3.5%;
    left: 54%;
    margin-left: -.5em;
    margin-top: -.5em;
    font-size: 30px;
    
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
              
                   slipMasters:[]
                   ,
                   headers:[

                      {text:'slipMasterName',value:'slipMasterName',align:'center',sortable:true},
                      {text:'slipMasterType',value:'slipMasterType',align:'center',sortable:true},
                      {text:'actions',value:'actions',align:'center',sortable:true}

					]
                }//edata
                ,
                created(){
                  this.slipMasters = ");
#nullable restore
#line 65 "C:\Users\max_w\Desktop\projectpayroll\Views\slipSalary\export.cshtml"
                                Write(Html.Raw(Json.Serialize(@ViewBag.slipMasters)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                  print()
                }//ecreated
                ,
                methods:{
                    print(){
                         window.print();
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
