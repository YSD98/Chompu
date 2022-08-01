using UnityEngine;

public class TouchInputs : MonoBehaviour
{
    bool lft, rgt;
    public Player pl;
    public void LtDown() { lft = true; }
    public void LtUp() { lft = false; }
    public void RtDown() { rgt = true; }
    public void RtUp() { rgt = false; }

    void Update()
    {
        if (lft) pl.Left();
        if (rgt) pl.Right();
    }
}
