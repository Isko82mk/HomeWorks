namespace Domain
{
    public abstract class Pet
    {
        abstract public string Name { get; set; }
        abstract public Tipe Tipe { get; set; }
        abstract public int Age { get; set; }

        abstract public void PrintInfo();
    }
}
