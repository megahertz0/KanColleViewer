﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grabacr07.KanColleViewer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("37564")]
        public int LocalProxyPort {
            get {
                return ((int)(this["LocalProxyPort"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.dmm.com/netgame/social/application/-/detail/=/app_id=854854/")]
        public global::System.Uri KanColleUrl {
            get {
                return ((global::System.Uri)(this["KanColleUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"body {
    margin:0;
    overflow:hidden;
}

#game_frame {
    position:fixed;
    left:50%;
    top:-16px;
    margin-left:-450px;
    z-index:1;
}

#flashWrap {
    position:free;
    z-index:1;
    margin:0;
}

#spacing_top, #sectionWrap {
    visibility: hidden !important;
    height:0 !important;
    display: none !important;
}")]
        public string OverrideStyleSheet {
            get {
                return ((string)(this["OverrideStyleSheet"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("333")]
        public double UIContentHight {
            get {
                return ((double)(this["UIContentHight"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8000")]
        public int FeatureBrowserEmulation {
            get {
                return ((int)(this["FeatureBrowserEmulation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/KCV-Localisation/KanColleViewer-Translations/ma" +
            "ster/")]
        public global::System.Uri XMLTransUrl {
            get {
                return ((global::System.Uri)(this["XMLTransUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/Yuubari/KanColleViewer/master/resources/Version" +
            ".xml")]
        public global::System.Uri KCVUpdateUrl {
            get {
                return ((global::System.Uri)(this["KCVUpdateUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("var flashQuality = function () {{\r\n    for (var objs = document.embeds, i = objs." +
            "length - 1; i >= 0; i--) {{\r\n        \t\t\r\n        var embedElem = document.create" +
            "Element(\'embed\');\r\n        var parentElem = objs[i].parentNode;\r\n        embedEl" +
            "em.setAttribute(\'quality\', \'{0}\');\r\n        embedElem.setAttribute(\'wmode\', \'{1}" +
            "\');\r\n        embedElem.setAttribute(\'type\', \'application/x-shockwave-flash\');\r\n " +
            "       embedElem.setAttribute(\'id\', objs[i].getAttribute(\'id\'));\r\n        embedE" +
            "lem.setAttribute(\'width\', objs[i].getAttribute(\'width\'));\r\n        embedElem.set" +
            "Attribute(\'height\', objs[i].getAttribute(\'height\'));\r\n        embedElem.setAttri" +
            "bute(\'src\', objs[i].getAttribute(\'src\'));\r\n        embedElem.setAttribute(\'bgcol" +
            "or\', objs[i].getAttribute(\'bgcolor\'));\r\n        embedElem.setAttribute(\'allowScr" +
            "iptAccess\', objs[i].getAttribute(\'allowScriptAccess\'));\r\n        embedElem.setAt" +
            "tribute(\'base\', objs[i].getAttribute(\'base\'));\r\n        parentElem.removeChild(o" +
            "bjs[i]);\r\n        parentElem.appendChild(embedElem);\r\n    }}\r\n    \r\n    for (obj" +
            "s = document.getElementsByTagName(\'object\'), i = objs.length - 1; i >= 0; i--) {" +
            "{\r\n        var embedElem = document.createElement(\'embed\');\r\n        var parentE" +
            "lem = objs[i].parentNode;\r\n        embedElem.setAttribute(\'quality\', \'{0}\');\r\n  " +
            "      embedElem.setAttribute(\'wmode\', \'{1}\');\r\n        embedElem.setAttribute(\'i" +
            "d\', objs[i].getAttribute(\'id\'));\r\n        embedElem.setAttribute(\'type\', \'applic" +
            "ation/x-shockwave-flash\'); \r\n        embedElem.setAttribute(\'width\', objs[i].get" +
            "Attribute(\'width\'));\r\n        embedElem.setAttribute(\'height\', objs[i].getAttrib" +
            "ute(\'height\'));       \r\n        \r\n        for (var c = objs[i].childNodes, j = c" +
            ".length - 1, set = false; j >= 0; j--) {{\r\n            if ((c[j].tagName == \'PAR" +
            "AM\') && (c[j].getAttribute(\'name\').toLowerCase() == \'src\'))\r\n                emb" +
            "edElem.setAttribute(\'src\', c[j].getAttribute(\'value\'));\r\n            else if ((c" +
            "[j].tagName == \'PARAM\') && (c[j].getAttribute(\'name\').toLowerCase() == \'movie\'))" +
            "\r\n                embedElem.setAttribute(\'src\', c[j].getAttribute(\'value\'));\r\n  " +
            "          else if ((c[j].tagName == \'PARAM\') && (c[j].getAttribute(\'name\').toLow" +
            "erCase() == \'bgcolor\'))\r\n                embedElem.setAttribute(\'bgcolor\', c[j]." +
            "getAttribute(\'value\'));\r\n            else if ((c[j].tagName == \'PARAM\') && (c[j]" +
            ".getAttribute(\'name\').toLowerCase() == \'allowscriptaccess\'))\r\n                em" +
            "bedElem.setAttribute(\'allowScriptAccess\', c[j].getAttribute(\'value\'));\r\n        " +
            "    else if ((c[j].tagName == \'PARAM\') && (c[j].getAttribute(\'name\').toLowerCase" +
            "() == \'base\'))\r\n                embedElem.setAttribute(\'base\', c[j].getAttribute" +
            "(\'value\'));\r\n        }}\r\n        \r\n        parentElem.removeChild(objs[i]);\r\n   " +
            "     parentElem.appendChild(embedElem);\r\n    }}\r\n}};\r\n\r\nvar TimedInject = setInt" +
            "erval(function () {{\r\n    CheckChange();\r\n}}, 100);\r\n\r\nfunction CheckChange() {{" +
            "\r\n    if (document.getElementById(\'flashWrap\').innerHTML.length > 10) {{\r\n      " +
            "  flashQuality();\r\n        clearInterval(TimedInject);\r\n    }}\r\n    else if (!do" +
            "cument.getElementById(\'flashWrap\'))\r\n        clearInterval(TimedInject);\r\n}}")]
        public string FlashQualityJS {
            get {
                return ((string)(this["FlashQualityJS"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<embed id=\"KCVGenerated\" width=\"800\" height=\"480\" wmode=\"{1}\" quality=\"{0}\" bgcol" +
            "or=\"#000\" allowScriptAccess=\"always\" type=\"application/x-shockwave-flash\" src=\"{" +
            "2}\">")]
        public string FlashEmbed {
            get {
                return ((string)(this["FlashEmbed"]));
            }
            set {
                this["FlashEmbed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://kcv.koumakan.jp/kcv/addstrings")]
        public string StringSubmitUrl {
            get {
                return ((string)(this["StringSubmitUrl"]));
            }
            set {
                this["StringSubmitUrl"] = value;
            }
        }
    }
}
