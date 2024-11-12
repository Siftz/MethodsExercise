namespace MethodsExercise
{
    public class Program
    {
        public static void MadLibLog()
        {
            Console.WriteLine("What is your name?");
            string randomName = Console.ReadLine();
            Console.WriteLine($"Hello, {randomName}! What is your favorite color?"); //color question
            //color response memory
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("I'll keep that in mind! What is your favorite animal?"); //Favorite Animal
            //Favorite Animal response memory
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("Awesome! What is your favorite band?"); //favorite Band
            //Favorite band Memory
            string favoriteBand = Console.ReadLine();
            // response for last question then story production
            Console.WriteLine($"Thank you, {randomName}! Let's make a story of your answers!");
            Console.WriteLine($"One day {randomName} turned into a {favoriteAnimal} and realized they had magically put on a T-shirt with {favoriteBand} on it and was {favoriteColor}. What a crazy day!");



        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
            
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        static void Main(string[] args)
        {
            MadLibLog();
            Console.WriteLine(Add(4, 4));      // 8
            Console.WriteLine(Subtract(5, 5)); // 0
            Console.WriteLine(Multiply(6, 6)); // 36
            Console.WriteLine(Divide(8, 8));   // 1
            
            
            
        }
    }
}
