using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class User : MonoBehaviour
{
    Image userPicture;
    Text userName;
    // Start is called before the first frame update
    void Start()
    {
        userPicture=GetComponentInChildren<Image>();
        userName=GetComponentInChildren<Text>();
        userName.text = PlayerPrefs.GetString("name");
        string pname;
        pname=Random.Range(1,4).ToString();
       // userPicture=Resources.Load<Image>(pname);
        userPicture.sprite = Resources.Load<Sprite>(pname);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
