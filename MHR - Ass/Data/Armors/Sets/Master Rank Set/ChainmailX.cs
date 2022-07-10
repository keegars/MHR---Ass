using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class ChainmailX : ArmorSet
    {
        public ChainmailX()
        {
            Name = "Chainmail X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 94;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new StaminaSurge(1))
                .AddSkill(new DefenseBoost(1))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new DefenseBoost(1))
                .AddSkill(new FlinchFree(1))
                .AddSkill(new Guard(1))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new StaminaSurge(1))
                .AddSkill(new DefenseBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Guard(2))
                .AddSkill(new FlinchFree(2))
                .AddSkill(new DefenseBoost(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new StaminaSurge(1))
                .AddSkill(new Guard(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}