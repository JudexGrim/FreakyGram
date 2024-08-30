using System.Buffers.Text;

namespace FreakyGram___͡__͜ʖ_͡__.Models
{
	public class UserModel
	{

        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
		public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProfilePictureLink { get; set; }

        public UserModel( long id)
        {
            //Initialize all props from Database
        }

        public string EditName ()
        {
            return "";
        }
    }
}
