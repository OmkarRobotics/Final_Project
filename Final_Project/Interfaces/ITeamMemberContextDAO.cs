using Final_Project.Models;

namespace Final_Project.Interfaces;

    public interface ITeamMemberContextDAO
    {
        public int AddMember(int id, string name, string birthdate, string program, string year);
        public List<TeamMember> GetMember(int? id);
    }

