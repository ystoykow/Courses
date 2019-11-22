namespace MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<Mission> missions;
        public Commando(string firstName, string lastName, string id, decimal salary, string corps, params string[] missions)
            : base(firstName, lastName, id, salary, corps)
        {
            this.missions = new List<Mission>();
            AddMissions(missions);
        }

        public IReadOnlyCollection<Mission> Missions => this.missions;

        public void CompleteMission(string codeName)
        {
            throw new NotImplementedException();
        }

        private void AddMissions(string[] missions)
        {
            for (int i = 0; i < missions.Length; i += 2)
            {
                string name = missions[i];
                string state = missions[i + 1];
                Mission currentMission = new Mission(name, state);
                if (currentMission.State != null)
                {
                    this.missions.Add(currentMission);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            foreach (var mission in this.Missions)
            {
                sb.AppendLine(mission.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
