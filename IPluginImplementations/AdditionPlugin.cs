namespace ds.test.impl
{
    /// <summary>
    /// Plugin implementing two numbers addition functionality
    /// </summary>
    class AdditionPlugin : AbstractPlugin
    {

        public AdditionPlugin()
        {
            PluginName = "Addition";
            Version = "1.0.0";
            Description = "Складывает два целочисленных числа. В случае переволнения int возвращает 0 и сообщает об ошибке.";
        }
        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="input1">Number</param>
        /// <param name="input2">Number to add</param>
        /// <returns>Product of two numbers addition</returns>
        public override int Run(int input1, int input2)
        {
            try
            {
                return checked(input1 + input2);
            }
            catch
            {
               return OverflowError();
            }
        }
    }
}
