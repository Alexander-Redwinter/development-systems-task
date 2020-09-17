using System;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin implementing number to power of functionality
    /// </summary>
    class PowerPlugin : AbstractPlugin
    {
        public PowerPlugin()
        {
            PluginName = "Power";
            Version = "1.0.0";
            Description = "Возвращает первое число в степени второго. В случае переволнения int возвращает 0 и сообщает об ошибке.";
        }
        /// <summary>
        /// Puts first number to the power of second number
        /// </summary>
        /// <param name="input1">Number</param>
        /// <param name="input2">Power</param>
        /// <returns>Number to the power of second input</returns>
        public override int Run(int input1, int input2)
        {
            try
            {
                return checked((int)Math.Pow(input1, input2));
            }
            catch
            {
                return OverflowError();
            }
        }
    }
}

