using UnityEngine;
public class Player : MonoBehaviour
{
    public Animator am;
    public GameObject Bullet,bulPos,gndChk;
    public float speed = 2f, upForce = 5f, scoree = 0f, health = 5f;
    public byte ammo = 5;
    public LayerMask lm;
    // --------------------------
    GameObject BulletParent;
    float walkInput;
    Rigidbody2D rb;
    [HideInInspector]public bool isGameOver = false,isGun = false,isJumping,isHit,isCoin,isShooting,canJump;
//------------------------------------------------------------------------------------------------------------------------- 
    void Start()
    {
        BulletParent = new GameObject("BulletParent");
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        canJump = Physics2D.OverlapCircle(gndChk.transform.position,.05f,lm);
        walkInput = Input.GetAxisRaw("Horizontal");

        Movement();

        if(ammo > 0 && isGun)Shoot();
        
        if(health <=0)isGameOver = true;
    }
    void Movement()
    {
        if (walkInput > 0)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            am.SetBool("IsRun",true);
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        if (walkInput< 0)
        {
            transform.rotation = Quaternion.Euler(0,-180,0);
            am.SetBool("IsRun",true);
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        if (walkInput == 0)
            am.SetBool("IsRun",false);
        
        if (Input.GetButtonDown("Jump") && canJump)
        {
            isJumping = true;
            am.Play("Jump");
            rb.AddForce(Vector2.up * upForce,ForceMode2D.Impulse);
        }
    }
    void Shoot()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            isShooting = true;
            ammo --;
            GameObject bl = Instantiate(Bullet,bulPos.transform.position,bulPos.transform.rotation);
            bl.transform.parent = BulletParent.transform;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.tag == "Coins")
        {
            isCoin = true;
            Destroy(col.gameObject);
            scoree += 1f;
        }
        if(col.name== "Gun")
        {
            isGun = true;
            Destroy(col.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            isHit = true;
            am.Play("Hit");
            health -= 1f;
        }
    }
}
