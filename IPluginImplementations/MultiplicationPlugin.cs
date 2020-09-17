using System;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin implementing calculating product of two numbers functionality
    /// </summary>
    class MultiplicationPlugin : AbstractPlugin
    {

        public MultiplicationPlugin()
        {
            PluginName = "Multiplication";
            Version = "1.0.0";
            Description = "Умножает два целочисленных числа. В случае переполнения int возвращает 0 и сообщает об ошибке.";
        }
        /// <summary>
        /// Multiplies numbers
        /// </summary>
        /// <param name="input1">Number to multiply by</param>
        /// <param name="input2">Number to multiply by</param>
        /// <returns>Product of multiplication</returns>
        public override int Run(int input1, int input2)
        {
            try
            {
                return checked(input1 * input2);
            }
            catch
            {
                return OverflowError();
            }
        }
    }
}
