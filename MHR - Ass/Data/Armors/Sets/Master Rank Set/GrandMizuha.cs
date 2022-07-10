using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GrandMizuha : ArmorSet
    {
        public GrandMizuha()
        {
            Name = "Grand Mizuha";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 138;
            Fire.Value = -5;
            Water.Value = 1;
            Ice.Value = 3;
            Thunder.Value = 0;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new MindsEye(2))
                .AddSkill(new Ballistics(2))
                .AddSkill(new Foray(2))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new MindsEye(1))
                .AddSkill(new Ballistics(1))
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ChameleosBlessing(1))
                .AddSkill(new PoisonAttack(1))
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ChameleosBlessing(1))
                .AddSkill(new PeakPerformance(1))
                .AddSkill(new Foray(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new ChameleosBlessing(2))
                .AddSkill(new PeakPerformance(2))
                .AddSkill(new PoisonAttack(2))
                .AddSlot(new MediumSlot());
        }
    }
}