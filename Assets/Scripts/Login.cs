using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public InputField name_inputField;
    public InputField id_inputField;
    public Button start_button;
    // Start is called before the first frame update
    void Start()
    {
        name_inputField.onEndEdit.AddListener(NEndInput);
        id_inputField.onEndEdit.AddListener(IEndInput);
        start_button.onClick.AddListener(click);
    }

    void NEndInput(string str)
    {
        PlayerPrefs.SetString("name", str);
        name_inputField.text= str;
    }

    void IEndInput(string str)
    {
        id_inputField.text = str;
    }

    void click()
    {
        if (name_inputField.text == "易雲静" && id_inputField.text == "0210182")
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("学号或姓名输入有误！");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
