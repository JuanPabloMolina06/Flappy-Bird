using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basecena : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    private Vector3 posicaoInicial;
    private float tamanhoDaimagemNacena;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaimagemOriginal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoDaimagemNacena = tamanhoDaimagemOriginal * escala;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoDaimagemNacena);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
