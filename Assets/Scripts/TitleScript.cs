using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public void LauchGame()
    {
        SceneManager.LoadScene("Scenes/GameScreen");
    }
}
