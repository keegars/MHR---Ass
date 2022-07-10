using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GuildPalace : ArmorSet
    {
        public GuildPalace()
        {
            Name = "Guild Palace";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 138;
            Fire.Value = 1;
            Water.Value = 2;
            Ice.Value = 1;
            Thunder.Value = 2;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Agitator(1))
                .AddSkill(new OffensiveGuard(1))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Agitator(2))
                .AddSkill(new Heroics(2))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Agitator(2))
                .AddSkill(new Coalescence(2))
                .AddSkill(new WallRunnerBoost(2))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Heroics(2))
                .AddSkill(new OffensiveGuard(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Heroics(2))
                .AddSkill(new Coalescence(2))
                .AddSlot(new LargeSlot());
        }
    }
}