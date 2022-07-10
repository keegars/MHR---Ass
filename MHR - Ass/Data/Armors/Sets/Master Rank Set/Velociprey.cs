using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Velociprey : ArmorSet
    {
        public Velociprey()
        {
            Name = "Velociprey";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 98;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = -2;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new StunResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Windproof(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new CaptureMaster(1))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Windproof(2))
                .AddSkill(new StunResistance(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());
        }
    }
}