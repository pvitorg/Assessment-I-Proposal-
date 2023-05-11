using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text textoDePontuacaoAtual;
    
    public int pontuacaoAtual;
    
    void Awake()
    {
        instance = this;    
    } 
    
    // Start is called before the first frame update
    void Start()
    {
        pontuacaoAtual = 0;   
        textoDePontuacaoAtual.text = "SCORE: " + pontuacaoAtual; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao(int pontosParaGanhar)
    {
        pontuacaoAtual += pontosParaGanhar;
        textoDePontuacaoAtual.text = "SCORE: " + pontuacaoAtual;
    }
}
