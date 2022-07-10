using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class NarwaPure : ArmorSet
    {
        public NarwaPure()
        {
            Name = "Narwa - Pure";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 140;
            Fire.Value = 2;
            Water.Value = 1;
            Ice.Value = -3;
            Thunder.Value = 4;
            Dragon.Value = -4;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ThunderAlignment(1))
                .AddSkill(new RapidMorph(1))
                .AddSkill(new OffensiveGuard(1))
                .AddSkill(new Stormsoul(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new ThunderAlignment(1))
                .AddSkill(new Constitution(1))
                .AddSkill(new CriticalDraw(1))
                .AddSkill(new Stormsoul(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ThunderAlignment(1))
                .AddSkill(new Guard(1))
                .AddSkill(new Partbreaker(1))
                .AddSkill(new Stormsoul(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ThunderAlignment(1))
                .AddSkill(new Guard(1))
                .AddSkill(new Artillery(1))
                .AddSkill(new Stormsoul(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new ThunderAlignment(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new MarathonRunner(1))
                .AddSkill(new Stormsoul(1))
                .AddSlot(new MediumSlot());
        }
    }
}