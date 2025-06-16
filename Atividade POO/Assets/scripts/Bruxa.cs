using UnityEngine;

public class Bruxa : MonoBehaviour

{
    public enum ArmaDaBruxa
    {
        VARINHA
    }

    public enum ArmaduraDaBruxa
    {
        CHAPEU, CAPA
    }

    [ SerializeField ]
    private ArmaduraDaBruxa armadura;
    [ SerializeField ]
    private ArmaDaBruxa arma;

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
                dano = Forca_Ataque() + 10;
                break;

            
                
            }
}