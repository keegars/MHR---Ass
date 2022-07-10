using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class AlloyX : ArmorSet
    {
        public AlloyX()
        {
            Name = "Alloy X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 94;
            Fire.Value = -1;
            Water.Value = 0;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WaterAttack(1))
                .AddSkill(new ProtectivePolish(1))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new SpeedSharpening(2))
                .AddSkill(new ProtectivePolish(2))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new WaterAttack(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new WaterAttack(3))
                .AddSkill(new CriticalEye(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}