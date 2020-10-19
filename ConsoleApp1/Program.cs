 static string Alphabet_chechker()
        {
            bool check = true;
            string input;
            do
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    { Console.WriteLine("Empty input!"); check = false; return Alphabet_chechker(); }
                }
                foreach (char i in input)
                {
                
                    if (i < '0' || i > '9')
                    {
                        foreach (char a in "thequickbrownfoxjumpsoverthelazydogTHEQUICKBROWNFOXJUMPSOVERTHELAZYDOG")
                        {
                            if (a == i) { check = true; break; }
                            else { check = false; }
                        }
                    }
                    else { Console.WriteLine("input again!"); check = false; break; }
                    if (check == false) { Console.WriteLine("input again!"); break; }
                }
            } while (check == false);
            return input;
        }
