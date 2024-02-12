using UnityEngine;
using TMPro;

public class KeyboardButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI tmp = GetComponentInChildren<TextMeshProUGUI>();
        tmp.text = gameObject.name;
    }
}
