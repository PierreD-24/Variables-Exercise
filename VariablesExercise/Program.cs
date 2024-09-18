namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Pierre";
            int age = 28;
            char lastInitial = 'D';
            bool genderMale = true;
            double height = 6.00;
            decimal dollarsInWallet = 20.50m;
            string gender = genderMale ? "Male" : "Female";

            Console.WriteLine($"Hello, my name is {name}, {lastInitial}. I am a {age} year old {gender}, {height} feet tall. I currently have {dollarsInWallet:C} in my wallet. ");
        }
    }
}
