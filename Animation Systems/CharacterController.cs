public class CharacterController : MonoBehaviour
{
    Animator animator;
    float speed;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        speed = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", Mathf.Abs(speed));

        if (Input.GetButtonDown("Jump"))
            animator.SetTrigger("JumpTrigger");
    }
}