using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour{
    private Renderer render;
    [SerializeField]
    private Color[] color;

    public void PutColor(int chosenColor)
    {
        render = GetComponent<Renderer>();
        render.material.SetColor("_Color", color[chosenColor - 1]);
    }
    private void Update()
    {
        Debug.Log(chosenColor);
        PutColor(Random.Range(1, 6));
    }
}
