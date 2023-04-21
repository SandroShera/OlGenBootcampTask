
namespace OlGenBootcampTask
{
    public static class CheckUsernamePassword
    {
        private const string _username = "test";
        private const string _password = "Test123";


        public static void LogIn()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter username:");
                var normalizedUsername = Console.ReadLine().ToLower();
                Console.WriteLine("Enter password");
                var password = Console.ReadLine();

                if(normalizedUsername.Equals(_username) && password.Equals(_password))
                {
                    Console.WriteLine("Success");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password, try again");
                    continue;
                }
            }

            throw new Exception("Invalid credentials");
        }
    }
}
