using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Pendu
{
    public class LetterManager : MonoBehaviour
    {
        private string[] words = new string[] { "abundant", "eccentric", "glimmer", "whimsical" }; //Prédétermine les mots

        private string hideWord;
        private string showWord;
        private int random;
        private int pendu;

        [SerializeField]
        private Image pendu_image;
        [SerializeField]
        private Sprite[] penduSprites;
        [SerializeField]
        private TextMeshProUGUI wordDisplay;
        private VirtualKeyboard keyboard;
        [SerializeField]
        private GameObject keyboardPanel;
        [SerializeField]
        private GameObject restartButton;
        [SerializeField]
        private Color goodColor;
        [SerializeField]
        private Color badColor;

        void Start()
        {
            pendu = 0;

            keyboard = GetComponent<VirtualKeyboard>();
            SelectWord();

            for (int i = 0; i < hideWord.Length; i++)
            {
                showWord += '_'; //Integre a la variable "showWord" le nombre de caractères "_" par rapport au nombre de lettre dans le mot
            }

            wordDisplay.text = showWord; //Affiche showWord dans le jeu
            pendu_image.sprite = penduSprites[0];

            Debug.Log(hideWord);
        }

        public void SelectWord()
        {
            random = Random.Range(0, words.Length); //Prend un nombre antier aléatoire en fonction de la longueur du tableau
            hideWord = words[random]; //Prend le mot en fonction du nombre aléatoire
        }

        public void CheckLetter()
        {
            string temp = "";
            int check = 0;

            if (hideWord.ToUpper().Contains(keyboard.letter)) //Vérifie s'il y a la lettre dans le mot
            {
                for (int i = 0; i < hideWord.Length; i++) //Parcour le mot
                {
                    if (hideWord[i].ToString().ToUpper() == keyboard.letter) //Vérifie où est la lettre dans le mot
                    {
                        temp += keyboard.letter; //Ajoute la lettre dans la variable locale
                        check++;
                    }
                    else
                    {
                        temp += showWord[i]; //Garde les "_" pour pas avoir une lettre unique
                    }
                }
                showWord = temp;
                if (showWord == hideWord.ToUpper())
                {
                    SetRestartWinCanvas();
                }
                wordDisplay.text = showWord;
            }
            else
            {
                pendu++;
                pendu_image.sprite = penduSprites[pendu];
                if (pendu == penduSprites.Length - 2)
                {
                    SetRestartLoseCanvas();
                    wordDisplay.text = hideWord.ToUpper(); //Montre le mot en cas de défaite
                }
            }
            SetButton(check);
        }

        private void SetButton(int check)
        {
            ColorBlock cb = keyboard.button.colors; //Visualise la vouleur du bouton

            if (check == 0)
            {
                cb.disabledColor = badColor; //Si le bouton est le mauvais on met la fausse couleur 
            }
            else
            {
                cb.disabledColor = goodColor; //Si le bouton est le bon on met la couleur correcte
            }

            keyboard.button.colors = cb;
            keyboard.button.interactable = false;
        }

        private void SetRestartWinCanvas()
        {
            pendu_image.sprite = penduSprites[penduSprites.Length - 1];
            SetRestartLoseCanvas();
        }

        private void SetRestartLoseCanvas()
        {
            keyboardPanel.SetActive(false); //Désactive le clavier virtuel
            restartButton.SetActive(true); //Active le bouton "Restart"
        }
    }
}