namespace MHR___Ass.Data.Armors.Sets
{
    public class WyverianEarrings : ArmorSet
    {
        public WyverianEarrings()
        {
            Name = "Wyverian Earrings";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 44;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this);
        }
    }
}