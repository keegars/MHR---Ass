using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class AlloyS : ArmorSet
    {
        public AlloyS()
        {
            Name = "Alloy S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 32;
            Fire.Value = -1;
            Water.Value = 0;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WaterAttack(1))
                .AddSkill(new ProtectivePolish(1))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new SpeedSharpening(2))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new WaterAttack(1))
                .AddSkill(new CriticalEye(2))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new WaterAttack(2))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new SpeedSharpening(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new MediumSlot());
        }
    }
}