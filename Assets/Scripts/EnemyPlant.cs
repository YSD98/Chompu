using UnityEngine;
public class EnemyPlant : MonoBehaviour
{
    public GameObject enemyBullet,enemyBulPos;
    Animator amm;
    [SerializeField]float shootTime = 2f;
    GameObject enemyBulletParent;
    void Start()
    {
        amm = GetComponent<Animator>();
        enemyBulletParent = new GameObject("EnemyBulletParent");
        InvokeRepeating("Spwnn",1f,shootTime);
    }
    void Spwnn()
    {
        amm.Play("Attack");
        GameObject bl = Instantiate(enemyBullet,enemyBulPos.transform.position,enemyBulPos.transform.rotation);
        bl.transform.parent = enemyBulletParent.transform;
    }
}
