using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector timeline1;  // 物体1的Timeline
    public PlayableDirector timeline2;  // 物体2的Timeline
    public PlayableDirector timeline3;  // 物体3的Timeline（依此类推）

    public void PlayTimeline1()
    {
        timeline1.Play();
    }

    public void PlayTimeline2()
    {
        timeline2.Play();
    }

    public void PlayTimeline3()
    {
        timeline3.Play();
    }
}
