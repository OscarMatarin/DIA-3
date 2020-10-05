using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour
{
    [SerializeField]
    float velocidad=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x, y; // para reconocer el gamepad
        x = Input.GetAxis("Horizontal"); // leemos el movimiento horizontal
        y = Input.GetAxis("Vertical"); // leemos el movimiento vertical
        // print("Horizontal:" + x + "/ Vertical: " + y);
        transform.Translate(x *Time.deltaTime*velocidad, y * Time.deltaTime*velocidad, 0);

    }
}
