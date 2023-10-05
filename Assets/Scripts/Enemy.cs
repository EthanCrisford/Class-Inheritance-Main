using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyStrength;

    protected virtual void LookAtPlayer()
    {
        print("Enemy is looking at player");
    }

    public class Orc : Enemy
    {
        void Start()
        {
            enemyStrength = 10;
        }

        void Update()
        {
            base.LookAtPlayer();
            LookAtPlayer();
        }

        protected override void LookAtPlayer()
        {
            print("Orc is looking at player");
        }
    }
}
