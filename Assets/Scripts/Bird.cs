
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float upForce = 140f;
    private Rigidbody2D rb2d;
    private Animator anim;

    private bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetTrigger("Flap");
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
            }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        anim.SetTrigger("Die");

        GameControl.ins.BirdDie();
            }
   
    

    
}
