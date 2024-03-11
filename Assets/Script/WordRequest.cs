using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WordRequest : MonoBehaviour
{
    private string uri = "https://makeyourgame.fun/api/pendu/avoir-un-mot";
    public RequestedWord word;



    public IEnumerator RequestWordFromAPI()
    {
        using(UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();
            switch(webRequest.result) 
            {
                case UnityWebRequest.Result.Success:
                    word = JsonUtility.FromJson <RequestedWord>(webRequest.downloadHandler.text); //Traduit un fichier JSON en C#
                    break;
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError($"ca passe pas {webRequest.error}");
                    word = null;
                    break;
                case UnityWebRequest.Result.ConnectionError:
                    Debug.LogError("Vous n'êtes pas connecter a internet");
                    word = null;
                    break;
            }
        }
    }
}

public class RequestedWord
{
    public string status;
    public string motChoisi;
    public int nombreDeMots;
    public int emplacementDuMotDansLeDictionnaire;
    public string regles;
}
