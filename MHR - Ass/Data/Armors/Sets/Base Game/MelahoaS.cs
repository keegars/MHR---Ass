using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class MelahoaS : ArmorSet
    {
        public MelahoaS()
        {
            Name = "Melahoa S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 52;
            Fire.Value = 0;
            Water.Value = 1;
            Ice.Value = 0;
            Thunder.Value = 3;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ParalysisResistance(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Botanist(2))
                .AddSkill(new RecoveryUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ParalysisResistance(1))
                .AddSkill(new Botanist(1))
                .AddSkill(new RecoveryUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Botanist(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new RecoveryUp(1))
                .AddSkill(new RecoverySpeed(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}