using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Search;

public class Manager : MonoBehaviour
{
    private string[] words = new string[] { "abundant", "eccentric", "glimmer", "whimsical" }; //Prédétermine les mots

    private string hideWord;
    private string showWord;
    private int random;

    [SerializeField]
    private Image pendu_image;
    [SerializeField]
    private Sprite[] penduSprites;
    [SerializeField]
    private TextMeshProUGUI wordDisplay;
    private VirtualKeyboard keyboard;

    void Start()
    {
        keyboard = GetComponent<VirtualKeyboard>();
        random = Random.Range(0, words.Length); //Prend un nombre antier aléatoire en fonction de la longueur du tableau
        hideWord = words[random]; //Prend le mot en fonction du nombre aléatoire

        for (int i = 0; i < hideWord.Length; i++)
        {
            showWord += '_'; //Integre a la variable "showWord" le nombre de caractères "_" par rapport au nombre de lettre dans le mot
        }

        wordDisplay.text = showWord; //Affiche showWord dans le jeu
        //pendu_image = penduSprites[0];

        Debug.Log(hideWord + ' ' + penduSprites);
    }

    public void CheckLetter()
    {
        string temp = "";
        int pendu = 0;
        if (pendu != penduSprites.Length - 1)
        {
            if (hideWord.ToUpper().Contains(keyboard.letter)) //Vérifie s'il y a la lettre dans le mot
            {
                for (int i = 0; i < hideWord.Length; i++) //Parcour le mot
                {
                    if (hideWord[i].ToString().ToUpper() == keyboard.letter) //Vérifie où est la lettre dans le mot
                    {
                        temp += keyboard.letter; //Ajoute la lettre dans la variable locale
                    }
                    else
                    {
                        temp += showWord[i]; //Garde les "_" pour pas avoir une lettre unique 
                    }
                }
                showWord = temp;
            }
            else
            {
                pendu++;
                //pendu_image = penduSprites[pendu];
            }
        }
        else
        {
            //pendu_image = penduSprites[penduSprites.Length - 1];
        }
        
        wordDisplay.text = showWord;
    }
}
