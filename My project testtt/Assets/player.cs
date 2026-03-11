using UnityEngine;
using UnityEngine.InputSystem;
public class player : MonoBehaviour
{
    private Vector2 movelnput;
    public float moveSpeed = 7f;
    public void OnMove(InputValue value)
    { 
        movelnput = value.Get<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        if(movelnput.x > 0)
        { 
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(movelnput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }   
        transform.Translate(Vector3.right * moveSpeed * movelnput.x * Time.deltaTime);
    }
    
}
