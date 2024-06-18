public class Resume
{
    public string _personName;
    public List<Job> Jobs = new List<Job>();
    public void displayResume()
    {
        Console.WriteLine(_personName);
        Console.WriteLine("Jobs:");
        
        foreach (Job job in Jobs)
        {
            job.JobDetails();
        }
    }
}