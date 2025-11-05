using UnityEngine;

public class mataMonstro : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;
        int dano = 0;
        switch (tag)
        {
            case "Esqueleto":
                dano = 1; // 1 golpe para matar
                break;
            case "Lagarto":
                dano = 1; // Dano de 1 por golpe, vai precisar de 2 golpes pois Lagarto tem hp 2
        break;
            case "Golem":
                dano = 1; // Golem tem hp 3, precisa de 3 golpes
                break;
            default:
                return;
        }
        VidaInimigo vida = other.GetComponent<VidaInimigo>();
        if (vida != null)
        {
            vida.ReceberDano(dano);
        }
    }
}