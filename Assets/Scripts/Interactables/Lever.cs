using UnityEngine;
public class Lever : MonoBehaviour
{
    public GameObject[] wallBlocks ;
    SpriteRenderer sp;
    bool canSwitch = false;
    void Start(){sp = GetComponent<SpriteRenderer>();}
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G) && canSwitch)
            {OpenWall();sp.flipX = !sp.flipX;}
    }
    void OpenWall()
    {
        for(int i = 0;i<wallBlocks.Length; i++)
            Destroy(wallBlocks[i],i);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
            canSwitch = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
            canSwitch = false;
    }
}
