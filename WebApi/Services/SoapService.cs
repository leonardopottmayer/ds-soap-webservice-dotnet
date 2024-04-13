using WebApi.Models;

namespace WebApi.Services;

public class SoapService : ISoapService
{
    public string Run(SoapModel model)
    {
        try
        {
            double number1 = Convert.ToDouble(model.Number1);
            double number2 = Convert.ToDouble(model.Number2);

            switch (model.Operation)
            {
                case "+":
                    return Convert.ToString(number1 + number2);
                case "-":
                    return Convert.ToString(number1 - number2);
                case "*":
                    return Convert.ToString(number1 * number2);
                case "/":
                    if (number2 != 0)
                    {
                        return Convert.ToString(number1 / number2);
                    }
                    else
                    {
                        throw new ArgumentException("Cannot divide by 0.");
                    }
                default:
                    throw new ArgumentException("Invalid operation.");
            }
        }
        catch (Exception)
        {
            return "Invalid data.";
        }
    }
}