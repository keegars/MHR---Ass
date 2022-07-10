using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class MediumS : ArmorSet
    {
        public MediumS()
        {
            Name = "Medium S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 72;
            Fire.Value = 3;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpeedEating(1))
                .AddSkill(new FreeMeal(1))
                .AddSkill(new GoodLuck(1))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new WideRange(1))
                .AddSkill(new GoodLuck(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new WideRange(1))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SpeedEating(1))
                .AddSkill(new FreeMeal(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new WideRange(1))
                .AddSkill(new FreeMeal(1))
                .AddSkill(new GoodLuck(1))
                .AddSlot(new SmallSlot());
        }
    }
}