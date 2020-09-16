using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProfileUser.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProfileUser.Controllers
{
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly List<Profile> users = new List<Profile>();
        public ProfileController()
        {
            users.Add(new Profile()
            {
                PID = 1,
                Name = "Tsekiso",
                SurName = "Thokoana",
                Gender = "male",
                Contact = 57090909,
                Email = "stseki@gmail.com",
                Website = "www.stseki.com",
                About = "A mosotho young men who is inlove with software development",
                CV = " ",
                ProfilePic = " "
            });
            users.Add(new Profile()
            {
                PID = 2,
                Name = "Setumo",
                SurName = "Semakela",
                Gender = "male",
                Contact = 57133124,
                Email = "setumo@gmail.com",
                Website = "www.stseki.com",
                About = "A mosotho young men who is inlove with software development",
                CV = " ",
                ProfilePic = " "
            });
            users.Add(new Profile()
            {
                PID = 3,
                Name = "Khauta",
                SurName = "Maliehe",
                Gender = "male",
                Contact = 57133124,
                Email = "stseki@gmail.com",
                Website = "www.stseki.com",
                About = "A mosotho young men who is inlove with software development",
                CV = " ",
                ProfilePic = " "
            });
            users.Add(new Profile()
            {
                PID = 4,
                Name = "Thabo",
                SurName = "Majoro",
                Gender = "male",
                Contact = 57133124,
                Email = "thiza@gmail.com",
                Website = "www.stseki.com",
                About = "A mosotho young men who is inlove with software development",
                CV = " ",
                ProfilePic = " "
            });
        }
        [HttpGet]
        public IEnumerable<Profile> Get()
        {
            return users;
        }

        [HttpGet("{id}", Name = "Get")]
        public Profile Get(int id)
        {
            return users.Find(x => x.PID == id);
        }

    }
}
