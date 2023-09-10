public class Shocker : IWeapon 
{
    public void Attack(IVisitorAttack visitorAttack) => visitorAttack.VisitAttack(this);
}