namespace Goal_Parser_Interpretation
{
    public class Goal_Parser_Interpretation
    {
        public Goal_Parser_Interpretation(string command) 
        {
            string commandWithO = GetStringWithO(command);
            string resultCommand = GetStringWithAL(commandWithO);

            Console.WriteLine(resultCommand);
        }

        private string GetStringWithO(string command) => command.Replace("()", "o");

        private string GetStringWithAL(string command) => command.Replace("(al)", "al");
    }
}
