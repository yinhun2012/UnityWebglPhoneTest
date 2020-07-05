using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCtrl : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Land()
    {
        animator.SetBool("Grounded", true);
    }

    public void Jump()
    {
        animator.SetBool("Grounded", false);
    }

    private void Update()
    {
        transform.localEulerAngles += new Vector3(0, Time.deltaTime * speed, 0);
    }

}
