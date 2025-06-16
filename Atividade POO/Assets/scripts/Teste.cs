using UnityEngine;

public class Teste : MonoBehaviour
{
    void Start()
    {
        
        GameObject goPersonagem = new GameObject("rainha");
        Personagem rainha = goPersonagem.AddComponent<Personagem>();
        rainha.AtribuirNome("Elsa");
        rainha.AtribuirDano(5);
        rainha.AtribuirAtaque(10);
        rainha.AtribuirSaude(100);

       
        GameObject goBruxa = new GameObject("Bruxa");
        Bruxa bruxa = goBruxa.AddComponent<Bruxa>();
        bruxa.AtribuirNome("Alerquina");
        bruxa.AtribuirDano(8);
        bruxa.AtribuirAtaque(12);
        bruxa.AtribuirSaude(80);
        bruxa.AtribuirArma(Bruxa.ArmaDaBruxa.VARINHA);
        bruxa.AtribuirArmadura(Bruxa.ArmaduraDaBruxa.CAPA);

     
        Debug.Log($"Herói: {rainha.Nome()} - Vida: {rainha.Saude()} - Dano: {rainha.Dano()}");
        Debug.Log($"Bruxa: {bruxa.Nome()} - Vida: {bruxa.Saude()} - Dano base: {bruxa.Dano()} - Dano com arma: {bruxa.DanoDoInimigo()}");

       
        int danoBruxa = bruxa.DanoDoInimigo();
        int vidaRestante = rainha.Saude() - danoBruxa;
        rainha.AtribuirSaude(vidaRestante);
        
        Debug.Log($"Bruxa {bruxa.Nome()} atacou {rainha.Nome()} com {bruxa.Arma()} e causou {danoBruxa} de dano!");
        Debug.Log($"Vida restante do herói {rainha.Nome()}: {rainha.Saude()}");
    }
}