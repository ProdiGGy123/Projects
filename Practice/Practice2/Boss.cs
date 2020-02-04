using System;

namespace Boss
{
    public class Boss: Fighter
{
    protected void MultiplyHP()
    {
        HP *= 100;
    }

    private int BossAttack = 45;
}
}