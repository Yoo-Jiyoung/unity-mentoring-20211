using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetObj : MonoBehaviour
{
    
    private AudioSource audio;
    public AudioClip audioGet;
    


    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource> ();
        // this.audio.clip = this.audioGet;
        // this.audio.loop = false;
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {   
        
        if (hit.gameObject.tag == "obj")
        {   
            this.audio.PlayOneShot(audioGet);
            Destroy(hit.gameObject,0.1f);
           
        
        } 

        if (hit.gameObject.tag == "over")
        {   
            
            SceneManager.LoadScene(0);
            
        }
        
        
            
    }

    void Update()
    {
        if(null == GameObject.Find("Bottle")
            && null == GameObject.Find("Quill")
            && null == GameObject.Find("Mushrooms")
            && null == GameObject.Find("Candy"))
            SceneManager.LoadScene(1);
    }


}
