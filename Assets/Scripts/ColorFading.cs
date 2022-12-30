using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFading : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer == null)
        {
            return;
        }

        var sineTime = Mathf.Sin(Time.time) + 0.5f;
        var color = new Color(sineTime, 0.5f, 0.5f);
        meshRenderer.material.color = color;
    }
}
