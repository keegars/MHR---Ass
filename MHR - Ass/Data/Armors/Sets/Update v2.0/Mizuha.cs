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
            BaseDefense = 74;
            Fire.Value = -5;
            Water.Value = 1;
            Ice.Value = 3;
            Thunder.Value = 0;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
               .AddSlot(new SmallSlot())
               .AddSkill(new MindsEye(2))
               .AddSkill(new Ballistics(2))
               .AddSkill(new EvadeWindow(2));

            Torso = new TorsoArmor(this)
               .AddSlot(new SmallSlot())
               .AddSkill(new ChameleosBlessing(1))
               .AddSkill(new PoisonAttack(1))
               .AddSkill(new MindsEye(1))
               .AddSkill(new Ballistics(1));

            Arm = new ArmArmor(this)
               .AddSlot(new SmallSlot())
               .AddSkill(new ChameleosBlessing(1))
               .AddSkill(new PoisonAttack(1))
               .AddSkill(new EvadeWindow(1));

            Waist = new WaistArmor(this)
                .AddSlot(new SmallSlot())
                .AddSkill(new ChameleosBlessing(1))
                .AddSkill(new PoisonAttack(1))
                .AddSkill(new PeakPerformance(2));

            Leg = new LegArmor(this)
               .AddSlot(new MediumSlot())
               .AddSkill(new ChameleosBlessing(1))
               .AddSkill(new EvadeWindow(1));
        }
    }
}