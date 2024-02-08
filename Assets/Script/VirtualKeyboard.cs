using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualKeyboard : MonoBehaviour
{
    public string letter;
    public void Keyboard()
    {
        letter = EventSystem.current.currentSelectedGameObject.name;
    }
}
