using UnityEngine;

public class Bandit : IVisitorAttack
{
    public void VisitAttack(Shocker weapon)
    {
        Debug.Log("The bandit took damage from the shocker and died");
    }

    public void VisitAttack(SliverKnife weapon)
    {
        Debug.Log("The bandit dodged the SliverKnife and hit you");
    }
}