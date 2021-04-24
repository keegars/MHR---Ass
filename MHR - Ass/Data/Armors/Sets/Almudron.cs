using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Almudron : ArmorSet
    {
        public Almudron()
        {
            Name = "Almudron";

            //Base values
            BaseDefense = 30;
            Fire.Value = -4;
            Water.Value = 3;
            Ice.Value = -2;
            Thunder.Value = 3;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new RapidMorph(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new RazorSharp(1));

            Arm = new ArmArmor(this)
                .AddSkill(new RapidMorph(1))
                .AddSkill(new EvadeWindow(1));

            Waist = new WaistArmor(this)
                .AddSkill(new PowerProlonger(1));

            Leg = new LegArmor(this)
                .AddSkill(new RazorSharp(1));
        }
    }
}