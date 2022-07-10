using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BnahabraX : ArmorSet
    {
        public BnahabraX()
        {
            Name = "Bnahabra X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 96;
            Fire.Value = -2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new PoisonAttack(1))
                .AddSkill(new RecoilDown(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new ParalysisAttack(1))
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new PoisonAttack(2))
                .AddSkill(new EvadeWindow(2))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ParalysisAttack(2))
                .AddSkill(new EvadeWindow(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new RecoilDown(1))
                .AddSkill(new Steadiness(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}