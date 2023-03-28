using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJ_Animator : MonoBehaviour
{
    Animator m_Animator;
    public AudioSource player;
    public AudioClip clip;

    private bool triggAnim = false;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        player.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggAnim)
        {
            m_Animator.SetTrigger("IsNearPNJ");
            //new WaitForSeconds(2);
            player.Play();

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            triggAnim= true;
        }
    }
}
