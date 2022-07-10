using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RathianX : ArmorSet
    {
        public RathianX()
        {
            Name = "Rathian X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 104;
            Fire.Value = 3;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new BlightResistance(1))
                .AddSkill(new PoisonResistance(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RecoveryUp(1))
                .AddSkill(new PoisonResistance(1))
                .AddSkill(new FreeMeal(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new BlightResistance(1))
                .AddSkill(new WideRange(1))
                .AddSkill(new FreeMeal(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new RecoveryUp(2))
                .AddSkill(new WideRange(2))
                .AddSkill(new Agitator(2))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new BlightResistance(1))
                .AddSkill(new FreeMeal(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}