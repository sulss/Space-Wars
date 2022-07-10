using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip laserSound, ExpoSound, OverSound,DeadSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        laserSound = Resources.Load<AudioClip>("laser");
        ExpoSound = Resources.Load<AudioClip>("patlama");
        OverSound = Resources.Load<AudioClip>("Anotherloseer");
        DeadSound = Resources.Load<AudioClip>("dead");
        audioSrc=GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "laser":
                audioSrc.PlayOneShot(laserSound);
                break;
            case "patlama":
                audioSrc.PlayOneShot(ExpoSound);
                break;
            case "over":
                audioSrc.PlayOneShot(OverSound);
                break;
            case "dead":
                audioSrc.PlayOneShot(DeadSound);
                break;
        }
    }
}
