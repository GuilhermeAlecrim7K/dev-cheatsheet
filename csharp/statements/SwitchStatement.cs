int methodOfPayment = 2;
string methodOfPaymentName;

switch (methodOfPayment)
{
    case 1:
        methodOfPaymentName = "Credit Card";
        break;
    case 2:
        methodOfPaymentName = "Bank transfer";
        break;
    case 3:
        methodOfPaymentName = "Cash";
        break;
    case <= 0: // Just to illustrate, this line is not necessary
    default:
        methodOfPaymentName = "Not implemented. Could throw exception.";
        break;
}

Console.WriteLine($"The chosen method of payment was {methodOfPaymentName}");
