// // // // // // if (6 >= 3){
// // // // // // Console.WriteLine("Hello, World!");
// // // // // // }


// // // // // Console.WriteLine("skriv ditt användarnamn");
// // // // // string användarnamn = Console.ReadLine();
// // // // // Console.WriteLine("skriv också in ditt lösenord");
// // // // // string lösenord = Console.ReadLine();



// // // // // if (användarnamn == "kalleanka" && lösenord == "12345")
// // // // // {
// // // // //     Console.WriteLine("välkommen in ");
// // // // // }
// // // // // else
// // // // // {
// // // // //     Console.WriteLine("nejsan mejsan");

// // // // // }
// // // // // Console.ReadLine();
// // // // int count = 0;
// // // // while (count < 32)
// // // // {
// // // //     Console.WriteLine("hello world");
// // // //     count++;
// // // // }



// // // // Console.ReadLine();
// // // string correctPassword = "lösenord123";
// // // string user;
// // // Console.WriteLine("Ange lösenord: ");
// // //     user = Console.ReadLine();
// // //       if (user != correctPassword)
// // //     {
// // //         Console.WriteLine("Fel lösenord, försök igen.");
// // //     }
// // // while (user!= correctPassword);

// // // Console.WriteLine("Rätt lösenord! Du är inloggad.");
// // for (int i = 0; i < 5; i++)
// // {
// //     Console.Write("Skriv in ett tal: ");
// //     string input = Console.ReadLine();
// //     int number = int.Parse(input); // Konverterar strängen till ett heltal
    
// //     if (number > 5)
// //     {
// //         Console.WriteLine("Högre än 5!");
// //     }
// // }

//         Random random = new Random();
//         int correctNumber = random.Next(1, 101); 
//         int userGuess = 0;

//         Console.WriteLine("Välkommen till 'Gissa siffran'! Gissa ett tal mellan 1 och 100.");

//         while (userGuess != correctNumber)
//         {
//             Console.Write("Skriv in din gissning: ");
//             string input = Console.ReadLine();

//             // Försöker konvertera input till ett heltal och hanterar felaktig inmatning
//             if (int.TryParse(input, out userGuess))
//             {
//                 if (userGuess < correctNumber)
//                 {
//                     Console.WriteLine("För lågt! Försök igen.");
//                 }
//                 else if (userGuess > correctNumber)
//                 {
//                     Console.WriteLine("För högt! Försök igen.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Grattis! Du gissade rätt!");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Ogiltig inmatning. Vänligen skriv in ett heltal.");
//             }
//         }
    
