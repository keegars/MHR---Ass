using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class DrothS : ArmorSet
    {
        public DrothS()
        {
            Name = "Droth S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 42;
            Fire.Value = -2;
            Water.Value = 4;
            Ice.Value = 0;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Torso = new TorsoArmor(this)
                .AddSkill(new WaterAttack(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Diversion(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new WaterAttack(3))
                .AddSlot(new MediumSlot());
        }
    }
}