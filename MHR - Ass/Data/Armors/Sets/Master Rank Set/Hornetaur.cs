using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Hornetaur : ArmorSet
    {
        public Hornetaur()
        {
            Name = "Hornetaur";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 98;
            Fire.Value = -1;
            Water.Value = -1;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 4;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Resuscitate(2))
                .AddSkill(new RecoveryUp(2))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new DragonAttack(2))
                .AddSkill(new RecoveryUp(2))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new DragonAttack(1))
                .AddSkill(new Steadiness(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new DragonAttack(2))
                .AddSkill(new DragonResistance(2))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Resuscitate(1))
                .AddSkill(new Steadiness(1))
                .AddSkill(new RecoveryUp(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());
        }
    }
}