using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    public GameObject SmashEffect;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        ScoreScript.scoreValue += 10;

        soundManagerScript.PlaySound("killSound");
        Destroy(gameObject);
        Instantiate(SmashEffect, transform.position, Quaternion.identity);
    }
}
