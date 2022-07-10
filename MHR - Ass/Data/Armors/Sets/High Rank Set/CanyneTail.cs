namespace MHR___Ass.Data.Armors.Sets
{
    public class CanyneTail : ArmorSet
    {
        public CanyneTail()
        {
            Name = "Canyne Tail";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 20;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Waist = new WaistArmor(this);
        }
    }
}