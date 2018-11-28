namespace Battle.Weapons
{
    public abstract class Weapon
    {
        public abstract int Damage { get; }

        public virtual bool SpecializedWeapon => false;

        public static bool operator <(Weapon left, Weapon right)
        {
            return left.Damage < right.Damage;
        }

        public static bool operator >(Weapon left, Weapon right)
        {
            return !(left < right);
        }

        public static bool operator <=(Weapon left, Weapon right)
        {
            return left.Damage <= right.Damage;
        }

        public static bool operator >=(Weapon left, Weapon right)
        {
            return right <= left;
        }
    }
}
