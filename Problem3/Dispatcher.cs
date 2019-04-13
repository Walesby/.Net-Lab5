using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// Represents the dispatcher that dispatches the mail to the workers
    /// </summary>
    class Dispatcher
    {
        private static Dispatcher instance;        
        private static List<Worker> workers;
        private Queue<Mail> mailToBeOrganized = new Queue<Mail>();
        private Queue<Worker> availableWorkers = new Queue<Worker>();
        private Queue<Mail> flaggedMail = new Queue<Mail>();
        private List<Mail> packages = new List<Mail>();
        private List<Mail> letters = new List<Mail>();
        private Dispatcher()
        {

        }
        public static Dispatcher Instance => instance ?? (instance = new Dispatcher());

        /// <summary>
        /// Adds a new piece of mail to the queue
        /// </summary>
        /// <param name="mail"></param>
        public void QueueMail(Mail mail)
        {
            if (this.availableWorkers.Count <= 0)
            {
                this.mailToBeOrganized.Enqueue(mail);
                this.availableWorkers.Enqueue(new Worker());
            }
            else
            {
                var worker = this.availableWorkers.Dequeue();
                var isFlagged = worker.IsFlagged(mail);
                if (isFlagged == false)
                {
                    var mailType = worker.AddMailToMailbox(mail);
                    if (mailType == "Package")
                    {
                        packages.Add(mail);
                        availableWorkers.Enqueue(worker);
                        
                    }
                    else
                    {
                        letters.Add(mail);
                        availableWorkers.Enqueue(worker);
                    }
                }
                else
                {
                    flaggedMail.Enqueue(mail);
                    availableWorkers.Enqueue(worker);
                }


            }
        }
    }
}
