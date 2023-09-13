namespace Topic_One_The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is very nice!
            //
            //
            //string sayHello = "Yo World!";
            //Console.WriteLine(sayHello);
            //sayHello = sayHello.Replace("Yo", "Greetings");
            //Console.WriteLine(sayHello);

            //Hello!


         

            string pleaseChoose, firstName, favMovie = "the matrix";
            Console.WriteLine("Please Choose, French or English");
            pleaseChoose = Console.ReadLine();
            pleaseChoose = pleaseChoose.ToLower();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            if (pleaseChoose == "english") 
            {
                Console.WriteLine("Choosing English");

            }
            if (pleaseChoose == "french")
            {
                Console.WriteLine("Choosing French...No I'm not you fool! I don't know French you fool! I'm choosing English for ya!");
            }
            if (pleaseChoose != "french" && pleaseChoose != "english")
            {
                Console.WriteLine("!USER DID NOT ANSWER 'Please Choose, French or English' CORRECTLY! Choosing default. Choosing English");
            }
            Console.WriteLine("Hello unknown user, you have not used our program before. Please create a name for your profile.");
            Console.WriteLine("Create name here below...");
            firstName = Console.ReadLine();
            Console.WriteLine("Thankyou user. Please wait while we setup your name.......");
            Thread.Sleep(3000);
            Console.Write($"Welcome {firstName} hope you are having a good day!");
            Console.Write("");
            Console.WriteLine($"{firstName} your favorite movie is {favMovie} and you may say, 'That isn't my favorite movie' Well yes it is so shut up!");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine($"A great question I've wanted to know for a while is does the movie {favMovie} have the word 'The' in it?");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Now don't fret, I'll figure that out for ya! If it does I'll say 'True' if not I'll say 'False'");
            favMovie = favMovie.ToUpper();
            Console.WriteLine($"{ favMovie.Contains("THE")}");
            Console.WriteLine($"Let's make all the A's @'s and all the E's 3's in {favMovie}");
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);
            Console.WriteLine("Now, how cool is that?!?!?!?!?!");



        }
    }
}