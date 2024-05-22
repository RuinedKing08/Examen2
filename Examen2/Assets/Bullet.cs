using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public string bulletType;
    public float lifeTime = 5f;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("White"))
        {
            Enemy enemy = other.GetComponent<Enemy>();

            if (enemy != null && bulletType == enemy.enemyType)
            {
                enemy.TakeDamage();
                Destroy(gameObject);
            }
        }

        if (other.CompareTag("Black"))
        {
            Enemy enemy = other.GetComponent<Enemy>();

            if (enemy != null && bulletType == enemy.enemyType)
            {
                enemy.TakeDamage();
                Destroy(gameObject);
            }
        }
    }
}
