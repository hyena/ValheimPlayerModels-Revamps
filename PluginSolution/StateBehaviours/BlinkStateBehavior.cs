using UnityEngine;

public class BlinkStateBehavior : StateMachineBehaviour
{
    
    public float minBlinkDelay = 1f;
    public float maxBlinkDelay = 5f;
    public string parameterName = "";

    protected float nextBlinkTime;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        nextBlinkTime = Time.time + Random.value * (maxBlinkDelay - minBlinkDelay) + minBlinkDelay;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Time.time > nextBlinkTime) {
            animator.SetTrigger(parameterName);
        }
    }
}