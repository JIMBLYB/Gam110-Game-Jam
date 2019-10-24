using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hostage : MonoBehaviour
{
    [SerializeField]
    private int nextLevelBuildIndex;
    [SerializeField]
    private float nextLevelDelay = .5f;

    private Coroutine delayWinCoroutine;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.Damage.ToString()))
        {
            if (delayWinCoroutine == null) delayWinCoroutine = StartCoroutine(DelayWin(SceneManager.GetActiveScene().buildIndex));
            Destroy(this.gameObject, nextLevelDelay += 0.1f);
        }

        if (collision.gameObject.CompareTag(Tags.Bullet.ToString()) || collision.gameObject.CompareTag(Tags.Ball.ToString()))
        {
            //Play Animation
            if (delayWinCoroutine == null) delayWinCoroutine = StartCoroutine(DelayWin(nextLevelBuildIndex));
        }

        
    }

    private IEnumerator DelayWin(int buildIndex)
    {
        yield return new WaitForSeconds(nextLevelDelay);
        ChangeScene.Instance.LoadScene(buildIndex);
    }
}
