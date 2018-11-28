namespace Battle.Weapons
{
    public class Trident : Weapon
    {
        public override int Damage => new Spear().Damage * 3;
        public override bool SpecializedWeapon => true;
    }
}