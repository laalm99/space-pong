
using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Start()
    {

        StartCoroutine(Delay(1));
        
    }


    public IEnumerator Delay(float s)
    {
        yield return new WaitForSeconds(s);
        ResetPosition();

    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;

        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 0.1f);

        Vector2 direction = new Vector2(x, y);

        _rigidbody.AddForce(direction * this.speed);

    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _rigidbody.velocity.normalized * speed;
    }




}
