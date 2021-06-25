using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    private SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 2);
        InvokeRepeating("Anim", 0.1f, 0.3f);
    }

    private void Anim()
    {
        rend.enabled = !rend.enabled;
    }
}
