class Freezer
{
    private string nameModel;
    private int graduationYear;
    private int serialNumber;
    private int price;
    private int popularity;

    public static int StandardWarrantyYears;
    public static int TotalFreezers;
    static Freezer()
    {

        StandardWarrantyYears = 2;
        TotalFreezers = 0;
    }

    public string NameModel
    {
        get { return nameModel; }
        set { nameModel = value; }
    }
    public int GraduationYear
    {
        get { return graduationYear; }
        set
        {
            if (value > 2018 && value < 2024)
            {
                graduationYear = value;
            }
        }
    }
    public int SerialNumber
    {
        get { return serialNumber; }
        set
        {
            if (value > 0)
            {
                serialNumber = value;
            }
        }
    }
    public int Price
    {
        get { return price; }
        set
        {
            if (value > 0 && value < 50000)
            {
                price = value;
            }
        }
    }

    public int Popularity
    {
        get { return popularity; }
        set
        {
            if (value > 0 && value <= 5)
            {
                popularity = value;
            }
        }
    }


    public Freezer() : this("Unknown Model", 2022, 0, 0, 1) { }


    public Freezer(string nameModel) : this(nameModel, 2022, 0, 0, 1) { }


    public Freezer(string nameModel, int graduationYear) : this(nameModel, graduationYear, 0, 0, 1) { }


    public Freezer(string nameModel, int graduationYear, int serialNumber, int price, int popularity)
    {
        this.nameModel = nameModel;
        this.graduationYear = graduationYear;
        this.serialNumber = serialNumber;
        this.price = price;
        this.popularity = popularity;
        TotalFreezers++;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Freezer Name: " + nameModel);
        Console.WriteLine("Freezer Price: $" + price);
        Console.WriteLine("Freezer Popularity: " + popularity);
        Console.WriteLine("Standard Warranty: " + StandardWarrantyYears + " years");
    }

    public void IncreasePopularity()
    {
        if (popularity < 5)
        {
            popularity++;
        }
    }

    public void DecreasePrice(int amount)
    {
        if (price - amount > 0)
        {
            price -= amount;
        }
    }

    public void UpdatePrice(ref int newPrice)
    {
        if (newPrice > 0 && newPrice < 50000)
        {
            price = newPrice;
        }
    }


    public override string ToString()
    {
        return $"Freezer Name: {nameModel}, Graduation Year: {graduationYear}, Serial Number: {serialNumber}, Price: ${price}, Popularity: {popularity}, Standard Warranty: {StandardWarrantyYears} years";
    }
}
