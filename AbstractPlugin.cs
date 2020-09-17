using System;
using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Abstract plugin class, implementing overflow error handling and property access
    /// </summary>
    internal abstract class AbstractPlugin : IPlugin
    {
        public string PluginName { get; protected set; }
        public string Version { get; protected set; }
        public Image Image { get; protected set; }
        public string Description { get; protected set; }

        public abstract int Run(int input1, int input2);

        /// <summary>
        /// Default <see cref="OverflowException"/> handler
        /// </summary>
        /// <returns></returns>
        public virtual int OverflowError()
        {
            Console.WriteLine("Input numbers too large, overflow error");
            return 0;
        }
        /// <summary>
        /// Checks input to prevent <see cref="DivideByZeroException"/>
        /// </summary>
        /// <returns></returns>
        public virtual bool CheckZero(int input)
        {
            if (input == 0)
            {
                Console.WriteLine("Divison by zero error.");
                return true;
            }
            else return false;
        }
    }
}
