using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class AnjanathS : ArmorSet
    {
        public AnjanathS()
        {
            Name = "Anjanath S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 80;
            Fire.Value = 3;
            Water.Value = -3;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new Slugger(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Focus(2))
                .AddSkill(new MarathonRunner(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Slugger(2))
                .AddSkill(new AttackBoost(2))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new MarathonRunner(2))
                .AddSlot(new MediumSlot());
        }
    }
}