using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    [Header("-------- Audio Soure -------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clip -------------")]
    public AudioClip background;
    public AudioClip destruction;
    public AudioClip jump;
    public AudioClip throwObject;
    public AudioClip objectCollision;
    private void Start()
    {

        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
