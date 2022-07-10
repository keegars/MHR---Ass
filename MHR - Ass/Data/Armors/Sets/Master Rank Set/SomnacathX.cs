using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class SomnacathX : ArmorSet
    {
        public SomnacathX()
        {
            Name = "Somnacath X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 104;
            Fire.Value = -1;
            Water.Value = 2;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SleepAttack(1))
                .AddSkill(new SleepResistance(1))
                .AddSkill(new SpareShot(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new SleepAttack(1))
                .AddSkill(new AmmoUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Bombardier(2))
                .AddSkill(new DivineBlessing(2))
                .AddSkill(new SpareShot(2))
                .AddSkill(new Handicraft(2))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SleepAttack(1))
                .AddSkill(new Bombardier(1))
                .AddSkill(new AmmoUp(1))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new DivineBlessing(2))
                .AddSkill(new SleepResistance(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}