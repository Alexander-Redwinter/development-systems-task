using System;
using System.Linq;

namespace ds.test.impl
{
    /// <summary>
    /// Static factory class for providing plugins
    /// </summary>
    public static class Plugins
    {
        #region Public Members
        public static int PluginsCount { get; private set; }
        public static string[] GetPluginNames { get; private set; }
        #endregion

        #region Private Members
        private static string _namespace = typeof(Plugins).Namespace;
        #endregion

        #region Constructor
        static Plugins()
        {
            var iPluginInterfaceType = typeof(IPlugin);

            //Get all types in this namespace that implement IPlugin but are not abstract
            GetPluginNames = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => iPluginInterfaceType.IsAssignableFrom(p) && !p.IsAbstract).Select(a => a.Name).ToArray();

            PluginsCount = GetPluginNames.Length;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Method returns <see cref="IPlugin"/> with specified name. If plugin with that name is not found, returns null and writes error to console
        /// </summary>
        /// <param name="pluginName">Name of plugin to return</param>
        /// <returns>New instance of plugin with specified name</returns>
        public static IPlugin GetPlugin(string pluginName)
        {
            if (!GetPluginNames.Contains(pluginName))
            {
                Console.WriteLine("Plugin does not exist: " + pluginName);
                return null;
            }
            try
            {
                Type type = Type.GetType($"{_namespace}.{pluginName}", true);
                return (IPlugin)Activator.CreateInstance(type);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion
    }
}
