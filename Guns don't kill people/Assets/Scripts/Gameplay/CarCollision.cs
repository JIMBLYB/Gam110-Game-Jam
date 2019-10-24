using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollision : MonoBehaviour
{

    [SerializeField]
    private int nextLevelBuildIndex;
    [SerializeField]
    private float nextLevelDelay = .5f;

    [SerializeField]
    private GameObject particleEffect;
    private Coroutine delayWinCoroutine;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.Crate.ToString()))
        {
            ParticleManager.Instance.SpawnParticle(particleEffect, this.transform.position, Quaternion.identity);
            this.GetComponent<SpriteRenderer>().enabled = false;

            if (delayWinCoroutine == null) delayWinCoroutine = StartCoroutine(DelayWin(nextLevelBuildIndex));
            Destroy(this.gameObject, nextLevelDelay + 0.1f);
        }

        else if (collision.gameObject.CompareTag(Tags.Hostage.ToString()))
        {
            if (delayWinCoroutine == null) delayWinCoroutine = StartCoroutine(DelayWin(SceneManager.GetActiveScene().buildIndex));
        }
    }

    private IEnumerator DelayWin(int buildIndex)
    {
        yield return new WaitForSeconds(nextLevelDelay);
        ChangeScene.Instance.LoadScene(buildIndex);
    }
}
