class Contract
{
  public int Number { get; set; }
  public DateTime Date { get; set; }
  public double Total { get; set; }
  public List<Installment> Installments { get; } = new();

  public Contract(int number, DateTime date, double total)
  {
    Number = number;
    Date = date;
    Total = total;
  }

  public void AddInstallment(Installment installment)
  {
    Installments.Add(installment);
  }
}