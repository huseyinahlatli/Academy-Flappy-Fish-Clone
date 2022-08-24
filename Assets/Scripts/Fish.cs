using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Fish : MonoBehaviour
{
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] public TextMeshPro scoreText;
    private Rigidbody2D _rigidbody;

    public int score = 0;
    public static Fish Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * jumpForce);
        }

        if (transform.position.y < -4 || transform.position.y >= 6.5)
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}
