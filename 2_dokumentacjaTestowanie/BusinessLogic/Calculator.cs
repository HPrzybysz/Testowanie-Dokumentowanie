namespace BusinessLogic
{
    public class Calculator
    {
        /// <summary>
        /// method of addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b) 
        {
            checked
            {
                return a + b;
            }

        }
        /// <summary>
        /// method of substraction
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Sub(int a, int b)
        {
            return (a - b);
        }
    }
    
}
