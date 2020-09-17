using System;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin implementing calculating min of two numbers functionality
    /// </summary>
    class MinPlugin : AbstractPlugin
    {
        public MinPlugin()
        {
            PluginName = "Max";
            Version = "1.0.0";
            Description = "Возвращает наименьшее число из двух приведённых";
        }
        /// <summary>
        /// Returns lowest number
        /// </summary>
        /// <param name="input1">Number</param>
        /// <param name="input2">Number</param>
        /// <returns>Lowest number from input</returns>
        public override int Run(int input1, int input2)
        {
            return input1 > input2 ? input2 : input1;
        }
    }
}

