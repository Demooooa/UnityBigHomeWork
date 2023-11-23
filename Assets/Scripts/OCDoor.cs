using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OCDoor : MonoBehaviour
{
    public GameObject player;
    float distance = 0;
    bool isdoor = false;
    Animator animator;
    //Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = (transform.position - player.transform.position).sqrMagnitude;
        if (!isdoor&&distance <= 10f)
        {
            animator.SetFloat("speed", 1);
            animator.Play("door");
            isdoor = true;
           
        }

        if(isdoor&&distance>10f) 
        {
            animator.SetFloat("speed", -1);
            animator.Play("door");
            isdoor =false;
        }
    }
}
