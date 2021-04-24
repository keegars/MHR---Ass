using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class SomnacanthS : ArmorSet
    {
        public SomnacanthS()
        {
            Name = "Somnacanth S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 58;
            Fire.Value = -1;
            Water.Value = 2;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SleepAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new SleepAttack(1))
                .AddSkill(new ItemProlonger(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Bombardier(2))
                .AddSkill(new DivineBlessing(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SleepAttack(1))
                .AddSkill(new Bombardier(1))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new DivineBlessing(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}