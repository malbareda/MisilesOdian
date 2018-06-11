using UnityEngine;
using UnityEngine.AI;

public class MissileController : MonoBehaviour
{

    public Camera cam;
    public GameObject player;
    public GameObject explosion;

    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }*/
    }


    private void OnCollisionEnter(Collision collision)
    {
        print("pop");
        if (collision.gameObject.name == "Walls")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (collision.gameObject.name == player.name)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            collision.gameObject.SendMessage("Die");
        }
    }
}