using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiemposDeEspera : MonoBehaviour
{
    private Button boton;
    [SerializeField] private Plantas planta; 
    private float coldownd;
    private float coldowndBase;
    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<Button>();
        coldowndBase = planta.coldownd;
        coldownd = 0;
    }
    public void ponerEnColdown()
    {
        boton.interactable = false;
        coldownd = coldowndBase;
        StartCoroutine("espera");
    }
    private IEnumerator espera()
    {
        while (coldownd > 0)
        {
            coldownd--; 
            yield return new WaitForSeconds(1.0f);
        }
        boton.interactable = true;
    }
    // Update is called once per frame

}
