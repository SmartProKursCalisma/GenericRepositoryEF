namespace GenericRepositoryEF.Entities.Entities
{
    public class Student : IBaseEntity
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string PhoneNumber { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
