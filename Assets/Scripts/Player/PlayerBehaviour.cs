using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerBehaviour : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        GameSystem.instance.inputManager.OnHit += TimberHit;
        
    }

    private void TimberHit()
    {
        //TODO
        
        animator.SetTrigger("pHit");
        GameSystem.instance.PlaySFXAudioByType(SFXAudioType.TimberHit);
        Debug.Log("HIT!");
    }

    private void OnDestroy()
    {
        GameSystem.instance.inputManager.OnHit -= TimberHit;
    }
}
