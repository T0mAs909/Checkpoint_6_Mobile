using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemyUnit : MonoBehaviour
{
    public EnemyStats stats;

    MeshRenderer meshRenderer;
    NavMeshAgent agent;
    GameObject player;

    public void Setup(EnemyStats stats)
    {
        this.stats = stats;
        name = stats.enemyName;
    }

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = stats.enemyColor;
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (player == null) return;
        agent.SetDestination(player.transform.position);
        agent.speed = stats.enemySpeed;
    }
}