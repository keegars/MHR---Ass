using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Volvidon : ArmorSet
    {
        public Volvidon()
        {
            Name = "Volvidon";
            

            //Base values
            BaseDefense = 20;
            Fire.Value = 2;
            Water.Value = -3;
            Ice.Value = -1;
            Thunder.Value = 0;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ParalysisAttack(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new RapidMorph(1));

            Arm = new ArmArmor(this)
                .AddSkill(new EvadeExtender(1));

            Waist = new WaistArmor(this)
                .AddSkill(new RapidMorph(1));

            Leg = new LegArmor(this)
                .AddSkill(new EvadeExtender(1));
        }
    }
}