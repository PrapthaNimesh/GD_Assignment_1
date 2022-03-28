using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public static float healthAmount;


    // Start is called before the first frame update
    void Start()
    {
        healthAmount = 1;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

        HealthDecrease();

        if (healthAmount <= 0)
            Destroy(gameObject);
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
        rb.velocity = new Vector2();
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        
    }
    public void HealthDecrease()
    {

        if (healthAmount <= 0)
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("bullet"))
            healthAmount -= 1f;

    }


}
