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

        public InfoCharLogic()
        {
            // Initialize the characters list by loading the data
            characters = LoadCharactersFromResources();
        }

        // Method to load characters from the embedded resource (XML)
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

                    loadedCharacters = (from character in xml.Elements("Character")
                                        select new Character
                                        {
                                            Name = character.Element("Name")?.Value,
                                            Description = character.Element("Description")?.Value
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

        // Method to get character description by name
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
