using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetMessageListInbox(string p);
        List<Message> GetMessageListSendbox(string p);
        void messageAdd(Message message);
        Message GetByID(int id);
        void messageDelete(Message message);

        void messageUpdate(Message message);
    }
}
