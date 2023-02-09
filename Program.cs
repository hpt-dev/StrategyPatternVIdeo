Console.WriteLine("Hello, World!");

var fighter = new Fighter();
fighter.setAttackBehavior(new DefaultAttackBehavior());
fighter.Attack();

var fighter2 = new Fighter();
fighter2.setAttackBehavior(new BowAndArrowAttackBehavior());
fighter2.Attack();

public abstract class Character
{
    // Properties all characters should have e.g. health points
    // ...
    private AttackBehavior _attackBehavior;

    // Methods all characters should have and default implementation
    public void Attack()
    {
        _attackBehavior.Attack();
    }

    public void setAttackBehavior(AttackBehavior attackBehavior)
    {
        _attackBehavior = attackBehavior;
    }
}

public class Fighter : Character
{
    // Fighter will use Default Character.Attack so doesn't override

}

public class Magician : Character
{


}

public class Archer : Character
{

}

public class ShopKeeper : Character
{

}

public interface AttackBehavior
{
    void Attack();
}

public class DefaultAttackBehavior : AttackBehavior
{
    public void Attack()
    {
        throw new NotImplementedException();
    }
}

public class SpellAttackBehavior : AttackBehavior
{
    public void Attack()
    {
        throw new NotImplementedException();
    }
}

public class BowAndArrowAttackBehavior : AttackBehavior
{
    public void Attack()
    {
        throw new NotImplementedException();
    }
}

public class NoAttackBehavior : AttackBehavior
{
    public void Attack()
    {
        throw new NotImplementedException();
    }
}