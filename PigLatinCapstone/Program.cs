do
{
   
    //prompt user and take input    
    Console.WriteLine("Please enter a word.");
    string response = Console.ReadLine().Trim();


    bool isIncorrectInput = "!@#$%^^&*()1234567890".IndexOf(response) >= 0;
  

    //checking for incorrect inputs
    if (isIncorrectInput || response == "")
    {
        Console.WriteLine("Incorrect symbol or number detected. Please try another word.");
        continue;
    }

    //variables
    string sentence = "";

 
    //use IsUpper() method or IsLower() for the uppercase, titlecase, or lowercase

    //response typed out
    string[] words = response.Split(" ");
    foreach (string word in words)
    {

        sentence += pigTranslate(word) + " ";
    }
    Console.WriteLine(sentence);


    //ask user if they want to try again
    Console.WriteLine("Translate another line? (y/n)");
    if(Console.ReadLine().ToLower().Trim() == "y")
    {
        continue;
    }
    else
    {
        break;
    }

}
while (true);

static string pigTranslate(string word)
{

    string translatedWord = "";
    int vowelIndex = word.ToLower().IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });
    string first = word.Substring(0, vowelIndex);
    string last = word.Substring(vowelIndex);

    bool isVowel = "aeiouAEIOU".IndexOf(first) >= 0;

    
    if (isVowel)
    {
        return translatedWord += word + "way";
    }
    else
    {
        return translatedWord += last + first + "ay";
    }
}
            