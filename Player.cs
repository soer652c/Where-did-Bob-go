public class Player
{
    // atribut
    public int Health;

    //metode
    public void LoseHealth()
    {
        Health = Health--;
        return (void);
    }

    public void ReStoreHealth()
    {
        Health = Health++;
        return (void);
    }
}