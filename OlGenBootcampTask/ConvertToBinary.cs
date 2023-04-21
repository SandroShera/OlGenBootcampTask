
namespace OlGenBootcampTask
{
    public static  class ConvertToBinary
    {
        public static void ConvertIntToBinary()
        {
            int number = default;
            Console.WriteLine("Enter int32 to convert: ");

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Please provide valid int32");
            }


            Console.WriteLine(Convert.ToString(number, 2));
        }
    }
}
