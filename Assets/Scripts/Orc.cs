public class Orc : Enemy
{
    void Start()
    {
        AttackPlayer();
    }

    void Update()
    {

    }

    protected override void AttackPlayer()
    {
        print("Orc is attacking player");
    }
}