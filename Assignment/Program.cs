using Assignment.Part02Question01;
using Assignment.Part02Question02;
using Assignment.Part02Question03;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //Question 01
            // => (b) to define a blueprint for a class

            //Question 02
            // => (a) private

            //Question 03
            // => (c) only if they are static

            //Question 04
            // => (b) yes, interfaces can inherit from multiple interfaces

            //Question 05
            // => (d) implements, but that is the meaning only , in action we use colon 

            //Question 06
            // => (a) yes

            //Question 07
            // => (b) no, all members are implicitly public

            //Question 08
            // => (a) to hide the interface members from outside access

            //Question 09
            // => (b) no, interfaces cannot have constructors

            //Question 10
            // => (c) by separating interfaces names with commas
            #endregion

            #region Part02

            #region Question 01

            //Circle circle = new Circle(4.5);
            //Rectangle rectangle = new Rectangle(4, 5);

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Question 02
            //var user = new User("amr", "1234", Role.Viewer);
            //IAuthenticationService authService = new BasicAuthenticationService(user);

            //Console.WriteLine($"Authentication => {authService.AuthenticateUser("amr", "1234")}");
            //Console.WriteLine($"Authorization => {authService.AuthorizeUser("amr",Role.Editor)}");

            #endregion

            #region Question 03
            //INotificationService emailSender = new EmailNotificationService();
            //INotificationService smsSender = new SmsNotificationService();
            //INotificationService pushSender = new PushNotificationService();

            //emailSender.SendNotification("amr ayman", "email for amr ayman");
            //smsSender.SendNotification("Ahmed", "Sms for amr ayman");
            //pushSender.SendNotification("Ali", "Push Notify for amr ayman");

            #endregion

            #endregion
        }
    }
}
