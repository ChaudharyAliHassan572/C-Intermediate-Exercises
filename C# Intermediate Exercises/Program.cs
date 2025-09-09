using System;
using C__Intermediate_Exercises.Exercises;
public class program
{
    public static void Main(string[] args)
    {
        // Exercise #1
        StopWatch stopWatch = new StopWatch();
        stopWatch.Start();
        Console.WriteLine("The StopWatch is Started at: " + stopWatch.StartTime);
        Thread.Sleep(1000);
        stopWatch.Stop();
        Console.WriteLine("The StopWatch is Stopped at: " + stopWatch.StopTime);
        Console.WriteLine(stopWatch.Duration);

        //Exercise #2
        StackOverFlowPost post = new StackOverFlowPost();
        post.CreatePost("Hello World", "This is my first post");
        post.UpVote();
        Console.WriteLine("Post Title: {0} \n Post Description: {1}  \n  Post Votes: {2} ", post.Title,post.Description,post.VoteCount);

        //Exercise #3
        DbConnection sqlConnection = new SqlConnection("Server=localhost;Database=myDb;User Id=myUsername;Password=myPassword;", TimeSpan.FromSeconds(30));
        sqlConnection.OpenConnection();
        Console.WriteLine("Connection String: " + sqlConnection.ConnectionString);
        sqlConnection.CloseConnection();
        DbConnection oracleConnection = new OracleConnection("Data Source=myOracleDB;User Id=myUsername;Password=myPassword;", TimeSpan.FromSeconds(30));
        oracleConnection.OpenConnection();
        Console.WriteLine("Connection String: " + oracleConnection.ConnectionString);
        oracleConnection.CloseConnection();

        //Exercise #4
        DbConnection sqlConnectionCommand = new SqlConnection("Server=localhost;Database=myDb;User Id=myUsername;Password=myPassword;", TimeSpan.FromSeconds(30));
        DbCommand dbCommand = new DbCommand(sqlConnectionCommand, "SELECT * FROM Users");
        sqlConnection.OpenConnection();
        dbCommand.Execute();
        sqlConnection.CloseConnection();

        //Exercise #5
        var workFlow=new WorkFlow();
        workFlow.AddActivity(new UploadVideo());
        workFlow.AddActivity(new CallEncodingService());
        workFlow.AddActivity(new SendEmail());
        workFlow.AddActivity(new UpdateStatus());
        workFlow.GetActivities();
        WorkFlowEngine workFlowEngine=new WorkFlowEngine();
        workFlowEngine.Run(workFlow);
    }
}
