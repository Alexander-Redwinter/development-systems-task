using System;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin implementing two numbers division with rounding down functionality
    /// </summary>
    class DivisionRoundDownPlugin : AbstractPlugin
    {
        public DivisionRoundDownPlugin()
        {
            PluginName = "DivisionRoundDown";
            Version = "1.0.0";
            Description = "Делит первое целочисленное число на второе и возвращает целочисленный результат, округлённый вниз." +
                " Деление на 0 возвращает 0 и сообщает об ошибке. В случае переволнения int возвращает 0 и сообщает об ошибке.";
        }
        /// <summary>
        /// Divides two numbers
        /// </summary>
        /// <param name="input1">Number to divide</param>
        /// <param name="input2">Number to divide by</param>
        /// <returns>Product of division, rounded down</returns>
        public override int Run(int input1, int input2)
        {
            if (CheckZero(input2))
                return 0;

            try
            {
                return checked(input1 / input2);
            }
            catch
            {
                return OverflowError();
            }
        }
    }
}
