using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;
    private float movementY;

    private Rigidbody2D myBody;
    private Animator myAnim;
    private SpriteRenderer mySprite;
    private string WALK_ANIMATION = "Walk";
    private bool isGrounded;
    private string GROUND_TAG="Ground";
    private string ENEMY_TAG="Enemy";
    private string COIN_TAG="Coin";

    // public static int scoreValue = 0;
    // public Text2D score;


    private void Awake(){
        myBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        mySprite = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimationPlayer();
        PlayerJump();
    }

    

    void FixedUpdate(){
        
    }

    //function for Keyboard inputs
    void PlayerMoveKeyboard(){
        
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3( movementX, 0f, 0f)*moveForce*Time.deltaTime;
       
    } 


    //function for Animation
    void AnimationPlayer(){
        if(movementX > 0){
            mySprite.flipX = false;
            myAnim.SetBool(WALK_ANIMATION, true);
        }
        else if(movementX < 0){
            mySprite.flipX = true;
            myAnim.SetBool(WALK_ANIMATION, true);
        }
        else{
            myAnim.SetBool(WALK_ANIMATION, false);
        }
    }

    //function for Jumping
    void PlayerJump(){
        if(Input.GetButtonDown("Jump") && isGrounded){
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == GROUND_TAG){
            isGrounded = true;
        }
        if(collision.gameObject.tag == ENEMY_TAG){
            Destroy(gameObject);
        }
        // if(collision.gameObject.tag == HEART_TAG){
        //     Destroy(collision.gameObject);
        // }
    }

    private void OnTriggerEnter2D (Collider2D collision) {
        if(collision.gameObject.tag == ENEMY_TAG){
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == COIN_TAG){
            Destroy(collision.gameObject);
        }
           
        
    }
}
