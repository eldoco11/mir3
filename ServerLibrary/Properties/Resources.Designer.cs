//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Server.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a &lt;html&gt;
        ///&lt;body&gt;
        ///
        ///&lt;form action=&quot;https://www.paypal.com/cgi-bin/webscr&quot; method=&quot;post&quot; target=&quot;_top&quot;&gt;
        ///&lt;input type=&quot;hidden&quot; name=&quot;custom&quot; value=&quot;$CHARACTERNAME$&quot;&gt;
        ///&lt;input type=&quot;hidden&quot; name=&quot;cmd&quot; value=&quot;_s-xclick&quot;&gt;
        ///&lt;input type=&quot;hidden&quot; name=&quot;hosted_button_id&quot; value=&quot;S8QAMCYTGM4SC&quot;&gt;
        ///&lt;table&gt;
        ///&lt;tr&gt;&lt;td&gt;&lt;input type=&quot;hidden&quot; name=&quot;on0&quot; value=&quot;Game Gold Quantity&quot;&gt;Game Gold Quantity&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;&lt;select name=&quot;os0&quot;&gt;
        ///	&lt;option value=&quot;500 Gold&quot;&gt;500 Gold £5.00 GBP&lt;/option&gt;
        ///	&lt;option value=&quot;1030 Gold (+3%)&quot;&gt;1030 Gol [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string BuyGameGold {
            get {
                return ResourceManager.GetString("BuyGameGold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a &lt;html&gt;
        ///&lt;body&gt;
        ///Failed to buy GameGold. Character Not Found.
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string CharacterNotFound {
            get {
                return ResourceManager.GetString("CharacterNotFound", resourceCulture);
            }
        }
    }
}
