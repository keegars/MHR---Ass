using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GuildCross : ArmorSet
    {
        public GuildCross()
        {
            Name = "Guild Cross";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 24;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Botanist(1))
                .AddSkill(new HungerResistance(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Geologist(1))
                .AddSkill(new MarathonRunner(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Geologist(1))
                .AddSkill(new WallRunner(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Botanist(1))
                .AddSkill(new WirebugWhisperer(1));

            Leg = new LegArmor(this)
                .AddSkill(new Geologist(1))
                .AddSkill(new CarvingPro(1));
        }
    }
}