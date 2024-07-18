using System;

class Program
{
	static void Main(string[] args)
	{


		
		List<Comment> videoOneComments = new List<Comment>()
		{
			new Comment("John", "I love your videos"),
			new Comment("Martha", "Please focus on the purpose of the products next time"),
			new Comment("Mary", "could you explain about how I can get a TV online in the next Video"),
			new Comment("Ruth", "I learned a lot, thanks!")
		};
		
		List<Comment> videoTwoComments = new List<Comment>()
		{
			new Comment("Andrew", "thanks for your help"),
			new Comment("Ben", "My young brother had a rough time losing, thanks"),
			new Comment("Charles", "Does this product really work?"),
			new Comment("David", "To good to be true!")
		};
		
		List<Comment> videoThreeComments = new List<Comment>()
		{ 
			new Comment("Edson", "Can I mix the peanut with gum?"), 
			new Comment("Fedrick", "I liked the peanut."), 
			new Comment("George", "Good product guys!"), 
			new Comment("Hunter", "Where can I get the product?") 
		};
		
		List<Comment> videoFourComents = new List<Comment>() 
		{ 
			new Comment("Jack", "My computer takes time to load programs could it be the processor?"), 
			new Comment("Jane", "Can I use the processor for my video editing?"), 
			new Comment("Juliet", "wow!"), 
			new Comment("Joseph", "I am empressed!") 
		};

		
		List<Video> videos = new List<Video>() {
			new Video("Skin Care", "Martin Whitworth", 23, videoOneComments),
			new Video("The Power of Core i5", "Mark", 120, videoFourComents),
			new Video("How To Use Peanut Butter", "Samuel", 60, videoThreeComments),
			new Video("Lose Weight within a Week", "Benjamin Bergout", 300, videoTwoComments)
			};

		foreach (Video video in videos)
		{
			video.GetVideoDetails();
		}
	}
}