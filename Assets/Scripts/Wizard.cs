public class Wizard : Enemy
{
    void Start()
    {
        enemyStrength = 20;
    }

    void Update()
    {
        base.LookAtPlayer();
        LookAtPlayer();
    }

    protected override void LookAtPlayer()
    {
        print("Wizard is looking at player");
    }
}
