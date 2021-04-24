using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class UtsushiVisible : ArmorSet
    {
        public UtsushiVisible()
        {
            Name = "Utsushi (Visible)";
            

            //Base values
            BaseDefense = 24;
            Fire.Value = 3;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpeedEating(1))
                .AddSkill(new FreeMeal(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Wide_Range(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Wide_Range(1));

            Waist = new WaistArmor(this)
                .AddSkill(new SpeedEating(1));

            Leg = new LegArmor(this)
                .AddSkill(new Wide_Range(1));
        }
    }
}