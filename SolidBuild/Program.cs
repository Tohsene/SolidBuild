using System;

namespace SolidBuild
{
    class Program
    {
        static void Main(string[] args)
        {

            //leads by example
            //takes care of parent
            //takes care of younger ones
            //commands and settles disputes

            //public void FirstChildResp() { };
            
        }

        public class FirstChildRole
        {
            public OurLeader ourLeader;
            public IOurAltruistic ourAltruistic;
            public OurRoleModel ourRoleModel;

            public FirstChildRole(OurLeader ourLeader, IOurAltruistic ourAltruistic, OurRoleModel ourRoleModel)
            {
                this.ourLeader = ourLeader;
                this.ourAltruistic = ourAltruistic;
                this.ourRoleModel = ourRoleModel;
            }
            
            public void functions()
            {
                ourLeader.Leader();
                ourAltruistic.Altruistic();
                ourRoleModel.RoleModel();
            }
        }
        public class OurLeader
        {
            public void Leader() { }
        }

        public interface IOurAltruistic
        {
            void Altruistic();
               
        }
        public interface IConfident
        {
            void Confident();
        }
        public interface IProactive
        {
            void Proactive();
        }

        public class AltruisticToParents : IOurAltruistic
        {
            public void Altruistic() { }
        }
        public class AltruisticToOthers : IOurAltruistic
        {
            public void Altruistic() 
            {
                throw new NotImplementedException();
            }
        }
        public class OurRoleModel
        {
            public void RoleModel() { }
        }

    }
}
