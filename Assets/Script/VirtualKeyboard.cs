using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace Pendu
{
    public class VirtualKeyboard : MonoBehaviour
    {
        public string letter;
        public Button button;
        public void Keyboard()
        {
            GameObject go = EventSystem.current.currentSelectedGameObject;
            letter = go.name; //Injecte la valeur des boutons
            button = go.GetComponent<Button>(); //Injecte le bouton
        }
    }
}