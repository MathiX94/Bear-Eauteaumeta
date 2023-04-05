using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Trigger : MonoBehaviour
{
    public AudioSource A_source;
    public AudioClip clip;

    private void Start()
    {
        A_source.clip = clip;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            A_source.Play();
    }
}
