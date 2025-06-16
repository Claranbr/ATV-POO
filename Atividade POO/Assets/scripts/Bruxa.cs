using UnityEngine;

public class Bruxa : Personagem
{
    public enum ArmaDaBruxa
    {
        VARINHA
    }

    public enum ArmaduraDaBruxa
    {
        CHAPEU,
        CAPA
    }

    [SerializeField] private ArmaduraDaBruxa armadura;
    [SerializeField] private ArmaDaBruxa arma;

    public void AtribuirArmadura(ArmaduraDaBruxa armadura)
    {
        this.armadura = armadura;
    }

    public ArmaduraDaBruxa Armadura()
    {
        return this.armadura;
    }

    public void AtribuirArma(ArmaDaBruxa arma)
    {
        this.arma = arma;
    }

    public ArmaDaBruxa Arma()
    {
        return this.arma;
    }


    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case ArmaDaBruxa.VARINHA:
                dano = Dano() + 10;
                break;



        }

        return dano;
    }
}