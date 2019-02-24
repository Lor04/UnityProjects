using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
private static string[] wordList = { "hello", "computer", "game","compete",
"mistake",
"handle",
"question",
"breathe",
"enter",
"connection",
"pen",
"abnormal",
"ants",
"grieving",
"express",
"smiling",
"alive",
"effect",
"gentle",
"rain",
"surround",
"guitar",
"tangy",
"quirky",
"sterilize",
"boast",
"hide",
"depressed",
"grind",
"fine",
"birth",
"tedious",
"wax",
"meal"
 }; 

    public static string GetRandomWord()
        {
            int randomIndex = Random.Range(0, wordList.Length);
            string randomWord = wordList[randomIndex];
            return randomWord;
        }



}

