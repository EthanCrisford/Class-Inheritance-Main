public class Dragon : Enemy
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
        print("Dragon is looking at player");
    }
}
