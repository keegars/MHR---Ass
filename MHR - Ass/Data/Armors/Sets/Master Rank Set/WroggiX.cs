using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class WroggiX : ArmorSet
    {
        public WroggiX()
        {
            Name = "Wroggi X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 100;
            Fire.Value = 2;
            Water.Value = -2;
            Ice.Value = -4;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new RapidFireUp(2))
                .AddSkill(new EvadeExtender(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RapidFireUp(1))
                .AddSkill(new PoisonAttack(1))
                .AddSkill(new PoisonResistance(1))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new AmmoUp(1))
                .AddSkill(new PoisonResistance(1))
                .AddSkill(new MindsEye(1))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new AmmoUp(2))
                .AddSkill(new PoisonAttack(2))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new EvadeExtender(2))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}