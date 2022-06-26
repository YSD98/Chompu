using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Canvs : MonoBehaviour
{
    public Player pl;
    public Text scor,healt,ammo;
    public GameObject inGameUI,gameOver,gun;
    void Update()
    {
        scor.text = $"{pl.scoree}  x " ;
        healt.text = $"x {pl.health}" ;
        ammo.text = $"X {pl.ammo}" ;

        if(pl.isGameOver)GameOver();
        
        if(pl.isGun) gun.SetActive(true);
    }

    public void GameOver()
    {
        inGameUI.SetActive(false);
        gameOver.SetActive(true);
    }
    public void Neww(){SceneManager.LoadScene(0);}

    public void Quit()
    {
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }
}
