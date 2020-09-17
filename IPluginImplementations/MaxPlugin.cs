using System;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin implementing calculating max of two numbers functionality
    /// </summary>
    class MaxPlugin : AbstractPlugin
    {
        public MaxPlugin()
        {
            PluginName = "Max";
            Version = "1.0.0";
            Description = "Возвращает наибольшее число из двух приведённых";
        }
        /// <summary>
        /// Returns highest number
        /// </summary>
        /// <param name="input1">Number</param>
        /// <param name="input2">Number</param>
        /// <returns>Highest number from input</returns>
        public override int Run(int input1, int input2)
        {
            return input1 > input2 ? input1 : input2;
        }
    }
}

