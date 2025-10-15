namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        { 
            int dogAge = 15;

            double avrDogYears = 13.5; //change for test

            decimal overLifeSpan = 2.5m;

            string dogName = "Rosco";

            char middleInitial = 'H';

            string lastName = "Weiler";

            bool isGoodDog = true;

            Console.WriteLine($"When I was a kid I had a dog named {dogName} {middleInitial} {lastName}. It is {isGoodDog} that he was a good dog.");
            Console.WriteLine($"{dogName} lived to be {dogAge} years old. The average lifespan of a dog is {avrDogYears} years, so {dogName} lived {overLifeSpan} years over the average lifespan of a dog.");
        }
    }
}
