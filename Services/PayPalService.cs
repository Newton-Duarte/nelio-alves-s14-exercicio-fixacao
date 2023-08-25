class PayPalService : IOnlinePayment
{
  private const double INSTALLMENT_INTEREST = 0.01;
  private const double INSTALLMENT_TAX = 0.02;
  public double GeneratePayment(int installmentNumber, double amount)
  {
    double amountWithInterest = amount + amount * INSTALLMENT_INTEREST * installmentNumber;
    double amountWithTax = amountWithInterest + amountWithInterest * INSTALLMENT_TAX;
    return amountWithTax;
  }
}