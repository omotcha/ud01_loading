using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private Vector3 direction = Vector3.up;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        var movement = direction * speed;
        this.transform.Translate(movement*Time.deltaTime);
    }
}
