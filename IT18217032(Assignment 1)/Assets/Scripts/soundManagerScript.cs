using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagerScript : MonoBehaviour
{
    public static AudioClip bullet, killSound, ShotgunSoundEffect, ZombieSound;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        bullet = Resources.Load<AudioClip>("bullet");
        killSound = Resources.Load<AudioClip>("killSound");
        ShotgunSoundEffect = Resources.Load<AudioClip>("shotgun");
        ZombieSound = Resources.Load<AudioClip>("ZombieSound");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "bullet":
                audioSource.PlayOneShot(bullet);
                break;
            case "killSound":
                audioSource.PlayOneShot(killSound);
                break;
            case "shotgun":
                audioSource.PlayOneShot(ShotgunSoundEffect);
                break;
            case "ZombieSound":
                audioSource.PlayOneShot(ZombieSound);
                break;
        }
    }
}
