using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ITHS.NET.Peter.Palosaari.Lab4.Console
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            List<object> userInput = GetUserInput(args);
            var userCommand = (UserInputArg)userInput[0];

            switch (userCommand)
            {
                case UserInputArg.None:
                    PrintInstructions();
                    break;
                case UserInputArg.Lists:
                    HandleLists();
                    break;
                case UserInputArg.New:
                case UserInputArg.Add:
                    if (userInput[1].ToString() == "-new")
                        if (!HandleNew(userInput))
                            return;
                    HandleAdd(userInput);
                    break;
                case UserInputArg.Remove:
                    HandleRemove(userInput);
                    break;
                case UserInputArg.Words:
                    HandleWords(userInput);
                    break;
                case UserInputArg.Count:
                    HandleCount(userInput);
                    break;
                case UserInputArg.Practice:
                    HandlePractice(userInput);
                    break;
            }
        }

        private static void HandlePractice(List<object> userInput)
        {
            System.Console.WriteLine();
            WordList wordList = WordList.LoadList(userInput[2].ToString());
            if (wordList == null)
            {
                System.Console.WriteLine("\nThe list don't exist.\n");
                return;
            }
            Word word = wordList.GetWordToPractice();
            if (word == null)
            {
                System.Console.Write($"\nYou haven't added any words yet.\n");
                return;
            }

            System.Console.Write($"Translate the {wordList.Languages[word.FromLanguage]} word " +
                                 $"'{word.Translations[word.FromLanguage]}' to {wordList.Languages[word.ToLanguage]}: ");

            int nrOfQuestions = 0;
            int correctAnswers = 0;
            string input = System.Console.ReadLine()?.Trim().ToLower();

            while (input != string.Empty)
            {
                if (input == word.Translations[word.ToLanguage].Trim().ToLower())
                {
                    System.Console.WriteLine($"Correct answer!");
                    correctAnswers += 1;
                }
                else System.Console.WriteLine($"Wrong answer!");

                nrOfQuestions++;
                word = wordList.GetWordToPractice();
                System.Console.Write($"Translate the {wordList.Languages[word.FromLanguage]} word " +
                                     $"'{word.Translations[word.FromLanguage]}' to {wordList.Languages[word.ToLanguage]}: ");
                input = System.Console.ReadLine()?.Trim().ToLower();
            }

            if (nrOfQuestions == 0) System.Console.WriteLine("\nYou didn't answer any questions.\n");
            else
            {
                System.Console.WriteLine($"\nYou practiced {nrOfQuestions} words.");
                System.Console.WriteLine($"{((float)correctAnswers) / nrOfQuestions * 100:0.0}% of your answers were correct!\n");
            }
        }

        private static void HandleWords(List<object> userInput)
        {
            WordList wordList = WordList.LoadList(userInput[2].ToString());
            if (wordList == null)
            {
                System.Console.WriteLine($"\nThere is no list with name: '{userInput[2]}'.\n");
                return;
            }
            switch (userInput.Count)
            {
                case 4:
                    {
                        bool match = false;
                        for (int i = 0; i < wordList.Languages.Length; i++)
                        {
                            if (wordList.Languages[i] != userInput[3].ToString()) continue;
                            System.Console.WriteLine();
                            PrintLanguages(wordList.Languages);
                            match = true;
                            wordList.List(i, PrintWordsList);
                            wordList.Save();
                        }

                        System.Console.WriteLine();
                        if (!match)
                            System.Console.WriteLine($"\nThere is no language " + $"'{userInput[3]}' in list '{wordList.Name}'.\n");
                        break;
                    }
                case 3:
                    System.Console.WriteLine();
                    PrintLanguages(wordList.Languages);
                    wordList.List(0, PrintWordsList);
                    wordList.Save();
                    System.Console.WriteLine();
                    break;
            }
        }

        private static void PrintLanguages(string[] languages)
        {
            string o = string.Empty;
            foreach (string language in languages)
            {
                o += $"{language.ToUpper()}\t\t";
            }
            System.Console.WriteLine(o);
        }

        private static void PrintWordsList(string[] array)
        {
            string o = string.Empty;
            foreach (string t in array)
            {
                o += $"{t}\t\t";
            }
            System.Console.WriteLine(o);
        }

        private static void HandleRemove(List<object> userInput)
        {
            WordList wordList = WordList.LoadList(userInput[2].ToString());
            if (wordList != null)
            {
                System.Console.WriteLine();
                bool match = false;
                for (int i = 0; i < wordList.Languages.Length; i++)
                {
                    if (!wordList.Languages[i].Equals(userInput[3])) continue;
                    System.Console.WriteLine($"The following words were removed from list '{wordList.Name}':\n");

                    for (int j = 4; j < userInput.Count(); j++)
                    {
                        match = true;
                        if (!wordList.Remove(i, userInput[j].ToString())) continue;
                        System.Console.WriteLine($"- {userInput[j]}");
                        wordList.Save();
                    }

                    System.Console.WriteLine();
                }

                if (!match) System.Console.WriteLine($"\nThe language '{userInput[3]}' " +
                                                     $"could not be found in the list '{wordList.Name}'.\n");
            }
            else
                System.Console.WriteLine("\nThe file don't exist.\n");
        }

        private static void HandleLists()
        {
            string[] array = WordList.GetLists();

            System.Console.WriteLine();
            foreach (string element in array)
            {
                System.Console.WriteLine(element);
            }
            System.Console.WriteLine();
        }

        private static void HandleCount(List<object> userInput)
        {
            WordList wordList = WordList.LoadList(userInput[2].ToString());
            if (wordList == null)
            {
                System.Console.WriteLine("\nThe list don't exist.\n");
                return;
            }
            System.Console.WriteLine(
                $"\nThere are {wordList.Count()} words in list '{wordList.Name}'\n");
        }

        private static bool HandleNew(List<object> userInput)
        {
            WordList wordList = WordList.LoadList(userInput[2].ToString());

            if (wordList == null)
            {
                var lang = new string[userInput.Count() - 3];

                for (int j = 3; j < userInput.Count(); j++)
                {
                    lang[j - 3] = userInput[j].ToString();
                }

                wordList = new WordList(userInput[2].ToString(), lang);
                wordList.Save();
                return true;
            }
            else
            {
                System.Console.WriteLine("\nThe word list exists already. Please use another name or add words instead.\n");
                return false;
            }
        }

        private static void HandleAdd(List<object> userInput)
        {
            WordList wordList = WordList.LoadList(userInput[2].ToString());
            if (wordList == null)
            {
                System.Console.WriteLine($"\nThe list named '{userInput[2]}' doesn't exist. Please add it first.\n");
                return;
            }
            System.Console.WriteLine("\nPress enter (empty line) to stop input of new words.\n");
            var userStrings = new List<string>();
            int i = 1;
            int duplicates = 0;
            List<string> consoleTexts = CreateConsoleTextsWhenAddingWords(wordList);
            string input = ReturnAllowedStringsFromConsole(consoleTexts[i - 1], "Only letters and numbers are allowed.");

            while (input != string.Empty)
            {
                userStrings.Add(input);
                if (i % wordList.Languages.Length == 0) //modulo
                {
                    int countWordsBefore = wordList.Count();
                    wordList.Add(userStrings.ToArray());
                    wordList.Save();
                    int countWordsAfter = wordList.Count();
                    if (countWordsAfter != countWordsBefore + 1)
                    {
                        System.Console.WriteLine("\nNot added. The new word was already in the list.\n");
                        duplicates++;
                    }
                    userStrings.Clear();
                }
                i++;
                input = ReturnAllowedStringsFromConsole(consoleTexts[(i - 1) % wordList.Languages.Length],
                    "Only letters and numbers are allowed.");
            }

            System.Console.WriteLine($"\n{((i - 1) / wordList.Languages.Length) - duplicates} word(s) was added to list '{wordList.Name}'.\n");
        }

        private static string ReturnAllowedStringsFromConsole(string textToUser, string warning)
        {
            System.Console.Write(textToUser);
            string input = System.Console.ReadLine()?.Trim();
            while (input != null && ContainsNotAllowedCharacters(input))
            {
                System.Console.WriteLine(warning);
                System.Console.Write(textToUser);
                input = System.Console.ReadLine()?.Trim();
            }

            return input;
        }

        private static bool ContainsNotAllowedCharacters(string userInput)
        {
            var regex = new Regex(@"[^a-öA-Ö0-9\\s]");
            return regex.IsMatch(userInput);
        }

        private static List<string> CreateConsoleTextsWhenAddingWords(WordList wordList)
        {
            var output = new List<string> { $"Add new word ({wordList.Languages[0]}): " };

            for (int i = 1; i < wordList.Languages.Length; i++)
            {
                output.Add($"Add {wordList.Languages[i]} translation: ");
            }

            return output;
        }

        private static void PrintInstructions()
        {
            System.Console.Write("\nPlease use any of the following parameters:\n\n");
            System.Console.WriteLine("-lists");
            System.Console.WriteLine("-new <list name> <language 1> <language 2> .. <language n>");
            System.Console.WriteLine("-add <list name>");
            System.Console.WriteLine("-remove <list name> <language> <word 1> <word 2> .. <word n>");
            System.Console.WriteLine("-words <list name> <sortByLanguage>");
            System.Console.WriteLine("-count <list name>");
            System.Console.WriteLine("-practice <list name>\n");
        }

        private enum UserInputArg
        {
            None = 0, Lists = 1, New = 2, Add = 3, Remove = 4, Words = 5, Count = 6, Practice = 7
        }

        /// <summary>
        /// Returns userInputArg in the first index and matches in the following indexes.
        /// </summary>
        /// <param name="args">The arguments the user have inputted at command line</param>
        /// <returns></returns>
        private static List<object> GetUserInput(string[] args)
        {
            if (args.Length == 0 || string.Join(" ", args).Count(c => c == '-') > 1)
                return new List<object> { UserInputArg.None };

            var regexStrings = new Dictionary<UserInputArg, string>
            {
                {UserInputArg.Lists, @"^\s*-lists\s*$|^\s*-lists\s+|(?<=^\s*-lists\s+.*)\b[a-öA-Ö0-9]+\b"},
                {UserInputArg.New, @"^\s*-new\s*$|^\s*-new\s+|(?<=^\s*-new\s+.*)\b[a-öA-Ö0-9]+\b"},
                {UserInputArg.Add, @"^\s*-add\s*$|^\s*-add\s+|(?<=^\s*-add\s+.*)\b[a-öA-Ö0-9]+\b"},
                {UserInputArg.Remove, @"^\s*-remove\s*$|^\s*-remove\s+|(?<=^\s*-remove\s+.*)\b[a-öA-Ö0-9]+\b"},
                {UserInputArg.Words, @"^\s*-words\s*$|^\s*-words\s+|(?<=^\s*-words\s+.*)\b[a-öA-Ö0-9]+\b"},
                {UserInputArg.Count, @"^\s*-count\s*$|^\s*-count\s+|(?<=^\s*-count\s+.*)\b[a-öA-Ö0-9]+\b"},
                {UserInputArg.Practice, @"^\s*-practice\s*$|^\s*-practice\s+|(?<=^\s*-practice\s+.*)\b[a-öA-Ö0-9]+\b"},
            };

            string allArgs = string.Join(" ", args);
            var output = new List<object>();

            foreach (KeyValuePair<UserInputArg, string> keyValuePair in regexStrings)
            {
                var rgx = new Regex(keyValuePair.Value, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                if (!rgx.IsMatch(allArgs)) continue;

                List<string> matches =
                    rgx.Matches(allArgs).Cast<Match>().Select(m => m.Value.ToLower().Trim()).ToList();

                output.Add(keyValuePair.Key);
                output.AddRange(matches.ToList());

                return VerifyCorrectAmountOfUserArgs(output);
            }

            return new List<object> { UserInputArg.None };
        }

        /// <summary>
        /// Verify the correct number of user arguments.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        private static List<object> VerifyCorrectAmountOfUserArgs(List<object> userInput)
        {
            var userCommand = (UserInputArg)userInput[0];
            string helpText = string.Empty;

            switch (userCommand)
            {
                case UserInputArg.Lists:
                    if (userInput.Count - 1 == 1)
                        return userInput;
                    helpText = "argument 'Lists' doesn't take any parameters.";
                    break;
                case UserInputArg.Practice:
                case UserInputArg.Count:
                case UserInputArg.Add:
                    if (userInput.Count - 1 == 2)
                        return userInput;
                    helpText = "argument takes one parameter.";
                    break;
                case UserInputArg.Words:
                    if (userInput.Count - 1 == 3 || userInput.Count - 1 == 2)
                        return userInput;
                    helpText = "argument takes one or two parameters.";
                    break;
                case UserInputArg.Remove:
                case UserInputArg.New:
                    if (userInput.Count - 1 >= 4)
                        return userInput;
                    helpText = "argument takes at least three parameters.";
                    break;
            }

            System.Console.WriteLine($"\nError, the {helpText}");
            return new List<object> { UserInputArg.None };
        }
    }
}
