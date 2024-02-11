using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class GamerManager: IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Oyuncu eklendi: " + gamer.NickName);
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi!!!: " + gamer.NickName);
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi: " + gamer.NickName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi: " + gamer.NickName);
        }
    }
}
