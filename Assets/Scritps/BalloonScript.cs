using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour
{

    public int seconds = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyBalloons(this.seconds));
        StartCoroutine(RandomMove(0.1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator DestroyBalloons(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    }



    private IEnumerator RandomMove(float moveSpeed)
    {

        while (true)
        {
            Vector3 randomTarget = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            Vector3 direction = (randomTarget - transform.position).normalized;

            while (Vector3.Distance(transform.position, randomTarget) > .1)
            {
                transform.position += direction * Time.fixedDeltaTime * moveSpeed;
                yield return new WaitForFixedUpdate();
            }
        }
    }

}
