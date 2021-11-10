using WPFApp.Database;

namespace WPFApp.Classes
{
    public class Driver : gibddDataSet.driversRow
    {
        public Driver(System.Data.DataRowBuilder rb) : base(rb)
        {
            id = 0;
            passport_serial = 0;
            passport_number = 0;
            postcode = 0;
            lastname = "";
            firstname = "";
            middlename = "";
            photo = "";
            phone = "";
            email = "";
            jobname = "";
            company = "";
            address = "";
            address_life = "";
        }
    }
}
