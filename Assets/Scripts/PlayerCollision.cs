using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private ScoreManager _scoreManager;
    private AudioManager _audioManager;
    private SceneController _sceneController;

    private void Awake()
    {
        _scoreManager = FindAnyObjectByType<ScoreManager>();
        _audioManager = FindAnyObjectByType<AudioManager>();
        _sceneController = FindAnyObjectByType<SceneController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe") || collision.gameObject.CompareTag("Ground"))
        {
            _audioManager.PlayClip(1);
            StartCoroutine(DelayLoad());
        }
    }

    public IEnumerator DelayLoad()
    {
        yield return new WaitForSeconds(1f);
        _sceneController.LoadScene("MenuScene");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PointZone"))
        {
            _scoreManager.UpdateScore();
            _audioManager.PlayClip(0);
        }
    }
}
