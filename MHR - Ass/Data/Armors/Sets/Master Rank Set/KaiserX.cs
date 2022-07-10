using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KaiserX : ArmorSet
    {
        public KaiserX()
        {
            Name = "Kaiser X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 138;
            Fire.Value = 4;
            Water.Value = -4;
            Ice.Value = -1;
            Thunder.Value = 1;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalEye(3))
                .AddSkill(new CriticalBoost(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSkill(new MastersTouch(2))
                .AddSkill(new Ballistics(2))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new TeostraBlessing(1))
                .AddSkill(new CriticalEye(1))
                .AddSkill(new CriticalBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new TeostraBlessing(2))
                .AddSkill(new CriticalEye(2))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new TeostraBlessing(1))
                .AddSkill(new MastersTouch(1))
                .AddSkill(new CriticalBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());
        }
    }
}