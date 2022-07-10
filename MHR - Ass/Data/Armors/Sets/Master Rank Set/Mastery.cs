namespace MHR___Ass.Data.Armors.Sets
{
    public class Mastery : ArmorSet
    {
        public Mastery()
        {
            Name = "Mastery";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 21;
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