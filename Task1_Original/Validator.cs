public class Validator
{
    public bool ValidateFormat(string data)
    {
        Console.WriteLine("Validator: Validating format...");
        return !string.IsNullOrWhiteSpace(data);
    }
}