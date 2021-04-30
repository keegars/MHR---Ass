using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class WroggiS : ArmorSet
    {
        public WroggiS()
        {
            Name = "Wroggi S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 38;
            Fire.Value = 2;
            Water.Value = -2;
            Ice.Value = -4;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new RapidFireUp(1))
                .AddSkill(new EvadeExtender(1))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RapidFireUp(1))
                .AddSkill(new PoisonAttack(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new AmmoUp(1))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new AmmoUp(1))
                .AddSkill(new PoisonAttack(2))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new AmmoUp(1))
                .AddSkill(new EvadeExtender(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}