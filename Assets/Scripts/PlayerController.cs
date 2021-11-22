using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    public Camera playerCamera;
    public Gamemanager gamemanager;

    [Header("General")]
    public float gravityScale = -20f;
    private bool OnGround;

    [Header("Movement")]
    public float walkSpeed = 5f;
    public float runSpeed = 10f;

    [Header("Rotation")]
    public float rotationSensibility = 10f;

    [Header("Jump")]
    public float jumpHeight = 1.9f;
    public int avalibleJumps = 2;
    public int actualJumps = 2;

    private float cameraVerticalAngle;
    public Vector3 moveInput = Vector3.zero;
    Vector3 rotationinput = Vector3.zero;
    CharacterController characterController;

    private Vector3 Initpos;
    [SerializeField] Vector3 DestPos;
    private Vector3 Finalpos;
    public float counter = 5;
    public float speed = 0;

    private Vector3 tp = new Vector3(82f, 22f, 64f);

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        gamemanager.OnTpPlayer += TpPlayerTo;
    }

    private void Update()
    {
        Look();
        Move();
        PlataformUp();
        if (Input.GetKeyDown(KeyCode.U))
        {
            TpPlayerTo();
        }
    }

    private void Move()
    {
        if (characterController.isGrounded)
        {
            moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveInput = Vector3.ClampMagnitude(moveInput, 1f);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveInput = transform.TransformDirection(moveInput) * runSpeed;
            }
            else
            {
                moveInput = transform.TransformDirection(moveInput) * walkSpeed;
            }

        }

        if (Input.GetButtonDown("Jump"))
        {
            if (actualJumps > 0)
            {
                moveInput.y = Mathf.Sqrt(jumpHeight * -2f * gravityScale);
                actualJumps--;
                OnGround = true;
            }
        }

        moveInput.y += gravityScale * Time.deltaTime;
        characterController.Move(moveInput * Time.deltaTime);
    }

    private void Look()
    {
        rotationinput.x = Input.GetAxis("Mouse X") * rotationSensibility * Time.deltaTime;
        rotationinput.y = Input.GetAxis("Mouse Y") * rotationSensibility * Time.deltaTime;

        cameraVerticalAngle = cameraVerticalAngle + rotationinput.y;
        cameraVerticalAngle = Mathf.Clamp(cameraVerticalAngle, -70, 70);

        transform.Rotate(Vector3.up * rotationinput.x);
        playerCamera.transform.localRotation = Quaternion.Euler(-cameraVerticalAngle, 0f, 0f);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (OnGround == true)
        {
            if (hit.collider.CompareTag("Terreno"))
            {
                actualJumps = avalibleJumps;
                OnGround = false;
            }
        }

    }

    private void PlataformUp()
    {
        if (counter < 5f)
        {
            Initpos = transform.position;
            Finalpos = Initpos + DestPos * Time.deltaTime * speed;
            transform.position = Finalpos;
            counter = counter + 1 * Time.deltaTime;
        }
    }

    private void TpPlayerTo()
    {
        print("win");
        Bait();
    }

    private void Bait()
    {
        this.transform.position = tp;

    }
}
