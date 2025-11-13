using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public GameObject hero;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - hero.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(hero.transform.position.x + offset.x,transform.position.y,transform.position.z);
    }
}
