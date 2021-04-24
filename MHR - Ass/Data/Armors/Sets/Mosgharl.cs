using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Mosgharl : ArmorSet
    {
        public Mosgharl()
        {
            Name = "Mosgharl";
            

            //Base values
            BaseDefense = 18;
            Fire.Value = -3;
            Water.Value = 1;
            Ice.Value = 3;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new BlastResistance(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new ReloadSpeed(2));

            Arm = new ArmArmor(this)
                .AddSkill(new BlastResistance(1));

            Waist = new WaistArmor(this)
                .AddSkill(new FireAttack(2));

            Leg = new LegArmor(this)
                .AddSkill(new RecoilDown(2));
        }
    }
}