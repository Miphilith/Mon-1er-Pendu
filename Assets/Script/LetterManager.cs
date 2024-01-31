using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private string[] words = new string[] { "abundant", "eccentric", "glimmer", "whimsical" }; //Pr�d�termine les mots

    private string hideWord;
    private int random;

    void Start()
    {
        
        random = Random.Range(0, 4); //Prend un nombre antier al�atoire
        hideWord = words[random]; //Prend le mot en fonction du nombre al�atoire

        Debug.Log(hideWord);
    }
}
