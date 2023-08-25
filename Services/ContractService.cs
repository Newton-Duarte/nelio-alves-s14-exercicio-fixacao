class ContractService
{
  IOnlinePaymentService _OnlinePayment;

  public ContractService(IOnlinePaymentService onlinePayment)
  {
    _OnlinePayment = onlinePayment;
  }

  public void ProcessContract(Contract contract, int installmentsCount)
  {
    double installmentAmount = contract.Total / installmentsCount;

    int counter = 1;
    while (counter <= installmentsCount)
    {
      double amountWithInterest = installmentAmount + _OnlinePayment.Interest(installmentAmount, counter);
      double amountWithPaymentFee = amountWithInterest + _OnlinePayment.PaymentFee(amountWithInterest);
      var installment = new Installment(contract.Date.AddMonths(counter), amountWithPaymentFee);

      contract.AddInstallment(installment);
      counter++;
    }
  }
}