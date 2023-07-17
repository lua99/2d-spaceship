using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public float backgroundSpeed;
    private Renderer backRenderer;

    // Start is called before the first frame update
    void Start()
    {
        backRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        backRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
