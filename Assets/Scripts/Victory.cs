using UnityEngine;
public class Victory : MonoBehaviour
{
    public GameObject vtry,inGameUI;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            vtry.SetActive(true);
            inGameUI.SetActive(false);
        }
    }
}
