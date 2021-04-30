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
            BaseDefense = 74;
            Fire.Value = 4;
            Water.Value = -4;
            Ice.Value = -1;
            Thunder.Value = 1;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
              .AddSlot(new SmallSlot())
              .AddSkill(new CriticalEye(3))
              .AddSkill(new CriticalBoost(1));

            Torso = new TorsoArmor(this)
               .AddSlot(new SmallSlot())
               .AddSkill(new TeostraBlessing(1))
               .AddSkill(new CriticalEye(1))
               .AddSkill(new MastersTouch(1));

            Arm = new ArmArmor(this)
                .AddSlot(new MediumSlot())
                .AddSkill(new TeostraBlessing(1))
                .AddSkill(new CriticalEye(1))
                .AddSkill(new CriticalBoost(1));

            Waist = new WaistArmor(this)
               .AddSlot(new MediumSlot())
               .AddSkill(new TeostraBlessing(1))
               .AddSkill(new CriticalEye(1));

            Leg = new LegArmor(this)
                .AddSlot(new SmallSlot())
                .AddSkill(new TeostraBlessing(1))
                .AddSkill(new MastersTouch(1));
        }
    }
}