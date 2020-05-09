namespace KCetnarowicz
{
    public class AgentModule
    {
        public int param;
        public string name;
        public string shortName;
        
        protected int minParam = 0;
        protected int maxParam = 100;
    }
    public class ReasoningAbility : AgentModule
    {
        public ReasoningAbility()
        {
            name = "ReasoningAbility";
            shortName = "RA";
            minParam = 0;
            maxParam = 100;
        }
    }

    public class Objectives : AgentModule
    {
        public Objectives()
        {
            name = "Objectives";
            shortName = "OB";
            minParam = 0;
            maxParam = 100;
        }
    }


}