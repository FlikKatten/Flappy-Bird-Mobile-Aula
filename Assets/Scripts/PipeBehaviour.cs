using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    public float speed = 2f;
    public float minY, maxY;
    private float _resetX;

    // Start is called before the first frame update
    void Start()
    {
        _resetX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -_resetX)
        {
            float randomY = Random.Range(minY, maxY);
            transform.position = new Vector3(_resetX, randomY);
        }
    }
}
