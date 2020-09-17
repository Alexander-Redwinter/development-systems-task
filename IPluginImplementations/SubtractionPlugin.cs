using System;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin implementing subtraction of two numbers functionality
    /// </summary>
    class SubtractionPlugin : AbstractPlugin
    {
        public SubtractionPlugin()
        {
            PluginName = "Subtraction";
            Version = "1.0.0";
            Description = "Вычитает второе целочисленное число из первого. В случае переволнения int возвращает 0 и сообщает об ошибке.";
        }
        /// <summary>
        /// Divides two numbers
        /// </summary>
        /// <param name="input1">Number to divide</param>
        /// <param name="input2">Number to divide by</param>
        /// <returns>Product of division</returns>
        public override int Run(int input1, int input2)
        {
            try
            {
                return checked(input1 - input2);
            }
            catch
            {
                return OverflowError();
            }
        }
    }
}

