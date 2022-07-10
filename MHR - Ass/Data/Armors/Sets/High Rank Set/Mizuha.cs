using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Mizuha : ArmorSet
    {
        public Mizuha()
        {
            Name = "Mizuha";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 94;
            Fire.Value = -5;
            Water.Value = 1;
            Ice.Value = 3;
            Thunder.Value = 0;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new MindsEye(2))
                .AddSkill(new Ballistics(2))
                .AddSkill(new EvadeWindow(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new ChameleosBlessing(1))
                .AddSkill(new PoisonAttack(1))
                .AddSkill(new MindsEye(1))
                .AddSkill(new Ballistics(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ChameleosBlessing(1))
                .AddSkill(new PoisonAttack(1))
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ChameleosBlessing(1))
                .AddSkill(new PoisonAttack(1))
                .AddSkill(new PeakPerformance(1))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new ChameleosBlessing(1))
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new MediumSlot());
        }
    }
}