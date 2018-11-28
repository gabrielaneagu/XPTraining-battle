namespace Battle.Weapons
{
    public class BroadAxe : Weapon
    {
        public override int Damage => new Axe().Damage + 2;
        public override bool SpecializedWeapon => true;
    }
}