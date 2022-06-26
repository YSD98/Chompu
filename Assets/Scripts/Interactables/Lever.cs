using System.Collections;
using UnityEngine;
using Cinemachine;
using System.Threading.Tasks;
public class Lever : MonoBehaviour
{
    public GameObject[] wallBlocks ;
    public CinemachineVirtualCamera playerVCam;
    SpriteRenderer sp;
    bool canSwitch = false;
    void Start(){sp = GetComponent<SpriteRenderer>();}
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G) && canSwitch)
            {sp.flipX = !sp.flipX; StartCoroutine(your_timer());}
    }
    void OpenWall()
    {
        for(int i = 0;i<wallBlocks.Length; i++)
            Destroy(wallBlocks[i],i);
    }
    IEnumerator your_timer() 
    {
        if(playerVCam)
            playerVCam.gameObject.SetActive(false);
        Invoke("OpenWall",2f);
        yield return new WaitForSeconds(3f);
        if(playerVCam)
            playerVCam.gameObject.SetActive(true);
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
