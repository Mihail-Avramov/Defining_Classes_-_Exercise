using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembersList;

        public Family()
        {
            this.familyMembersList = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.familyMembersList.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.familyMembersList.MaxBy(m => m.Age);
        }

        public List<Person> GetOlderThan30()
        {
            return this.familyMembersList.FindAll(m => m.Age > 30);
        }

    }
}
