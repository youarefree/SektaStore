using SpeedyIntegration.Models.Response;
using System;
using System.Linq;


namespace SpeedyIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMsg = string.Empty;    
            var OfficeList = Integration.GetOfficeListByCity("Sofia",ref errorMsg);

            foreach (Office office in OfficeList)
            {
                Console.WriteLine(office.address.localAddressString);
            }

            //var office1 = from workingTime in OfficeList.workingTimeSchedule
            //            where office.workingTimeSchedule[0].WorkingTimeFrom == "08:30"

            var office1 = OfficeList.Where(office => office.workingTimeSchedule.Any(workSchedule => workSchedule.WorkingTimeTo == "09:00"));

            //Console.WriteLine(OfficeList.Where(s => (s.WorkingTimeFrom == "08:30"));
            Console.ReadLine();
        }

        
    }
}
