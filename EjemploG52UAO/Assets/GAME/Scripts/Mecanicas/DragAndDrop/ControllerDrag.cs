using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ControllerDrag : MonoBehaviour
{
    public List<GameObject> objsInstaciados;
    public Transform positionInicial;
    GameObject objInstanciado;
    bool t = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(IniciarCorrutina());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator IniciarCorrutina()
    {
        while (t)
        {
            yield return new WaitForSeconds(3);
            objInstanciado = InstanciarObjs();
            
        }

    }

    public GameObject InstanciarObjs()
    {
        int n = Random.Range(0, objsInstaciados.Count);
        GameObject obj = Instantiate(objsInstaciados[n],
            positionInicial.position, objsInstaciados[n].transform.rotation);

        return obj;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Draggable"))
        {
            Debug.Log("Objeto arrastrado dentro del trigger");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Draggable"))
        {
            Debug.Log("Objeto arrastrado fuera del trigger");
        }
    }
}
