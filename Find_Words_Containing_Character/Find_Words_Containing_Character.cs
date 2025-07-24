namespace Find_Words_Containing_Character
{
    public class Find_Words_Containing_Character
    {
        public Find_Words_Containing_Character(string[] words, char x) 
        {
            List<int> result = new();

            for (int index = 0; index < words.Length; index++)
                foreach (char symbol in words[index])
                    if (symbol == x)
                    {
                        result.Add(index);
                        break;
                    }
            
            foreach (int number in result)
                Console.Write(number);

            Console.WriteLine();
        }
    }
}
