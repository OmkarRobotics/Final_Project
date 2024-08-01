using Final_Project.Models;

namespace Final_Project.Data
{
    public class TeamMemberContextDAO
    {
        TeamMemberContext _context;
        public TeamMemberContextDAO(TeamMemberContext context) {
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
            catch (Exception ex)
            {
                return -1;
            }
            return 1;
        }
    }
}
