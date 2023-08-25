interface IOnlinePayment
{
  double GeneratePayment(int installmentNumber, double amount);
}