using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyStrength;

    protected virtual void AttackPlayer()
    {
        print("Enemy is attacking player");
    }
}
