using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Player player;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetBool("IsWalking", player.IsWalking());
    }
}
