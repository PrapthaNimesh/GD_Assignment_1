using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    Rigidbody2D rb;
    public static float healthAmount;

    void Start()
    {
        healthAmount = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        HandleMovement();
        HealthDecrease();
        if (healthAmount <= 0)
            Destroy(gameObject);
    }
    private void HandleMovement()
    {
        float speed = 10f;
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = +1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }

        bool isIdle = moveX == 0 && moveY == 0;

            Vector3 moveDir = new Vector3(moveX, moveY).normalized;//normalized for controll the diaganal angal also

            transform.position += moveDir * speed * Time.deltaTime;
        }

    public void HealthDecrease() {

        if (healthAmount <= 0)
            Destroy(gameObject);
    }

    public void FixedUpdate()
    {

        rb.velocity = new Vector2();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Enemy"))
            healthAmount -= 0.1f;
        else if (collision.gameObject.name.Equals("HealthPack"))
            healthAmount = 1f;
    }


}
