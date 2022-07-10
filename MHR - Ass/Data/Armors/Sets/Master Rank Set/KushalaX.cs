using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KushalaX : ArmorSet
    {
        public KushalaX()
        {
            Name = "Kushala X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 138;
            Fire.Value = -1;
            Water.Value = 2;
            Ice.Value = 3;
            Thunder.Value = -2;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Handicraft(2))
                .AddSkill(new NormalRapidUp(2))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RecoverySpeed(3))
                .AddSkill(new Handicraft(3))
                .AddSkill(new AmmoUp(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new KushalaBlessing(2))
                .AddSkill(new Agitator(2))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new KushalaBlessing(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new KushalaBlessing(1))
                .AddSkill(new Handicraft(1))
                .AddSkill(new NormalRapidUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}