namespace GamePrototype.Items.EconomicItems
{
    public sealed class Grindstone : EconomicItem
    {
        public uint ArmourRestore => 4;
        public override bool Stackable => false;

        public Grindstone(string name) : base(name)
        {
        }    
    }
}
