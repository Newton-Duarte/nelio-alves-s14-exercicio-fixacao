var payPalService = new PayPalService();

System.Console.WriteLine("Enter contract data:");
System.Console.Write("Number: ");
var number = int.Parse(Console.ReadLine());

System.Console.Write("Date (dd/MM/yyy): ");
var date = DateTime.Parse(Console.ReadLine());

System.Console.Write("Value: ");
var value = double.Parse(Console.ReadLine());

var contract = new Contract(number, date, value);

System.Console.Write("Enter number of installments: ");
var installmentsCount = int.Parse(Console.ReadLine());
int counter = 1;

while (counter <= installmentsCount)
{
  var installment = new Installment(counter, payPalService, date.AddMonths(30 * counter), value / installmentsCount);

  contract.AddInstallment(installment);
  counter++;
}

System.Console.WriteLine("INSTALLMENTS:");
foreach(var installment in contract.Installments)
{
  System.Console.WriteLine($"{installment.DueDate:dd/MM/yyyy} - {installment.Amount:F2}");
}

