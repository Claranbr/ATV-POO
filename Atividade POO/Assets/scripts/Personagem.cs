using UnityEngine;

public class Personagem : MonoBehaviour

    
{
    [SerializeField]
    private string nome;
    [SerializeField]
    private int dano;
    [SerializeField]
    private int saude;
    [SerializeField]
    private int ataque;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }

    public void AtribuirDano(int dano)
    {
        this.dano = dano;
    }

    public int Dano()
    {
        return this.dano;
    }
    public void AtribuirSaude(int saude)
    {
        this.saude = saude;
    }
    public int Saude()
    {
        return this.saude;
    }

    public void AtribuirAtaque(int ataque)
    {
        this.ataque = ataque;
    }

    public int Ataque()
    {
        return this.ataque;
    }
}
