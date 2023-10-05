using Palmmedia.ReportGenerator.Core;

public class Dragon : Enemy
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
        print("Dragon is attacking player");
    }
}
