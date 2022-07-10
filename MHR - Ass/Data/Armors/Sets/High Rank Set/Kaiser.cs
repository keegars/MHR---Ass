using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Kaiser : ArmorSet
    {
        public Kaiser()
        {
            Name = "Kaiser";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 94;
            Fire.Value = 4;
            Water.Value = -4;
            Ice.Value = -1;
            Thunder.Value = 1;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalEye(3))
                .AddSkill(new CriticalBoost(3))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new TeostraBlessing(1))
                .AddSkill(new CriticalEye(1))
                .AddSkill(new MastersTouch(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new TeostraBlessing(1))
                .AddSkill(new CriticalEye(1))
                .AddSkill(new CriticalBoost(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new TeostraBlessing(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new TeostraBlessing(1))
                .AddSkill(new MastersTouch(1))
                .AddSlot(new SmallSlot());
        }
    }
}