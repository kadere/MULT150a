using UnityEngine;

public class ObjectAnimatorController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("ColorChangeTrigger");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("ScaleTrigger");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("SpinTrigger");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("HoverTrigger");
        }
    }
}

