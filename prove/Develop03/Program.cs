using System;

Reference reference = new Reference("1Nephi", 3, 7);
string scripText = "And it came to pass that I, Nephi, said unto my father: father I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
Word word = new Word(scripText);

Scripture scripture = new Scripture(reference, word.GetDisplayText());

//loop to continue hidding words
while (true)
{
    //clear screen
    Console.Clear();

    // display scripture reference and text
    Console.WriteLine(scripture.GetDisplayText());

    //ask user for input and store it as ans
    Console.Write("\nPrompt the user to press the enter key or type quit. \n >");
    string ans = Console.ReadLine().ToLower();

    //check the input and the words if there completely hidden
    if (ans == "quit" || scripture.IsCompletelyHidden()) { break; }

    //hide three numbers
    scripture.HideRandomWords(3);
}