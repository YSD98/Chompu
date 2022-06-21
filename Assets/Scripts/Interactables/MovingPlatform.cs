using UnityEngine;
public class MovingPlatform : MonoBehaviour
{
    [SerializeField]float ptA,ptB,speed;
    Vector3 pos;
    void Start()
    {
        pos.x = transform.position.x;
        pos.z = transform.position.z;
    }
    void Update()
    {
        if(transform.position.y == ptA)
        {
            pos.y = ptB;
        }
        if(transform.position.y == ptB)
        {
            pos.y = ptA;
        }
        transform.position = Vector3.MoveTowards(transform.position, pos,speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
            col.transform.parent = this.transform;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
            col.transform.parent = null;
    }
}
