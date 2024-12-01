using System;
using System.Collections.Generic;

namespace _03._MessagesManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            List<User> users = new();

            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] data = input.Split('=');
                string command = data[0];

                switch (command)
                {
                    case "Add":
                        string username = data[1];
                        int sentMsgs = int.Parse(data[2]);
                        int receivedMsgs = int.Parse(data[3]);

                        // checking if the user already exists
                        if (users.Exists(user => user.Username == username))
                        {
                            continue;
                        }
                        else
                        {
                            // Add a new user
                            User user = new()
                            {
                                Username = username,
                                SentMsgs = sentMsgs,
                                ReceivedMsgs = receivedMsgs,
                            };
                            users.Add(user);
                        }
                        break;

                    case "Message":
                        MessageUser(data, users, capacity);
                        break;

                    case "Empty":
                        EmptyList(data, users);
                        break;

                    default:
                        break;
                }
            }

            // Output the users and their message counts
            Console.WriteLine($"Users count: {users.Count}");
            foreach (User user in users)
            {
                int sum = user.SentMsgs + user.ReceivedMsgs;
                Console.WriteLine($"{user.Username} - {sum}");
            }
        }

        // method to remove a certain user or all users
        static void EmptyList(string[] data, List<User> users)
        {
            string username = data[1];

            if (username == "All")
            {
                users.Clear();
            }
            else
            {
                var userToRemove = users.Find(x => x.Username == username);

                if (userToRemove != null)
                {
                    users.Remove(userToRemove);
                }
            }
        }

        // method to message a user
        static void MessageUser(string[] data, List<User> users, int capacity)
        {
            string sender = data[1];
            string receiver = data[2];

            User senderUser = users.Find(x => x.Username == sender);
            User receiverUser = users.Find(x => x.Username == receiver);

            if (senderUser != null && receiverUser != null)
            {
                // increase sent and received messages
                senderUser.SentMsgs++;
                receiverUser.ReceivedMsgs++;

                // checks if the sender has reached capacity
                bool senderReachedCapacity = (senderUser.SentMsgs + senderUser.ReceivedMsgs) >= capacity;
                // checks if the receiver has reached capacity
                bool receiverReachedCapacity = (receiverUser.SentMsgs + receiverUser.ReceivedMsgs) >= capacity;

                if (senderReachedCapacity)
                {
                    Console.WriteLine($"{sender} reached the capacity!");
                    users.Remove(senderUser);
                }

                if (receiverReachedCapacity)
                {
                    Console.WriteLine($"{receiver} reached the capacity!");
                    users.Remove(receiverUser);
                }
            }
        }
    }

    class User
    {
        public string Username { get; set; }
        public int SentMsgs { get; set; }
        public int ReceivedMsgs { get; set; }
    }
}
