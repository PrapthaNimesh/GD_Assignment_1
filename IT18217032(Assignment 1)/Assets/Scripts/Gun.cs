using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private Transform gunTip;

    [SerializeField]
    private GameObject bullet;

    private Vector2 lookDirection;
    private float lookAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        if (Input.GetMouseButton(0))
        {
            FireBullet();
            soundManagerScript.PlaySound("shotgun");
          //  soundManagerScript.PlaySound("bullet");
        }

      
    }

    public void FireBullet()
    {
        GameObject fireBullet = Instantiate(bullet, gunTip.position, gunTip.rotation);
        fireBullet.GetComponent<Rigidbody2D>().velocity = gunTip.up * 50f;
    }
}
