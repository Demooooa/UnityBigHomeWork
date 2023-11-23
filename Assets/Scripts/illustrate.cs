using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class illustrate : MonoBehaviour
{
    public Transform player;
    public Text text;
    public Animator animator;
    private Text[] texts;
    private Transform[] transforms;
    float d;
    bool isDiatance = true;
    bool isPlayed=false;
    void Start()
    {
        texts = GetComponentsInChildren<Text>();
        transforms = GetComponentsInChildren<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i < transforms.Length; i++)
        {
            d = (transforms[i].position - player.transform.position).sqrMagnitude;
            if (d < 3f)
            {
                isDiatance = false;
                text.text = texts[i-1].text;
                break;
            }
            if (d > 3f)
            {
                isDiatance = true;
            }
        }
        if(!isDiatance&&!isPlayed)
        {
            animator.Play("Show");
            isPlayed = true;
        }
        else if (isDiatance&&isPlayed) 
        {
            animator.Play("NotShow");
            isPlayed = false;
        }
    }
}
