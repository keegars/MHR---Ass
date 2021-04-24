using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Narwa : ArmorSet
    {
        public Narwa()
        {
            Name = "Narwa";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 76;
            Fire.Value = 2;
            Water.Value = 1;
            Ice.Value = -3;
            Thunder.Value = 4;
            Dragon.Value = -4;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ThunderAlignment(1))
                .AddSkill(new RapidMorph(1))
                .AddSkill(new OffensiveGuard(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new ThunderAlignment(1))
                .AddSkill(new Constitution(1))
                .AddSkill(new CriticalDraw(1));

            Arm = new ArmArmor(this)
                .AddSkill(new ThunderAlignment(1))
                .AddSkill(new Guard(1))
                .AddSkill(new Partbreaker(1));

            Waist = new WaistArmor(this)
                .AddSkill(new ThunderAlignment(1))
                .AddSkill(new Guard(1))
                .AddSkill(new Artillery(1));

            Leg = new LegArmor(this)
                .AddSkill(new ThunderAlignment(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new MarathonRunner(1));
        }
    }
}