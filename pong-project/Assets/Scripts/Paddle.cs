
using UnityEngine;
using UnityEngine.EventSystems;

public class Paddle : MonoBehaviour
{
    public AudioSource _audio;

    protected Rigidbody2D _rigidbody;

    public float speed = 10f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            _audio.Play();
           
        }
    }


}
