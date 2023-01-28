using UnityEngine;

public class SerpentJump : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {

        }
        else
        {
            if (HealthBar.jumpValue > 0 && HealthBar.jumpValue <= 10)
            {
                animator.SetBool("20Jumping", true);
                HealthBar.jumpValue -= 0.2f;
            }
            else if (HealthBar.jumpValue > 10f && HealthBar.jumpValue <= 20f)
            {
                animator.SetBool("20Jumping", true);
                HealthBar.jumpValue -= 0.2f;
            }
            else if (HealthBar.jumpValue > 20f && HealthBar.jumpValue <= 30f)
            {
                animator.SetBool("30Jumping", true);
                HealthBar.jumpValue -= 0.3f;
            }
            else if (HealthBar.jumpValue > 30f && HealthBar.jumpValue <= 40f)
            {
                animator.SetBool("40Jumping", true);
                HealthBar.jumpValue -= 0.3f;
            }
            else if (HealthBar.jumpValue > 0f && HealthBar.jumpValue <= 50f)
            {
                animator.SetBool("50Jumping", true);
                HealthBar.jumpValue -= 0.3f;
            }
            else
            {
                animator.SetBool("10Jumping", false);
                animator.SetBool("20Jumping", false);
                animator.SetBool("30Jumping", false);
                animator.SetBool("40Jumping", false);
                animator.SetBool("50Jumping", false);
            }
        }
    }
}
