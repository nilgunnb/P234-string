







string Name = "LeonardoDavinci";


CustomSubstring( Name, 3, 2);


string CustomSubstring ( string key, int startindex, int Length)
{ 
    
    try
    {
        string Name = key.Substring(startindex, Length);
    }

    catch ( Exception ex) 
    {
        Console.WriteLine("One of the indexes or both of them are not valid. please, check your work.");
    }


    return Name;
    
}


Name = Name.Substring(3,2);

Console.WriteLine(Name);

