using System;

namespace PersonalEmailGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt for first name
                Console.Write("Enter your first name: ");
                string firstName = Console.ReadLine().Trim();

                // Prompt for last name
                Console.Write("Enter your last name: ");
                string lastName = Console.ReadLine().Trim();

                // Prompt for year of birth and ensure it's an integer
                Console.Write("Enter your year of birth: ");
                int yearOfBirth = int.Parse(Console.ReadLine().Trim());

                // Generate email address
                string email = GenerateEmail(firstName, lastName, yearOfBirth);

                // Print friendly message with generated email
                Console.WriteLine($"Hello {firstName} {lastName}, welcome to Robertson College!");
                Console.WriteLine($"Your new email address is {email}");
            }
            catch (FormatException)
            {
                Console.WriteLine("The year of birth must be an integer. Please restart the application and try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            // Wait for user to close the console
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static string GenerateEmail(string firstName, string lastName, int yearOfBirth)
        {
            // Get the first letter of the first name
            string firstInitial = firstName.Substring(0, 1).ToLower();

            // Convert the last name to lowercase
            lastName = lastName.ToLower();

            // Generate email address in the required format
            return $"{firstInitial}{lastName}{yearOfBirth}@robertsoncollege.ca";
        }
    }
}
