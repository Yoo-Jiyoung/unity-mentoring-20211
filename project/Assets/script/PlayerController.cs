using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public CharacterController SelectPlayer; 
    public float Speed;  
    public float jumpPower= 5.0f;
    private float Gravity;   
    private Vector3 MoveDir;
    //private bool JumpButtonPressed;

    private AudioSource audio;
    public AudioClip audioJump;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 3.0f;
        Gravity = 10.0f;
        MoveDir = Vector3.zero;
        this.audio = this.gameObject.AddComponent<AudioSource> ();
        //JumpButtonPressed = false;
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(SelectPlayer == null) return;

        if(SelectPlayer.isGrounded)
        {
            MoveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            MoveDir = SelectPlayer.transform.TransformDirection(MoveDir);
            MoveDir *= Speed;
            if (Input.GetButton("Jump")) 
            {
                this.audio.PlayOneShot(audioJump);
                MoveDir.y = jumpPower;
            }
            
        } 

        else 
        {
            MoveDir.y -= Gravity * Time.deltaTime;
        }

        // if(!Input.GetButton("Jump"))
        // {
        //     JumpButtonPressed = false;
        // }

        
        SelectPlayer.Move(MoveDir * Time.deltaTime);
        
    }
}
