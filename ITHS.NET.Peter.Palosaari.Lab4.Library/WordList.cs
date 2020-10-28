using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ITHS.NET.Peter.Palosaari.Lab4
{
    public class WordList
    {
        public WordList(string name, params string[] languages)
        {
            if (!(languages.Length > 1))
                throw new ArgumentException("Error, argument 'languages' array count must exceed 1.");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Error, argument 'name' is null or empty.");

            Name = name;
            Languages = languages;
            string AppFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Glosor";
            Directory.CreateDirectory(AppFolderPath);
        }

        public string Name { get; }
        public string[] Languages { get; }
        private static List<Word> Words { get; set; } = new List<Word>();

        public static WordList LoadList(string name)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + $"\\Glosor\\{name}.dat";
            if (!File.Exists(filePath))
            {
                Words.Clear();
                return null;
            }

            List<string> lines = File.ReadLines(filePath).ToList();

            string[] languages = lines[0]?.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            Words.Clear();
            for (int i = 1; i < lines.Count; i++)
            {
                Words.Add(new Word(lines[i]?.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)));
            }

            return new WordList(name, languages);
        }

        public void Save()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + $"\\Glosor\\{Name}.dat";
            using (var file = new StreamWriter(filePath, false))
            {
                foreach (string l in Languages)
                {
                    file.Write(l + ";");
                }
                file.Write(Environment.NewLine);

                if (Words == null) return;
                foreach (Word word in Words)
                {
                    foreach (string translation in word.Translations)
                    {
                        file.Write(translation + ";");
                    }
                    file.Write(Environment.NewLine);
                }
            }
        }

        public static string[] GetLists()
        {
            string AppFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Glosor";
            Directory.CreateDirectory(AppFolderPath);
            string[] lists = Directory.GetFiles(AppFolderPath, "*.dat",
                SearchOption.TopDirectoryOnly);
            var output = new string[lists.Length];

            for (int i = 0; i < lists.Length; i++)
            {
                output[i] += Path.GetFileNameWithoutExtension(lists[i]);
            }

            return output;
        }

        public void Add(params string[] translations)
        {
            translations = Array.ConvertAll(translations, p => p.ToLower());
            if (translations.Length != Languages.Length)
                throw new ArgumentException("Error, argument 'translations' array count is incorrect.");

            foreach (Word w in Words)
            {
                for (int j = 0; j < Languages.Length; j++)
                {
                    if (w.Translations[j] == translations[j]) return;
                }
            }
            Words.Add(new Word(translations));
        }

        public Word GetWordToPractice()
        {
            var rand = new Random();
            int randWord = rand.Next(0, Words.Count());
            int randFromLang = rand.Next(Languages.Length);
            int randToLang = rand.Next(Languages.Length);

            while (randFromLang == randToLang)
            {
                randToLang = rand.Next(Languages.Length);
            }

            if (Words.Count == 0) return null;

            var word = new Word(randFromLang, randToLang, Words[randWord].Translations);

            return word;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            if (sortByTranslation > Languages.Length || sortByTranslation < 0)
                throw new ArgumentException("Error, argument 'sortByTranslation' is too high or less than 0.");

            Words = Words.OrderBy(s => s.Translations[sortByTranslation]).ToList();
            foreach (Word w in Words) { showTranslations(w.Translations); }
        }

        public bool Remove(int translation, string word)
        {
            if (translation > Languages.Length || translation < 0)
                throw new ArgumentException("Error, argument 'translation' is too high or less than 0.");
            if (string.IsNullOrEmpty(word))
                throw new ArgumentException("Error, argument 'name' is null or empty.");

            bool containsWord = Words.Any(w => w.Translations[translation].Trim().ToLower() == word.Trim().ToLower());
            if (!containsWord) return false;
            int indexWord = Words.FindIndex(p => p.Translations[translation].Trim().ToLower() == word.Trim().ToLower());
            Words = Words.Where((w, i) => i != indexWord).ToList();

            return true;
        }

        public int Count()
        {
            return Words.Count();
        }
    }
}
