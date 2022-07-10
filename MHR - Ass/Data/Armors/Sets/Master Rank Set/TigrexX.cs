using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class TigrexX : ArmorSet
    {
        public TigrexX()
        {
            Name = "Tigrex X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 134;
            Fire.Value = 2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Earplugs(1))
                .AddSkill(new SpeedEating(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Earplugs(2))
                .AddSkill(new PeakPerformance(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new MindsEye(1))
                .AddSkill(new PeakPerformance(1))
                .AddSkill(new StunResistance(1))
                .AddSkill(new NormalRapidUp(1))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Earplugs(2))
                .AddSkill(new PeakPerformance(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new SpeedEating(2))
                .AddSkill(new MindsEye(2))
                .AddSkill(new NormalRapidUp(2))
                .AddSlot(new LargeSlot());
        }
    }
}