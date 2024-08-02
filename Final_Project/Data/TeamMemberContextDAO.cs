/*using Final_Project.Models;
using Final_Project;

namespace Final_Project.Data
{
    public class TeamMemberContextDAO
    {
        private readonly ApplicationDBContext _context;
        public TeamMemberContextDAO(ApplicationDBContext context) {
            _context = context;
        }
        public int AddMember(int id, string name, string birthdate, string program, string year)
        {
            foreach (var member in _context.TeamMembers)
            {
                if (member.Id == id)
                {
                    return -1;
                }
            }
            try
            {
                _context.TeamMembers.Add(new TeamMember(id, name, birthdate, program, year));
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }
        public List<TeamMember> GetMember(int? id)
        {
            List<TeamMember> teamMembers = teamMembers = _context.TeamMembers.ToList().OrderByDescending(x => -x.Id).ToList();
            List<TeamMember> returnList = new List<TeamMember>();
            var teamMember = _context.TeamMembers.FirstOrDefault(x => x.Id == id);
            if(teamMember == null)
            {
                for(int i = 0; i < 5; i++)
                {
                    if (i == teamMembers.Count)
                    {
                        break;
                    }
                    returnList.Add(teamMembers[i]);
                }
            } else
            {
                returnList.Add(teamMember);
            }
            return teamMembers;
        }
    }
}
*/