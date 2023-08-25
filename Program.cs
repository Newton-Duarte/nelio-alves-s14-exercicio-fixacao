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

var contractService = new ContractService(new PayPalService());
contractService.ProcessContract(contract, installmentsCount);

System.Console.WriteLine("INSTALLMENTS:");
foreach(var installment in contract.Installments)
{
  System.Console.WriteLine(installment);
}