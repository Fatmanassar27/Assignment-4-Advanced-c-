using Demo.Fifa;
using Demo.Youtube;
using System.Collections;
//using System.Threading.Channels;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1
            //Ball ball = new Ball() { Id = 10 };
            //ball.Location = new Location { X=1 , Y=1 , Z=1 };
            //Player P01 = new Player() { Name = "Messi" , TeamName = "Miami"};
            //Player P02 = new Player() { Name = "Alpa" , TeamName = "Miami"};

            //Player P03 = new Player() { Name = "Pedri" , TeamName = "Barcalona"};
            //Player P04 = new Player() { Name = "Gavi" , TeamName = "Barcalona"};

            //Player P05 = new Player() { Name = "Liva" , TeamName = "Barcalona"};

            //Refree refree = new Refree() { Name = "Ibrahim Nor El Din"};
            //ball.Location = new Location { X=1 , Y=1 , Z=1 };
            //Console.WriteLine( ball.ToString());

            //ball.BallLocationChanged += P01.Run;
            //ball.BallLocationChanged += P02.Run;
            //ball.BallLocationChanged += P03.Run;
            //ball.BallLocationChanged += P04.Run;
            //ball.BallLocationChanged += refree.Look;


            //ball.Location = new Location { X=1 , Y=1 , Z=2 };

            //ball.BallLocationChanged += P05.Run;
            //ball.BallLocationChanged -= P04.Run;

            //ball.Location = new Location { X=1 , Y=1 , Z=3 }; 
            #endregion

            #region part 2
            //Channel channel = new Channel() { ChannelName = "ABC" };
            //channel.AddVedio(new Vedio() { Title = "Title01", Description = "Desc01" });

            //Subscriber subscriber01 = new Subscriber() { SubscriberName = "Ahmed" };
            //Subscriber subscriber02 = new Subscriber() { SubscriberName = "Ali" };
            //Subscriber subscriber03 = new Subscriber() { SubscriberName = "Amr" };
            //Subscriber subscriber04 = new Subscriber() { SubscriberName = "Aliaa" };
            //Subscriber subscriber05 = new Subscriber() { SubscriberName = "fatma" };

            //channel.UploadVedio += subscriber01.Notifi;
            //channel.UploadVedio += subscriber02.Notifi;
            //channel.UploadVedio += subscriber03.Notifi;
            //channel.UploadVedio += subscriber04.Notifi;

            //channel.AddVedio(new Vedio() { Title = "Title02", Description = "Desc02" });

            //Console.WriteLine("===============================");
            //channel.UploadVedio -= subscriber03.Notifi;
            //channel.UploadVedio += subscriber05.Notifi;
            //channel.AddVedio(new Vedio() { Title = "Title03", Description = "Desc03" }); 
            #endregion

            #region part 3
            //Hashtable Note = new Hashtable();
            //Hashtable Note02 = new Hashtable();
            //Console.WriteLine($"count = {Note.Count}");
            //Note.Add("Ahmed", 1111);
            //Note.Add("Ali", 5555);
            //Note.Add("Omar", 7777);
            //Note.Add("Fatma", 4444);
            //Console.WriteLine($"count = {Note.Count}");
            //Note.Remove("Omar");
            //Console.WriteLine("=====================================");

            //foreach (DictionaryEntry item in Note)
            //{
            //    Console.WriteLine($"{item.Key} , {item.Value}");
            //}
            //Console.WriteLine( Note.Contains("Ahmed") );
            //Console.WriteLine( Note["Ahmed"] ); 
            #endregion


        }
    }
}
