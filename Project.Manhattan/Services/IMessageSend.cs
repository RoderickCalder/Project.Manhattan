using System.Security.Cryptography.X509Certificates;
using Project.Manhattan1.Models;

namespace Project.Manhattan1.Services
{
    public interface IMessageSend
    {
        bool SendMessages(MessageModel messageModel);
    }
}