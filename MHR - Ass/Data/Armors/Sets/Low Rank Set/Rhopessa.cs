using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Rhopessa : ArmorSet
    {
        public Rhopessa()
        {
            Name = "Rhopessa";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 68;
            Fire.Value = -2;
            Water.Value = 0;
            Ice.Value = -2;
            Thunder.Value = 3;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalElement(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalElement(1))
                .AddSkill(new DragonAttack(1));

            Arm = new ArmArmor(this)
                .AddSkill(new EvadeWindow(1));

            Waist = new WaistArmor(this)
                .AddSkill(new DragonAttack(2));

            Leg = new LegArmor(this)
                .AddSkill(new CriticalEye(2));
        }
    }
}