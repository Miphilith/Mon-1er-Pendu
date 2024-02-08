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
            wordDisplay.text += '_';
        }
        showWord = wordDisplay.text.ToString();
        Debug.Log(hideWord);
    }

    public void CheckLetter()
    {
        if (hideWord.ToUpper().Contains(keyboard.letter))
        {
            for (int i = 0; i < hideWord.Length; i++)
            {
                if (hideWord[i].Equals(keyboard.letter))
                {
                    showWord[i] = keyboard.letter;
                }
            }
            Debug.Log(showWord + ' ' + true);

        }
        else
        {
            Debug.Log(false);
        }
    }
}
