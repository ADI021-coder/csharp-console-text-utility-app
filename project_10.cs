{
    // IF ELSE VERSION
    string choice;
		
		do{
		Console.WriteLine("Choose an Option");
		Console.WriteLine("1. Upper Case");
		Console.WriteLine("2. Lower Case");
		Console.WriteLine("3. Exit");
		choice = Console.ReadLine();
			
		if (choice == "1")
		{
			Console.Write("enter text here: ");
			string input = Console.ReadLine();
			Console.WriteLine(input.ToUpper());
			Console.WriteLine("your text contains " + input.Length + " letters");
		}
		else if (choice == "2")
		{
			Console.Write("enter text here: ");
			string input = Console.ReadLine();
			Console.WriteLine(input.ToLower());
			Console.WriteLine("your text contains " + input.Length + " letters");
		}
		else
		{
			Console.WriteLine("exit");
		}
		}while(choice != "3");
}
{
    // SWITCH VERSION
    int choice;
		do{
		Console.WriteLine("Choose an Option");
		Console.WriteLine("1. Upper Case");
		Console.WriteLine("2. Lower Case");
		Console.WriteLine("3. Exit");
		string userChoice = Console.ReadLine();
		choice = Convert.ToInt32(userChoice);
		
		switch (choice)
		{
			case 1 :
			Console.Write("enter text here ");
			string input = Console.ReadLine();
			Console.WriteLine(input.ToUpper());
			Console.WriteLine("your text contains " + input.Length + " letters");
			break;
				
			case 2 : 
			Console.Write("enter text here ");
			string input1 = Console.ReadLine();
			Console.WriteLine(input1.ToLower());
			Console.WriteLine("your text contains " + input1.Length + " letters");
			break;
				
			default : 
			Console.WriteLine("exit");
				break;
		}
		}while(choice != 3);
}