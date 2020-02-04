using System;

namespace RefOutTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region refKeyword
            string refMessage = "";
            string refMethod = GetRefTest(ref refMessage);
            Console.WriteLine(refMessage);
            Console.WriteLine(refMethod);

            #endregion

            #region outKeyword
            string outMethod = GetOutTest(out string outMessage);
            Console.WriteLine(outMessage);
            Console.WriteLine(outMethod);

            #endregion

            #region Tuple
            var tupleMethod = GetTupleTest("Richard");
            Console.WriteLine(tupleMethod.Hi);
            Console.WriteLine(tupleMethod.Message);

            #endregion

            Console.ReadKey();
        }

        private static (string Hi, string Message) GetTupleTest(string customer)
        {
            return ("Hi-" + customer, "Here is tuple method returns");
        }

        private static string GetOutTest(out string message)
        {
            message = "Message- Calling out inside methods";
            return "Calling Out Methods";
        }

        static string GetRefTest(ref string message)
        {
            message = "Message- Calling ref inside methods";
            return "Calling Ref Methods";
        }
    }
}
