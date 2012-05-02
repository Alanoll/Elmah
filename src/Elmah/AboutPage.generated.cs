#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elmah
{
    using System;
    using System.Collections.Generic;
    
    #line 2 "..\..\AboutPage.cshtml"
    using System.ComponentModel;
    
    #line default
    #line hidden
    
    #line 3 "..\..\AboutPage.cshtml"
    using System.IO;
    
    #line default
    #line hidden
    using System.Linq;
    
    #line 4 "..\..\AboutPage.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 5 "..\..\AboutPage.cshtml"
    using Elmah;
    
    #line default
    #line hidden
    
    #line 6 "..\..\AboutPage.cshtml"
    using Mannex.Collections.Generic;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.3.2.0")]
    internal partial class AboutPage : WebTemplateBase
    {
#line hidden

        #line 99 "..\..\AboutPage.cshtml"

    private Version GetVersion()
    {
        return GetType().Assembly.GetName().Version;
    }

    private Version GetFileVersion()
    {
        var version = (AssemblyFileVersionAttribute) Attribute.GetCustomAttribute(GetType().Assembly, typeof(AssemblyFileVersionAttribute));
        return version != null ? new Version(version.Version) : new Version();
    }

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








            
            #line 8 "..\..\AboutPage.cshtml"
  
    var basePageName = Request.ServerVariables["URL"];

    const string title = "About ELMAH";
    Layout = new Elmah.MasterPage
    {
        Context  = Context, /* TODO Consider not requiring this */
        Title    = title,
        SpeedBarItems = new[]
        {
            SpeedBar.Home.Format(basePageName),
            SpeedBar.Help,
            SpeedBar.About.Format(basePageName),
        },
    };

    var stamps = SccStamp.FindAll(typeof (ErrorLog).Assembly)
                          .OrderByDescending(s => s.Revision)
                          .ToArray();
        

            
            #line default
            #line hidden


WriteLiteral(@"

<script type='text/javascript' language='JavaScript'>
    function onCheckForUpdate(sender) {
        var script = document.createElement('script');
        script.type = 'text/javascript';
        script.language = 'JavaScript';
        script.src = 'http://elmah.googlecode.com/svn/www/update.js?__=' + (new Date()).getTime();
        document.getElementsByTagName('head')[0].appendChild(script);
        return false;
    }
    var ELMAH = {
        info: {
            version: '");


            
            #line 43 "..\..\AboutPage.cshtml"
                 Write(GetVersion());

            
            #line default
            #line hidden
WriteLiteral("\',\r\n            fileVersion: \'");


            
            #line 44 "..\..\AboutPage.cshtml"
                     Write(GetFileVersion());

            
            #line default
            #line hidden
WriteLiteral("\',\r\n            type: \'");


            
            #line 45 "..\..\AboutPage.cshtml"
              Write(Build.TypeLowercase);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n            status: \'");


            
            #line 46 "..\..\AboutPage.cshtml"
                Write(Build.Status);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n            framework: \'");


            
            #line 47 "..\..\AboutPage.cshtml"
                   Write(Build.Framework);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n            imageRuntime: \'");


            
            #line 48 "..\..\AboutPage.cshtml"
                      Write(Build.ImageRuntimeVersion);

            
            #line default
            #line hidden
WriteLiteral("\'\r\n        }\r\n    };\r\n</script>\r\n\r\n<h1 id=\"PageTitle\">");


            
            #line 53 "..\..\AboutPage.cshtml"
              Write(title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n<p>\r\n    <button class=\"btn\"\r\n        onclick=\"return onCheckForUpdate(t" +
"his)\"\r\n        title=\"Checks if your ELMAH version is up to date (requires Inter" +
"net connection)\">Check for Update</button>\r\n</p>\r\n\r\n<p>\r\n    This <strong>");


            
            #line 62 "..\..\AboutPage.cshtml"
            Write(Build.TypeLowercase);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    ");


            
            #line 63 "..\..\AboutPage.cshtml"
Write(stamps.Any() ? "(SCC #" + stamps.First().Revision.ToString("N0") + ")" : null);

            
            #line default
            #line hidden
WriteLiteral("\r\n    build was compiled from the following sources for CLR ");


            
            #line 64 "..\..\AboutPage.cshtml"
                                                     Write(Build.ImageRuntimeVersion);

            
            #line default
            #line hidden
WriteLiteral(":\r\n</p>\r\n\r\n");


            
            #line 67 "..\..\AboutPage.cshtml"
 foreach (var module in from m in Elmah.ExtensionHub.Modules
                        let mm = m.Module
                        let settings = m.Settings
                        select new
                        {
                            Name = mm.Name,
                            Settings = 
                                mm.HasSettingsSupport && settings != null
                                ? from PropertyDescriptor property in mm.SettingsDescriptor.GetProperties()
                                  select property.Name.AsKeyTo(property.GetValue(settings))
                                : null
                        })
{

            
            #line default
            #line hidden
WriteLiteral("    <h2>");


            
            #line 80 "..\..\AboutPage.cshtml"
   Write(module.Name);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");


            
            #line 81 "..\..\AboutPage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 81 "..\..\AboutPage.cshtml"
     if (module.Settings != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <dl>\r\n");


            
            #line 84 "..\..\AboutPage.cshtml"
         foreach (var pair in module.Settings)
        {

            
            #line default
            #line hidden
WriteLiteral("            <dt>");


            
            #line 86 "..\..\AboutPage.cshtml"
           Write(pair.Key);

            
            #line default
            #line hidden
WriteLiteral("</dt>");



WriteLiteral("<dd>");


            
            #line 86 "..\..\AboutPage.cshtml"
                             Write(pair.Value);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");


            
            #line 87 "..\..\AboutPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        </dl>\r\n");


            
            #line 89 "..\..\AboutPage.cshtml"
    }
            
            #line default
            #line hidden
            
            #line 89 "..\..\AboutPage.cshtml"
     
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<ul>\r\n");


            
            #line 93 "..\..\AboutPage.cshtml"
     foreach (var stamp in stamps)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li><code>");


            
            #line 95 "..\..\AboutPage.cshtml"
             Write(stamp.Id);

            
            #line default
            #line hidden
WriteLiteral("</code></li>        \r\n");


            
            #line 96 "..\..\AboutPage.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n");


WriteLiteral("\r\n");


        }
    }
}
#pragma warning restore 1591
