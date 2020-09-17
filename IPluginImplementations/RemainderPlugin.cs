namespace ds.test.impl
{
    /// <summary>
    /// Plugin implementing calculating remainder of divison of two numbers functionality
    /// </summary>
    class RemainderPlugin : AbstractPlugin
    {
        public RemainderPlugin()
        {
            PluginName = "Remainder";
            Version = "1.0.0";
            Description = "Вычисляет остаток от деления первого целочисленного числа на второе.";
        }
        /// <summary>
        /// Remainder of two numbers division
        /// </summary>
        /// <param name="input1">Number to divide</param>
        /// <param name="input2">Number to divide by</param>
        /// <returns>Remainder of inputs division</returns>
        public override int Run(int input1, int input2)
        {
            try
            {
                return checked(input1 % input2);
            }
            catch
            {
                return OverflowError();
            }
        }
    }
}
