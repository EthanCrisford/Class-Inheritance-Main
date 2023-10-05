using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyStrength;

    protected virtual void LookAtPlayer()
    {
        print("Enemy is looking at player");
    }
}
