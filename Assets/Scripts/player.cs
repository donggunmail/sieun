using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float jumpForce = 5.0f; // ���� ���� �����ϱ� ���� ����
    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

}
