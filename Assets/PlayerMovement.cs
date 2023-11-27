using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public int directionX = 1;
    public int directionY = 1;

    private Rigidbody2D _compRigidbody;
    private SpriteRenderer _compSpriteRenderer;
    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speed * directionX, speed * directionY);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HorizontalWall")
        {
            directionY *= -1;
            if (_compSpriteRenderer.flipY == true)
            {
                _compSpriteRenderer.flipY = false;
            }
            else
            {
                _compSpriteRenderer.flipY = true;
            }
        }
        else if (collision.gameObject.tag == "VerticalWall")
        {
            directionX *= -1;
            if (_compSpriteRenderer.flipX == true)
            {
                _compSpriteRenderer.flipX = false;
            }
            else
            {
                _compSpriteRenderer.flipX = true;
            }
        }
    }
}
