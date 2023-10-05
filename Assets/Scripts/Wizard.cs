public class Wizard : Enemy
{
    void Start()
    {
        AttackPlayer();
    }

    void Update()
    {

    }

    protected new void AttackPlayer()
    {
        print("Wizard is attacking player");
    }
}
