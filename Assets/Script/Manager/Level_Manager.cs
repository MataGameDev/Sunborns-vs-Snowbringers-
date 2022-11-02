using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Level_Manager : MonoBehaviour
{
    [SerializeField] private List<Plantas> plantas;
    [SerializeField] private GameObject plantaSol;
    [SerializeField]private GameObject Semilla;
    
    [SerializeField]private Button boton;
    [SerializeField] private TextMeshProUGUI TxtSoles;
    
    [SerializeField] int Semillas = 5000;
    private int PlantaUtilizada = 12;
    private bool pala = false;
    private bool fertilizante = false;
    private void Awake()
    {
        ActualizarSemillas(0);
        Time.timeScale = 1; //Para que el juego no empiece en pause
    }

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(10.0f);
            //Spawneo de semillas cada 10 segundos
            GameObject _Semilla = Instantiate(Semilla, 
                new Vector3(Random.Range(-7, 7),Random.Range(-4, 2.3f),-0.1f), 
                Quaternion.identity);
            
        }
        //Codigo que me robe que no funciono
        /*
        for (int i = 0; i < plantasAUsar.Count; i++)
        {
            GameObject go = Instantiate(PrefabCarta) as GameObject;
            go.transform.SetParent(Deck.transform);
            go.transform.position = Vector3.zero;
            go.transform.localScale = Vector3.one;

            Image img = go.GetComponent<Image>();
            img.sprite = plantasAUsar[i].cartaAsignada;

            Button bot = go.GetComponent<Button>();
            bot.onClick.RemoveAllListeners();
            int u = i;
            bot.onClick.AddListener(() => { PlantaAusar = u; });
        } */
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(r.origin,r.direction);
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Casilla"))
                {
                    Transform t = hit.collider.transform;
                    CrearPlanta(PlantaUtilizada, t);
                }
                else if (hit.collider.CompareTag("Planta") )
                {
                    if (pala == true)
                    {
                        Destroy(hit.collider.gameObject);
                        pala = false;
                    }

                    if (fertilizante == true)
                    {
                        Destroy(hit.collider.gameObject);
                        Transform t = hit.collider.transform;
                        CrearFertilizante(t);
                    }
                }
                else if (hit.collider.CompareTag("Semilla"))
                {
                    ActualizarSemillas(25);
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    public void cambiarPlanta(int i){
      PlantaUtilizada = i;
      fertilizante = false;
      pala = false;
    }

    public void activarPala()
    {
        pala = true;
        fertilizante = false;
    }

    public void activarFertilizante()
    {
        fertilizante = true;
        pala = false;
    }
    private void CrearPlanta(int numero, Transform t)
    {
        if (plantas[numero].precio > Semillas)
            return; //SI tienes menos semillas que el precio de la planta no la puedes poner 
        if (t.childCount != 0)
            return; //Si la casilla esta ocupada no puedes poner otra planta asi
        if (PlantaUtilizada == 12)
            return;
        GameObject g = Instantiate(plantas[PlantaUtilizada].gameObject, t.position, gameObject.transform.rotation) as GameObject;
        g.transform.SetParent(t);
        PlantaUtilizada = 12;
        ActualizarSemillas(-plantas[numero].precio);
    }

    private void CrearFertilizante(Transform t)
    {
        GameObject g = Instantiate(plantaSol, t.position, gameObject.transform.rotation);
        fertilizante = false;
        boton.interactable = false;
    }
    
    private void ActualizarSemillas(int Add)
    {
        Semillas += Add;
        TxtSoles.text = Semillas.ToString();
    }
}
