using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] EnemyStats baseStats;
    [SerializeField] EnemyUnit enemyPrefab;
    EnemyUnit spawnEnemy1;
    EnemyUnit spawnEnemy2;
    EnemyUnit spawnEnemy3;

    EnemyStats enemy1;
    EnemyStats enemy2;
    EnemyStats enemy3;

    void Start()
    {
        this.enemy1 = baseStats.Clone();
        this.enemy1.enemyName = "Enemy 1";
        this.enemy1.enemySpeed = 3;
        this.enemy1.enemyColor = Color.red;

        this.enemy2 = baseStats.Clone();
        this.enemy2.enemyName = "Enemy 2";
        this.enemy2.enemySpeed = 5;
        this.enemy2.enemyColor = Color.blue;

        this.enemy3 = baseStats.Clone();
        this.enemy3.enemyName = "Inimigo 1";
        this.enemy3.enemySpeed = 7;
        this.enemy3.enemyColor = Color.black;
    }

    void Update()
    {
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        if(spawnEnemy1 == null)
        {
            spawnEnemy1 = Instantiate(enemyPrefab, new Vector3(24, 0.5f, 0), Quaternion.identity);
            int enemyIndex = Random.Range(1, 4);

            if(enemyIndex == 1)
            {
                spawnEnemy1.Setup(enemy1);
            }

            if (enemyIndex == 2)
            {
                spawnEnemy1.Setup(enemy2);
            }

            if (enemyIndex == 3)
            {
                spawnEnemy1.Setup(enemy3);
            }
        }

        if (spawnEnemy2 == null)
        {
            spawnEnemy2 = Instantiate(enemyPrefab, new Vector3(24, 0.5f, 24), Quaternion.identity);
            int enemyIndex = Random.Range(1, 4);

            if (enemyIndex == 1)
            {
                spawnEnemy2.Setup(enemy1);
            }

            if (enemyIndex == 2)
            {
                spawnEnemy2.Setup(enemy2);
            }

            if (enemyIndex == 3)
            {
                spawnEnemy2.Setup(enemy3);
            }
        }

        if (spawnEnemy3 == null)
        {
            spawnEnemy3 = Instantiate(enemyPrefab, new Vector3(24, 0.5f, -24), Quaternion.identity);
            int enemyIndex = Random.Range(1, 4);

            if (enemyIndex == 1)
            {
                spawnEnemy3.Setup(enemy1);
            }

            if (enemyIndex == 2)
            {
                spawnEnemy3.Setup(enemy2);
            }

            if (enemyIndex == 3)
            {
                spawnEnemy3.Setup(enemy3);
            }
        }
    }
}