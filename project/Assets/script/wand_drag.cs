using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wand_drag : MonoBehaviour
{   
    public float z_position = 2.7f;
    float timer = 0.0f;
    private TextMesh wand;
    int Counting = 4;
    
    
    
    void Start()
    {
        wand = GameObject.Find("wand").GetComponent<TextMesh>();
        wand.text = " ";

        
    }

    void OnMouseDrag()
    {   
        //true
        if(null == GameObject.Find("Bottle")
            && null == GameObject.Find("Quill")
            && null == GameObject.Find("Mushrooms"))

        {   
            
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, z_position);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition;

            wand.text = (Counting -timer).ToString("F0") + "초 후 완성됩니다.";
            if(timer > 4)
            {
                SceneManager.LoadScene(2);
            }
        }

        //false
        if(null == GameObject.Find("Bottle")
            && null == GameObject.Find("Quill")
            && null == GameObject.Find("Candy"))

        {
            
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, z_position);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition;

            wand.text = (Counting -timer).ToString("F0") + "초 후 완성됩니다.";
            if(timer > 4)
            {
                SceneManager.LoadScene(3);
            }
        }

        if(null == GameObject.Find("Candy")
            && null == GameObject.Find("Quill")
            && null == GameObject.Find("Mushrooms"))

        {
            
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, z_position);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition;

            wand.text = (Counting -timer).ToString("F0") + "초 후 완성됩니다.";
            if(timer > 4)
            {
                SceneManager.LoadScene(3);
            }
        }

        if(null == GameObject.Find("Bottle")
            && null == GameObject.Find("Candy")
            && null == GameObject.Find("Mushrooms"))

        {
            
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, z_position);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition;

            wand.text = (Counting -timer).ToString("F0") + "초 후 완성됩니다.";
            if(timer > 4)
            {
                SceneManager.LoadScene(3);
            }
        }

        
        

        
    }


    //Update is called once per frame

    void Update()
    {
        if(null == GameObject.Find("Bottle")
            && null == GameObject.Find("Quill")
            && null == GameObject.Find("Mushrooms"))
        {
            timer += Time.deltaTime;
        }

        if(null == GameObject.Find("Bottle")
            && null == GameObject.Find("Quill")
            && null == GameObject.Find("Candy"))
        {
            timer += Time.deltaTime;
        }

        if(null == GameObject.Find("Candy")
            && null == GameObject.Find("Quill")
            && null == GameObject.Find("Mushrooms"))
        {
            timer += Time.deltaTime;
        }

        if(null == GameObject.Find("Bottle")
            && null == GameObject.Find("Candy")
            && null == GameObject.Find("Mushrooms"))
        {
            timer += Time.deltaTime;
        }

        
        
            
            
    }
}
