namespace MHR___Ass.Data.Armors.Sets
{
    public class SinisterSeal : ArmorSet
    {
        public SinisterSeal()
        {
            Name = "Sinister Seal";

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

            Torso = new TorsoArmor(this);

            Arm = new ArmArmor(this);

            Waist = new WaistArmor(this);

            Leg = new LegArmor(this);
        }
    }
}