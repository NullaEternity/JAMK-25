using UnityEngine;

public class HampterController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            animator.SetFloat("Blend", 0f);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetFloat("Blend", 0.5f);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetFloat("Blend", 1f);
        }
	}
}
