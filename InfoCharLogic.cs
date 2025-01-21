using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Reflection;

namespace starup
{
    public class InfoCharLogic
    {
        private List<Character> characters;
        private const string CharacterTag = "Character";
        private const string NameTag = "Name";
        private const string DescriptionTag = "Description";


        public InfoCharLogic()
        {
         
            characters = LoadCharactersFromResources();
        }

  //loads characters from xml
        private List<Character> LoadCharactersFromResources()
        {
            List<Character> loadedCharacters = new List<Character>();

            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                using (Stream stream = assembly.GetManifestResourceStream("starup.Resources.CharacterDescriptions.xml"))
                {
                    if (stream == null)
                    {
                        Console.WriteLine("Embedded resource not found.");
                        return loadedCharacters;
                    }

                    XElement xml = XElement.Load(stream);

                    loadedCharacters = (from character in xml.Elements(CharacterTag)
                                        select new Character
                                        {
                                            Name = character.Element(NameTag)?.Value,
                                            Description = character.Element(DescriptionTag)?.Value
                                        }).ToList();

                    Console.WriteLine($"Loaded {loadedCharacters.Count} characters.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading XML from resource: " + ex.Message);
            }

            return loadedCharacters;
        }

        // gets characrter´s description 
        public string GetCharacterDescription(string characterName)
        {
            var character = characters.FirstOrDefault(c => c.Name.Equals(characterName, StringComparison.OrdinalIgnoreCase));

            if (character == null)
            {
                Console.WriteLine($"Character {characterName} not found.");
                return "Character not found.";
            }
            else
            {
                return character.Description;
            }
        }
    }
}
