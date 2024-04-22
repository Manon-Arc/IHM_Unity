using UnityEngine;

public class Command : MonoBehaviour
{
    public ArticulationController AC;
    public InstanciateClass IC;
    public MovementClass MC;
    
    public void MoveCamCommand(int a)
    {
        float pos = (a / 100f) * 24f - 12f;
        this.transform.position = new Vector3(pos, this.transform.position.y, this.transform.position.z);
        Debug.Log("Cam position: " + this.transform.position);
    }
    
    private void Update()
    {
        if (MC.canRoule != "stop")
        {
            MC.MoveBotTrans(MC.canRoule);
        }
        
        if (MC.canRota != "stop")
        {
            MC.MoveBotRota(MC.canRota);
        }
    }
}