using System;
using System.IO;

namespace Test_Service
{
    public static class Methods
    {
        public static void WriteMessage(string message)
        {
            using (var fileWriter = new StreamWriter(@"C:\LogTestFile.txt", true))
            {
                fileWriter.WriteLine(message);
            }
        }

        public static void WriteException(Exception ex)
        {
            using (var fileWriter = new StreamWriter(@"C:\LogTestFile.txt", true))
            {
                fileWriter.WriteLine("Exception Occured:");
                fileWriter.WriteLine(ex.Message);
            }
        }
    }
}
