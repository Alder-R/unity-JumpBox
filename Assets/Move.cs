using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    private Rigidbody rigid;

    public float jumpPower = 30f;
    public float speed = 5f;
    public int money;
    public Text scoreboard;

    bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        isJumping = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Jump();
        move();
        TurnBrake();
    }
    void move()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed * Time.deltaTime, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(-speed * Time.deltaTime, 0, -speed * Time.deltaTime);
        }
    }
    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && !isJumping)
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            isJumping = true; //점프하면 isJumping을 true로
        }
    }
    void TurnBrake()
    {
        if (transform.rotation.x != 0 || transform.rotation.y != 0 || transform.rotation.z != 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
    }
    void OnCollisionEnter(Collision playerCol)
    {
        // 부딪힌 물체의 태그가 "Ground"라면
        if (playerCol.gameObject.CompareTag("Ground"))
        {
            isJumping = false; //isJumping을 다시 false로
        }

        if (playerCol.gameObject.CompareTag("RePlacer")) // "RePlacer" 태그에 닿으면
        {
            transform.position = new Vector3(-100, 3, 0); // 처음 위치로
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("CoinTag"))
        {
            money += 1;
            scoreboard.text = ""+money;
        }
    }

}
