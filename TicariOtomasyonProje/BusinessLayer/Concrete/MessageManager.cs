﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _messageDal.Get(x => x.MessageID == id);
        }

        public List<Message> GetMessageListInbox(string p)
        {
            return _messageDal.List(x => x.ReceiverMail ==p);
        }

        public List<Message> GetMessageListSendbox(string p)
        {
            return _messageDal.List(x => x.SenderMail == p);
        }

        public void messageAdd(Message message)
        {
            _messageDal.Insert(message);
        }

        public void messageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void messageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
