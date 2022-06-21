using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void play(){SceneManager.LoadScene(1);}
    public void Exit(){Application.Quit();}
}
