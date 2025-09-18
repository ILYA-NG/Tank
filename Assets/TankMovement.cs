using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;

    private Vector2 moveInput;

    // Метод вызывается системой ввода при изменении ввода движения
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        Debug.Log("Move input: " + moveInput);
    }

    void FixedUpdate()
    {
        // Движение по X (вправо/влево)
        rb.AddForce(moveInput.x * sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        // Движение по Y в вашем исходном коде влияет на вертикальный axis Y физического объекта
        rb.AddForce(0, 0, moveInput.y * forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        if (rb.position.y < -1f)
        {
            //FindObjectOfType<GameManager>().EndGame();
        }
    }
}
