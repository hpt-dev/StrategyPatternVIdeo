var items = Enumerable.Range(0, 9);

Func<int, bool> evenStrategy = (i => i % 2 == 0);
Func<int, bool> oddStrategy = (i => i % 2 != 0);

var evenItems = items.Where(evenStrategy);


//Decompiled Where (simplified)
public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, 
                                                  Func<TSource, int, bool> predicate)
{
    return WhereIterator(source, predicate);
}

private static IEnumerable<TSource> WhereIterator<TSource>(IEnumerable<TSource> source, 
                                                           Func<TSource, int, bool> predicate)
{
    int index = -1;
    foreach (TSource element in source)
    {
        checked
        {
            index++;
        }

        if (predicate(element, index))
        {
            yield return element;
        }
    }
}


























































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