using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class UtsushiTrueVisible : ArmorSet
    {
        public UtsushiTrueVisible()
        {
            Name = "Utsushi True (Visible)";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 126;
            Fire.Value = 3;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpeedEating(2))
                .AddSkill(new FreeMeal(2))
                .AddSkill(new GoodLuck(2))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new WideRange(1))
                .AddSkill(new GoodLuck(1))
                .AddSkill(new RecoveryUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new WideRange(2))
                .AddSkill(new RecoveryUp(2))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SpeedEating(1))
                .AddSkill(new FreeMeal(1))
                .AddSkill(new RecoveryUp(1))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new WideRange(2))
                .AddSkill(new FreeMeal(2))
                .AddSkill(new GoodLuck(2))
                .AddSlot(new MediumSlot());
        }
    }
}