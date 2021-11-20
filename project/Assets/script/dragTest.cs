using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dragTest : MonoBehaviour
{
    public float z_position = 2.7f;
    private AudioSource audio;
    public AudioClip audiosplash;
    

    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource> ();
        this.audio.clip = this.audiosplash;
        this.audio.loop = false;
        
    }

    
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, z_position);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objectPosition;

        
    }

    void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag == "magic")
        {   
            
            this.audio.Play();
            Destroy(this.gameObject,0.1f);
            
        }


    }

    

    

    


    

    


}