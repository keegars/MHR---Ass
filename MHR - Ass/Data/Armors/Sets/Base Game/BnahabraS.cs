using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BnahabraS : ArmorSet
    {
        public BnahabraS()
        {
            Name = "Bnahabra S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 34;
            Fire.Value = -2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new PoisonAttack(1))
                .AddSkill(new RecoilDown(2))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new ParalysisAttack(1))
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new PoisonAttack(2))
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ParalysisAttack(1))
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new ParalysisAttack(1))
                .AddSkill(new RecoilDown(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}