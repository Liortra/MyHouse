using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideMotion : MonoBehaviour
{
    public bool isOpen;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            isOpen = true;
            animator.SetTrigger("OpenSlide");
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (isOpen)
        {
            isOpen = false;
            animator.SetTrigger("CloseSlide");
        }
    }
}
