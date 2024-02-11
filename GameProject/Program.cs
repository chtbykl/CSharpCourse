namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                Email = "chtbykl38@gmail.com",
                FirstName = "cihat",
                LastName = "bıyıklı",
                IdentityNumber = 1234,
                NickName = "Kamuran Akkor"
            });
        }
    }
}
