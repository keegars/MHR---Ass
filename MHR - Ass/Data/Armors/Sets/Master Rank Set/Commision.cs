using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Commision : ArmorSet
    {
        public Commision()
        {
            Name = "Commision";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 132;
            Fire.Value = 2;
            Water.Value = 2;
            Ice.Value = 2;
            Thunder.Value = 2;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Constitution(3))
                .AddSkill(new RecoverySpeed(3))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new GoodLuck(2))
                .AddSkill(new RecoverySpeed(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new SpeedEating(3))
                .AddSkill(new Mushroomancer(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Mushroomancer(2))
                .AddSkill(new RecoverySpeed(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Constitution(2))
                .AddSkill(new GoodLuck(2))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}