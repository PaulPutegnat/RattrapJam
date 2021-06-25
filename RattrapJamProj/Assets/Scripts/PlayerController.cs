using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int blink;
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    public bool canJump = false;
    private bool invincible;

    private Timer timer;
    private Rigidbody2D rigidBody;
    public BoxCollider2D hitBox;
    public GameObject gameOver;
    public GameObject player;
    public SpriteRenderer playerSprite;
    private SpriteRenderer rend;
    private Shader shaderGUItext;
    private Shader shaderDefault;

    void Start()
    {
        timer = GetComponent<Timer>();
        rend = GetComponent<SpriteRenderer>();
        hitBox = GetComponent<BoxCollider2D>();
        rigidBody = GetComponent<Rigidbody2D>();

        shaderGUItext = Shader.Find("GUI/Text Shader");
        shaderDefault = Shader.Find("Sprites/Default");

        blink = 50;
        invincible = false;

        gameOver.SetActive(false);
    }

    void Update()
    {
        if (!invincible)
        {
            var movement = Input.GetAxis("Horizontal");
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

            if (!Mathf.Approximately(0, movement))
            {
                transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
            }

            if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidBody.velocity.y) < 0.001f && canJump)
            {
                rigidBody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Thunder") && !invincible)
        {
            timer.StopTimer();
            gameOver.SetActive(true);
            invincible = true;
            InvokeRepeating("BlinkingAnim", .01f, .04f);
        }
    }

    void BlinkingAnim()
    {
        if (blink < 0)
        {
            blink = 50;
            CancelInvoke("BlinkingAnim");
            rend.material.shader = shaderDefault;
            invincible = false;
            Destroy(player);
            Destroy(playerSprite);
            return;
        }
        //Switch between two shaders to make blinking anim
        if (rend.material.shader == shaderDefault)
        {
            blink--;
            rend.material.shader = shaderGUItext;
            return;
        }
        else
        {
            blink--;
            rend.material.shader = shaderDefault;
            return;
        }
    }
}
