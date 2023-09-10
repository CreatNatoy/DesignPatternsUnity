public class SliverKnife : IWeapon
{ 
    public void Attack(IVisitorAttack visitorAttack) => visitorAttack.VisitAttack(this);
}