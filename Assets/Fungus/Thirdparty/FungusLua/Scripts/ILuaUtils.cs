﻿using UnityEngine;
using System.Collections;
using System.Text;

namespace Fungus
{
    public interface ILuaUtils
    {
        /// <summary>
        /// Returns a string from the string table for this key.
        /// The string returned depends on the active language.
        /// </summary>
        string GetString(string key);

        /// <summary>
        /// Implementation of StringSubstituter.ISubstitutionHandler
        /// Substitutes specially formatted tokens in the text with global variables and string table values.
        /// The string table value used depends on the currently loaded string table and active language.
        /// </summary>
        bool SubstituteStrings(StringBuilder input);

        /// <summary>
        /// Performs string substitution on the input string, replacing tokens of the form {$VarName} with 
        /// matching variables, localised strings, etc. in the scene.
        /// </summary>
        string Substitute(string input);

        /// <summary>
        /// Find a game object by name and returns it.
        /// </summary>
        GameObject Find(string name);

        /// <summary>
        /// Returns one active GameObject tagged tag. Returns null if no GameObject was found.
        /// </summary>
        GameObject FindWithTag(string tag);

        /// <summary>
        /// Returns a list of active GameObjects tagged tag. Returns empty array if no GameObject was found.
        /// </summary>
        GameObject[] FindGameObjectsWithTag(string tag);

        /// <summary>
        /// Create a copy of a GameObject.
        /// Can be used to instantiate prefabs.
        /// </summary>
        GameObject Instantiate(GameObject go);

        /// <summary>
        /// Destroys an instance of a GameObject.
        /// </summary>
        void Destroy(GameObject go);

        /// <summary>
        /// Spawns an instance of a named prefab resource.
        /// The prefab must exist in a Resources folder in the project.
        /// </summary>
        GameObject Spawn(string resourceName);

        /// <summary>
        /// Use the conversation manager to play out a conversation
        /// </summary>
        /// <param name="conv"></param>
        IEnumerator DoConversation(string conv);

        /// <summary>
        /// Sync the active say dialog with what Lua thinks the SayDialog should be
        /// </summary>
        /// <param name="sayDialog"></param>
        void SetSayDialog(ISayDialog sayDialog);
    }
}