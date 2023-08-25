class Installment
{
  public DateTime DueDate { get; set; }
  public double Amount { get; set; }

  public IOnlinePayment _onlinePayment;

  public Installment(int installmentNumber, IOnlinePayment onlinePayment, DateTime dueDate, double amount)
  {
    _onlinePayment = onlinePayment;

    DueDate = dueDate;
    Amount = _onlinePayment.GeneratePayment(installmentNumber, amount);
  }
}
