using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int playerHP = 3;

    private Rigidbody rb;
    private Vector3 moveInput;
    [SerializeField] private Vector3 moveVelocity;

    public GameObject wBullet;
    public GameObject bBullet;
    public Transform shootPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        moveInput = new Vector3(horizontalInput, verticalInput, 0f).normalized;
        moveVelocity = moveInput * moveSpeed;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Shoot(wBullet);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Shoot(bBullet);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }



    void Shoot(GameObject bulletPrefab)
    {
        Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
    }
    public void Damaged()
    {
        playerHP -= 1;
        if (playerHP <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}

