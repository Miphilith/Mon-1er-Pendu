using UnityEngine;
using TMPro;
namespace Pendu
{
    public class KeyboardButton : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            TextMeshProUGUI tmp = GetComponentInChildren<TextMeshProUGUI>(); //Visualise la valeur des boutons
            tmp.text = gameObject.name; //Insert le nom des bouton dans leur valeur
        }
    }

}