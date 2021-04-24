using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class LeatherS : ArmorSet
    {
        public LeatherS()
        {
            Name = "Leather S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 30;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Geologist(1))
                .AddSkill(new HungerResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Botanist(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Geologist(1))
                .AddSkill(new SpecialAmmoBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new RecoveryUp(1))
                .AddSkill(new HungerResistance(2))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Geologist(1))
                .AddSlot(new MediumSlot());
        }
    }
}