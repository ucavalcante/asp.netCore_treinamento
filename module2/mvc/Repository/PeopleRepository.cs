namespace mvc.Repository
{
    
    public interface IPeopleRepository
    {
        string GetNameById(int id);
    }

    public class PeopleRepository: IPeopleRepository
    {
        public PeopleRepository(string connectionString)
        {
            
        }

        public string GetNameById(int ID) 
        { 
            
            return "Josef Abrah";
        }
    }
}