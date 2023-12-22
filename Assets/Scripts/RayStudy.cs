using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayStudy : MonoBehaviour
{
    public Text ui;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        //1<<6就是1左移6位，在哪一位就可以检测哪个层级
        LayerMask layerMask = 1 << 8;
        if (Physics.Raycast(ray, out hitInfo, 100, layerMask))
        {
            text=hitInfo.collider.GetComponent<Text>();
            ui.text = text.text;
        }
        else
        {
            ui.text = "";
        }
    }
}
