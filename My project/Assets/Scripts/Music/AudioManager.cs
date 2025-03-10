using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-------- Audio Soure -------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clip -------------")]
    public AudioClip background;
    public AudioClip destruction;
    public AudioClip jump;
    public AudioClip throwobject;
    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
