using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class AnjanathX : ArmorSet
    {
        public AnjanathX()
        {
            Name = "Anjanath X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 106;
            Fire.Value = 3;
            Water.Value = -3;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new Slugger(1))
                .AddSkill(new AttackBoost(1))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Focus(2))
                .AddSkill(new MarathonRunner(2))
                .AddSkill(new Agitator(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Slugger(2))
                .AddSkill(new AttackBoost(2))
                .AddSkill(new Agitator(2))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new AttackBoost(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new MarathonRunner(2))
                .AddSkill(new Agitator(2))
                .AddSlot(new LargeSlot());
        }
    }
}