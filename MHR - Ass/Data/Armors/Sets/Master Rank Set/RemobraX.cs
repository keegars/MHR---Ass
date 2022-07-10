using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RemobraX : ArmorSet
    {
        public RemobraX()
        {
            Name = "Remobra X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 128;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Windproof(1))
                .AddSkill(new PoisonAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalBoost(1))
                .AddSkill(new PoisonAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalElement(1))
                .AddSkill(new Windproof(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new CriticalElement(2))
                .AddSkill(new PoisonResistance(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new WeaknessExploit(1))
                .AddSkill(new PoisonResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}