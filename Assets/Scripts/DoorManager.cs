using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public Collider doorCollider;
    public Animator anim;
    public float radius;

    private void Update()
    {
        List<Collider> detectedObjects = Physics.OverlapSphere(transform.position, radius).ToList();

        if (detectedObjects.Contains(doorCollider))
            anim.SetBool("character_nearby", true);
        else
            anim.SetBool("character_nearby", false);

    }
}
