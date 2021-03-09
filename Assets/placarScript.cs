using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class placarScript : MonoBehaviour {

    public static int pontuacao = 0;
    public Text placar;

    // Use this for initialization
    void Start()
    {
        placar.text = "Pontuação: 0";

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
            pontuacao += 10;
            placar.text = "Pontuação: " + pontuacao.ToString();
        }
    }
}
