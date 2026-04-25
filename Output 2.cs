                // Output #2
                Console.WriteLine("RGBC");
                Console.WriteLine("Richard Gwapo Banking Corporation");
                Console.WriteLine("LOGIN");

                Console.Write("Enter your account number: ");
                string? inputAcc = Console.ReadLine();

                int index = -1;

                for (int i = 0; i < AccNum.Length; i++)
                {
                    if (inputAcc == AccNum[i])
                    {
                        index = i;
                        break;
                    }
                }

                if (index != -1)
                {
                    if (Status[index] == "Blocked")
                    {
                        Console.WriteLine("This account is blocked.");
                    }
                    else
                    {
                        int attempts = 0;
                        bool success = false;

                        while (attempts < 3)
                        {
                            Console.Write("Enter your pin number: ");
                            string? inputPin = Console.ReadLine();

                            if (inputPin == PinNum[index])
                            {
                                Console.WriteLine("Login Successful!");
                                success = true;
                                break;
                            }
                            else
                            {
                                attempts++;
                                Console.WriteLine("Incorrect PIN.");
                            }
                        }

                        if (!success)
                        {
                            Console.WriteLine("CAPTURED CARD…. PLEASE CALL 143-44");
                            Status[index] = "Blocked";
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Account number not found.");
                }
            }
            else if (choice == "Q" || choice == "q")
            {
                Console.WriteLine("Program Closed.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}


