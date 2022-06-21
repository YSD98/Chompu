using UnityEngine;

public class SoundManager : MonoBehaviour

{
    public Player pl;
    public Canvs cs;
    public AudioSource playerr,canvss;
    public AudioClip[] ad;
    bool ovrDone = true;
    void Update()
    {
        // canvss.Play();
        if(pl.isGameOver && ovrDone)
        {
            canvss.Stop();
            playerr.PlayOneShot(ad[0]);
            ovrDone = false;
        }

        if (pl.isJumping)
            playerr.PlayOneShot(ad[1]);pl.isJumping = false;
        if (pl.isCoin)
            playerr.PlayOneShot(ad[2]);pl.isCoin = false;
        if (pl.isHit)
            playerr.PlayOneShot(ad[3]);pl.isHit = false;
        if(pl.isShooting)
            playerr.PlayOneShot(ad[4]);pl.isShooting = false;
    }
}
