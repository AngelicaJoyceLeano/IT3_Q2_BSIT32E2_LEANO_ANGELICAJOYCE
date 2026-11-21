namespace IT3_Q2_BSIT32E2_LEANO_ANGELICAJOYCE.DTO.User
{
    public class GetUserResponse
    {
        public List<GetUserDTO> User {  get; set; }
        public int TotalCount => User?.Count ?? 0;
    }

    public class GetUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}

