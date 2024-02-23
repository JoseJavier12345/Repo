using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cubo : MonoBehaviour

{
    public int puntos;
    public Text TextoPuntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos =0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider c)
        {
        Debug.Log("Choque");
        puntos++;
        TextoPuntos.text = puntos.ToString();
        Destroy(gameObject);
    } 
}
