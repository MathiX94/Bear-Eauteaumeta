using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJ_Animator : MonoBehaviour
{
    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            m_Animator.SetTrigger("IsNearPNJ");
    }
}
