using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private string[] words = new string[] { "abundant", "eccentric", "glimmer", "whimsical" }; //Prédétermine les mots

    private string hideWord;
    private int random;

    void Start()
    {
        
        random = Random.Range(0, 4); //Prend un nombre antier aléatoire
        hideWord = words[random]; //Prend le mot en fonction du nombre aléatoire

        Debug.Log(hideWord);
    }
}
