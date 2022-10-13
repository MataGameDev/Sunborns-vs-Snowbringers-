using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Level_Manager : MonoBehaviour
{
    public List<Plantas> plantas;
    public TextMeshProUGUI TxtSoles;

    int Semillas = 50;
    int PlantaUtilizada = 0;

    public GameObject Semilla;
    

    private void Awake()
    {
        ActualizarSemillas(0);
        Time.timeScale = 1; //Para que el juego no empiece en pause
    }

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(14.0f);
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
                    if (PlantaUtilizada == 10)
                    {
                        Destroy(hit.collider.gameObject);
                    }
                }
                else if (hit.collider.CompareTag("Semilla"))
                {
                    ActualizarSemillas(50);
                    Destroy(hit.collider.gameObject);
                }
            }
        }

    }

    public void cambiarPlanta(int i){
      PlantaUtilizada = i;
    }
    void CrearPlanta(int numero, Transform t)
    {
        if (plantas[numero].precio > Semillas)
            return; //SI tienes menos semillas que el precio de la planta no la puedes poner 
        if (t.childCount != 0)
            return; //Si la casilla esta ocupada no puedes poner otra planta asi

        GameObject g = Instantiate(plantas[PlantaUtilizada].gameObject, t.position, gameObject.transform.rotation) as GameObject;
        g.transform.SetParent(t);

        ActualizarSemillas(-plantas[numero].precio);
    }
    
    public void ActualizarSemillas(int Add)
    {
        Semillas += Add;
        TxtSoles.text = Semillas.ToString();
    }
}
