using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;

    AudioSource audioSource;
   public AudioClip audio1;
    public AudioClip audio2;
  public  bool isGrounded=true;
    public float force = 10f;
   public float gravityModifier = 1f;
   public bool gameOver = false;
    public ParticleSystem over_Particle_Effect;
    public ParticleSystem dirt_Particle_Effect;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& isGrounded && !(gameOver))


        {

            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            isGrounded = false;

            anim.SetTrigger("Jump_trig");
            dirt_Particle_Effect.Stop();
            audioSource.PlayOneShot(audio1);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       //isGrounded = true;
       if(collision.collider.tag=="Ground")
        {
            isGrounded = true;
            dirt_Particle_Effect.Play();

        }
       else if(collision.collider.tag == "Obstacle")
        {
            gameOver = true;
            anim.SetBool("Death_b", true);

            anim.SetInteger("DeathType_int", 1);

            over_Particle_Effect.Play();
            dirt_Particle_Effect.Stop();
            audioSource.PlayOneShot(audio2);
            Debug.Log("Game Over");
        }
    }
}
