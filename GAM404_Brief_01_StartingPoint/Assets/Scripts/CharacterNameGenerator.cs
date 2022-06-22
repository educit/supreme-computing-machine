using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - Generate Names
/// </summary>
public class CharacterNameGenerator : MonoBehaviour
{
 
    [Header("Possible first names")]
    public List<string> firstNames; // These appear in the inspector, you should be assigning names to these in the inspector.
    [Header("Possible last names")]
    public List<string> lastNames;
    [Header("Possible nicknames")]
    public List<string> nicknames;
    [Header("Possible adjectives to describe the character")]
    public List<string> descriptors;

    /// <summary>
    /// Returns an Array of Character Names based on the number of namesNeeded.
    /// </summary>
    /// <param name="namesNeeded"></param>
    /// <returns></returns>
    public CharacterName[] GenerateNames(int namesNeeded)
    {
        Debug.Log("CharacterNameGenerator called, filling out the names array with unique randomly constructed character names");
        CharacterName[] names = new CharacterName[namesNeeded]; 
        CharacterName emptyName = new CharacterName(string.Empty, string.Empty, string.Empty, string.Empty);


        for (int i = 0; i < names.Length; i++)
        {
            var randomIndex = Random.Range(0,firstNames.Count-1);
            //For every name we need to generate, we need to assign a random first name, last name, nickname and descriptor to each.
            //Below is an example of setting the first name of the emptyName variable to the string "Blank".
            emptyName.firstName = firstNames[randomIndex];
            names[i] = emptyName;
        }

        //Returns an array of names that we just created.
        return names;
    }
}