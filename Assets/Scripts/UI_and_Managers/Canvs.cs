using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
    using UnityEditor;
#endif

public class Canvs : MonoBehaviour
{
    int lvl = 0;
    public Player pl;
    public Text scor,healt,ammo;
    public GameObject inGameUI,gameOver,gun,shootBtn;
    void Update()
    {
        scor.text = $"{pl.scoree}  x " ;
        healt.text = $"x {pl.health}" ;
        ammo.text = $"X {pl.ammo}" ;

        if(pl.isGameOver)GameOver();
        
        if(pl.isGun) gun.SetActive(true);
        if(pl.isGun) shootBtn.SetActive(true);
        if(pl.ammo <= 0) shootBtn.SetActive(false);
    }
    public void Health()
    {

    }

    public void GameOver(){ inGameUI.SetActive(false); gameOver.SetActive(true);}
    public void LevelLoad(){SceneManager.LoadScene(lvl);}

    public void Quit()
    {
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }
}
