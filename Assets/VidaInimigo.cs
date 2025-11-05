using UnityEngine;
public class VidaInimigo : MonoBehaviour
{
    public int hp;
    public void ReceberDano(int dano)
    {
        hp -= dano;
        if (hp <= 0)
        {
            Morrer();
        }
    }
    private void Morrer()
    {
        // Aqui pode colocar animação, som, etc
        Destroy(gameObject);
    }
}
