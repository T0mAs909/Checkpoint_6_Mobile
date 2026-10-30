using System;
using UnityEngine;

[Serializable]
public class EnemyStats : IPrototype<EnemyStats>
{
    public string enemyName;
    public float enemySpeed;
    public Color enemyColor;

    public EnemyStats Clone()
    {
        return (EnemyStats)this.MemberwiseClone();
    }
}