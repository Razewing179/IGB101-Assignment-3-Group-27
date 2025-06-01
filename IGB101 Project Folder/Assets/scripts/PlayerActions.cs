using UnityEngine;

public class PlayerActions : MonoBehaviour
{

    public Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Actions();
    }

    private void Actions()
    {
        // Wave
        if (Input.GetKeyDown("1"))
        {
            anim.SetBool("Waving", true);
        }
        else if (Input.GetKeyUp("1"))
        {
            anim.SetBool("Waving", false);
        }

        // T-Pose
        if (Input.GetKeyDown("2"))
        {
            anim.SetBool("T-Posing", true);
        }
        else if (Input.GetKeyUp("2"))
        {
            anim.SetBool("T-Posing", false);
        }

        // Dance
        if (Input.GetKeyDown("3"))
        {
            anim.SetBool("Dancing", true);
        }
        else if (Input.GetKeyUp("3"))
        {
            anim.SetBool("Dancing", false);
        }

        // Punch
        if (Input.GetKeyDown("f"))
        {
            anim.SetBool("Punching", true);
        }
        else if (Input.GetKeyUp("f"))
        {
            anim.SetBool("Punching", false);
        }
    }
}
