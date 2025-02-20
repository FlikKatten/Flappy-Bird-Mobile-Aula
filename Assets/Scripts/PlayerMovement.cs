using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D _physics;
    private AudioManager _audioManager;

    private void Awake()
    {
        _audioManager = FindAnyObjectByType<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _physics = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            _physics.velocity = Vector2.up * jumpForce;
            _audioManager.PlayClip(2);
        }
    }
}
