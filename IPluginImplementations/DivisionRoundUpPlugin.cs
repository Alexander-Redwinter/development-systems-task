using System;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin implementing two numbers division with rounding up functionality
    /// </summary>
    class DivisionRoundUpPlugin : AbstractPlugin
    {

        public DivisionRoundUpPlugin()
        {
            PluginName = "DivisionRoundUp";
            Version = "1.0.0";
            Description = "Делит первое целочисленное число на второе и возвращает целочисленный результат, округлённый вверх." +
                " Деление на 0 возвращает 0 и сообщает об ошибке. В случае переволнения int возвращает 0 и сообщает об ошибке.";
        }
        /// <summary>
        /// Divides two numbers
        /// </summary>
        /// <param name="input1">Number to divide</param>
        /// <param name="input2">Number to divide by</param>
        /// <returns>Product of division, rounded up</returns>
        public override int Run(int input1, int input2)
        {
            if (CheckZero(input2))
                return 0;

            try
            {
                return checked((input1 - 1) / input2 + 1);
            }
            catch
            {
                return OverflowError();
            }
        }
    }
}
