using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class DiablosX : ArmorSet
    {
        public DiablosX()
        {
            Name = "Diablos X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 134;
            Fire.Value = 3;
            Water.Value = -1;
            Ice.Value = -3;
            Thunder.Value = -1;
            Dragon.Value = -1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Guard(3))
                .AddSkill(new TremorResistance(3))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Guard(2))
                .AddSkill(new OffensiveGuard(2))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new OffensiveGuard(2))
                .AddSkill(new StaminaSurge(2))
                .AddSkill(new PierceUp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Heroics(1))
                .AddSkill(new StaminaSurge(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Heroics(2))
                .AddSkill(new TremorResistance(2))
                .AddSlot(new LargeSlot());
        }
    }
}