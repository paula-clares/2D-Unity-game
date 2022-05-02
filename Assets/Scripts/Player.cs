using UnityEngine;

public class Player : MonoBehaviour
{

    float health = 100.0f;

    public Player (float health) {
        this.health = health;
        Debug.Log("New player");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
