using UnityEngine;
using UnityEngine.InputSystem; // uses the new Input System

[RequireComponent(typeof(CharacterController))]
public class FirstPersonXRController : MonoBehaviour
{
    public Transform cameraTransform;   // assign XR camera here
    public float moveSpeed = 5f;
    public float mouseSensitivity = 2f;
    public float gravity = -9.81f;
    public bool lockCursor = true;

    private CharacterController controller;
    private float verticalVelocity = 0f;
    private float xRotation = 0f;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void Update()
    {
        var kb = Keyboard.current;
        var mouse = Mouse.current;
        if (kb == null || mouse == null || cameraTransform == null) return;

        // --- Mouse look ---
        Vector2 lookDelta = mouse.delta.ReadValue() * mouseSensitivity * Time.deltaTime;

        // rotate camera up/down (pitch)
        xRotation -= lookDelta.y;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // rotate body left/right (yaw)
        transform.Rotate(Vector3.up * lookDelta.x);

        // --- WASD movement on ground ---
        Vector3 input = Vector3.zero;
        if (kb.wKey.isPressed) input += Vector3.forward;
        if (kb.sKey.isPressed) input += Vector3.back;
        if (kb.aKey.isPressed) input += Vector3.left;
        if (kb.dKey.isPressed) input += Vector3.right;
        input = input.normalized;

        // convert local to world space based on facing
        Vector3 move = transform.TransformDirection(input) * moveSpeed;

        // --- Gravity & grounding ---
        if (controller.isGrounded && verticalVelocity < 0f)
            verticalVelocity = -2f;   // small downward force to keep grounded

        verticalVelocity += gravity * Time.deltaTime;

        move.y = verticalVelocity;

        controller.Move(move * Time.deltaTime);
    }
}
