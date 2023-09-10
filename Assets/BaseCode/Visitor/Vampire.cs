using UnityEngine;

public class Vampire : IVisitorAttack
{
    public void VisitAttack(Shocker weapon)
    {
        Debug.Log("The Vampire dodged the Shocker and hit you");
    }

    public void VisitAttack(SliverKnife weapon)
    {
        Debug.Log("The Vampire took damage from the SliverKnife and died");
    }
}