using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animSound : MonoBehaviour
{
    public AudioSource audioPlayer;
    public AudioClip clip;
    public bool repeat;

    private bool triggAnim = false;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggAnim)
        {
            audioPlayer.Play();
            //if (repeat)
              //  triggAnim= false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            triggAnim = true;
    }
}
