using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]float spd = 1,timeSpan = 2f;
    void Start()
    {        
        Destroy(this.gameObject,timeSpan);
    }
    void Update()
    {
        transform.Translate(Vector2.right *  spd * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
