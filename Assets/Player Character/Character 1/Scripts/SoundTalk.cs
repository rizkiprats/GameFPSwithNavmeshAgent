using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTalk : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator MainCharacterAnimator;
    public GameObject AudioTalk;

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(6);
        AudioTalk.SetActive(false);
    }

    // Update is called once per frame
    public void DoTalk()
    {
        MainCharacterAnimator.SetTrigger("goIdle 2");
        AudioTalk.SetActive(true);
        StartCoroutine(MyCoroutine());
    }
}
