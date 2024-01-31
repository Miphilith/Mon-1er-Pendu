using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private string[] words = new string[] { "abundant", "eccentric", "glimmer", "whimsical" }; //Prédétermine les mots

    private string hideWord;
    private int random;
    private int counterLetter;

    void Start()
    {
        random = Random.Range(0, words.Length); //Prend un nombre antier aléatoire en fonction de la longueur du tableau
        hideWord = words[random]; //Prend le mot en fonction du nombre aléatoire
        counterLetter = hideWord.Length; //Compte la longueur du mot sélectionner

        Debug.Log(hideWord + " " + counterLetter);
    }
}
