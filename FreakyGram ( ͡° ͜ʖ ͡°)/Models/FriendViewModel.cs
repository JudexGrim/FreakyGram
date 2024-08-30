namespace FreakyGram___͡__͜ʖ_͡__.Models
{
	public class FriendViewModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string ProfilePictureLink { get; set; }
		public List<UserModel> Friends { get; set; }

        public FriendViewModel(long id)
        {
            //initializes props from UserModel of id
        }


    }
}
