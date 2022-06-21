using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public void Menu(){SceneManager.LoadScene(0);}
}
