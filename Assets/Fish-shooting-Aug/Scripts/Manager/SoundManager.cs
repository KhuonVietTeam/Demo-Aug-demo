using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip gun13, gun45, gun6, gun7,coin;
    public static AudioSource audioScr;
    // Use this for initialization
    void Start()
    {
        gun13 = Resources.Load<AudioClip>("GunSound/gun1-3");
        gun45 = Resources.Load<AudioClip>("GunSound/gun4-5");
        gun6 = Resources.Load<AudioClip>("GunSound/gun6");
        gun7 = Resources.Load<AudioClip>("GunSound/gun7");
        coin = Resources.Load<AudioClip>("GunSound/coinsound");
        audioScr = GetComponent<AudioSource>();
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "gun13":
                audioScr.PlayOneShot(gun13);
                break;
            case "gun45":
                audioScr.PlayOneShot(gun45);
                break;
            case "gun6":
                audioScr.PlayOneShot(gun6);
                break;
            case "gun7":
                audioScr.PlayOneShot(gun7);
                break;
            case "coin":
                audioScr.PlayOneShot(coin);
                break;
        }
    }
}
