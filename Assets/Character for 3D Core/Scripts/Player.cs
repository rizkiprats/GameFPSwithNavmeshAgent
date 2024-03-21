using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void Talking()
    {
        anim.SetTrigger("Talk");
        audio.Play();
    }
}
