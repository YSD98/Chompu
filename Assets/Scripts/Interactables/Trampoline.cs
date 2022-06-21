using UnityEngine;
public class Trampoline : MonoBehaviour
{
    Animator am;
    Rigidbody2D rbb;
    AudioSource tJump;
    [SerializeField]Vector2 throwAngle = new Vector2(0,1);
    void Start()
    {
        tJump = GetComponentInParent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        rbb = col.gameObject.GetComponent<Rigidbody2D>();
        if(rbb)
            rbb.AddForce(throwAngle,ForceMode2D.Impulse);
        am = GetComponentInChildren<Animator>();
        if(am){am.Play("Throw"); tJump.Play(); }
    }
}
