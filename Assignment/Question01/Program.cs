using Assignment.Question02;
using Assignment.Question03;

namespace Assignment.Question01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part02
            #region Question01
            Circle circle = new Circle()
            {
                Radius = 10
            };
            circle.DisplayShapeInfo();

            Rectangle rectangle = new Rectangle()
            {
                Width = 4,
                Height = 6
            };
            rectangle.DisplayShapeInfo();
            #endregion

            #region Question02
            IAuthenticationService authService = new BasicAuthenticationService()
            {
                UserName = "user",
                Password = "12345678",
                Role = "Admin"
            };
            Console.WriteLine(authService.AuthenticateUser("user","12345678")); //true
            Console.WriteLine(authService.AuthorizeUser("User","Admin")); //false because U is capital
            #endregion

            #region Question03
            INotificationService Email = new EmailNotificationService();
            Email.SendNotification("Omar@Gmail.com", "Message From Email");
            INotificationService SMS = new SmsNotificationService();
            SMS.SendNotification("0104444", "Message From SMS");
            INotificationService Push = new PushNotificationService();
            Push.SendNotification("Ahmed", "Message");
            #endregion

            #endregion
        }
    }
}
