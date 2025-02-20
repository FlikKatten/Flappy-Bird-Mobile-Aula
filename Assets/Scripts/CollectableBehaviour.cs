using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{
    public float speed = 2f;
    private ScoreManager _scoreManager;
    private AudioManager _audioManager;

    private void Awake()
    {
        _scoreManager = FindAnyObjectByType<ScoreManager>();
        _audioManager = FindAnyObjectByType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _scoreManager.UpdateScore();
            _audioManager.PlayClip(0);
        }

        Destroy(gameObject);
    }
}
