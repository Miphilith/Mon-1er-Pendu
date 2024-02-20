using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pendu
{
    public class GameManager : MonoBehaviour
    {
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}