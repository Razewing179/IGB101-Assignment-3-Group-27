using UnityEngine;

public class DoorTest : MonoBehaviour
{
    Animation anim;
    public float openProximity = 2.0f;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animation>();
    }
    // Update is called once per frame
    void Update()
    {
        if (WithinOpenProximity() && Input.GetKeyDown("f"))
            anim.Play();
    }

    bool WithinOpenProximity()
    {
        return Vector3.Distance(GameManager.Instance.player.transform.position, this.gameObject.transform.position) <= openProximity;
    }

}
