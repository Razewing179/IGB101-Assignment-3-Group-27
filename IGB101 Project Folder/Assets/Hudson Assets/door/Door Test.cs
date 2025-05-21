using UnityEngine;

public class DoorTest : MonoBehaviour
{
    Animation animation;
    public float openProximity = 2.0f;

    // Use this for initialization
    void Start()
    {
        animation = GetComponent<Animation>();
    }
    // Update is called once per frame
    void Update()
    {
        if (WithinOpenProximity() && Input.GetKeyDown("f"))
            animation.Play();
    }

    bool WithinOpenProximity()
    {
        return Vector3.Distance(GameManager.Instance.player.transform.position, this.gameObject.transform.position) <= openProximity;
    }

}
