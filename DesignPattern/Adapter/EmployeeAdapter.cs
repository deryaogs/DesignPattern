namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employees = [];
            
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                employees.Add(new Employee(
                    int.Parse(employeesArray[i, 0]),
                    employeesArray[i, 1],
                    employeesArray[i, 2],
                    decimal.Parse(employeesArray[i, 3])
                ));
            }

            Console.WriteLine("Adapter converts array of employees to list of employees\n");
            thirdPartyBillingSystem.ProcessSalary(employees);
        }
    }
}