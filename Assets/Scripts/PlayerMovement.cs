using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 playesPosition = transform.position;

        playesPosition.x += horizontalInput * speed * Time.deltaTime;
        playesPosition.y += verticalInput * speed * Time.deltaTime;

        transform.position = playesPosition;
    }
}
