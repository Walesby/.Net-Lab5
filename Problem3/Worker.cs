using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// Represents a worker they are responsible for handling the mail
    /// </summary>
    class Worker
    {
        private static int WorkerNumber = 1;
        public int Id { get;}
        /// <summary>
        /// Creates a new Worker
        /// </summary>
        public Worker()
        {
            this.Id = WorkerNumber;
            WorkerNumber += 1;
        }

        /// <summary>
        /// Used to determine which mailbox the worker should add the mail to
        /// </summary>
        /// <param name="mail">Piece of mail that is to be sorted by the worker</param>
        /// <returns>"Package" if its a package or "Letter" if its a letter</returns>
        public string AddMailToMailbox(Mail mail)
        {
            var mailType = mail;
            if (mail.Type == "Package")
            {
                return "Package";
            }
            else
            {
                return "Letter";
            }
        }

        /// <summary>
        /// Used to determine if the mail is flagged
        /// If it's flagged the user will add it to the queue
        /// </summary>
        /// <param name="mail">Piece of mail that is being sorted by the worker</param>
        /// <returns>True if something is wrong with it false if its okay</returns>
        public bool IsFlagged(Mail mail)
        {
            var isFlagged = mail.Flagged;
            if (isFlagged == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
