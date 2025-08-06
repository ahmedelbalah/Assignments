namespace MNF3_S1_DAY1
{
    class bank {
        public const String BankCode = "BNK001";

        public readonly DateTime CreateDate;

        public static int _accountNumber = 0;

        private String _FullName;
        private String _nationalID;
        private String _phoneNumber;
        private String _address;
        private int _balance;

        public int accountNumber { get { return _accountNumber; } }
        public String FullName
        {
            get { return _FullName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _FullName = value;
                else
                    Console.WriteLine("FullName must not be null or empty.");

            }
        }

        public String nationalID
        {
            get { return _nationalID; }
            set
            {
                if (IsValidNationalID(value))
                    _nationalID = value;
                else
                    Console.WriteLine("Must be exactly 14 digits.");
            }
        }

        public String phoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (IsValidPhoneNumber(value))
                    _phoneNumber = value;
                else
                    Console.WriteLine("Must start with (01) and be 11 digits long");
            }
        }
        public String address { get { return _address; } set { _address = value; } }
        public int balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
                else
                    Console.WriteLine("Must be greater than or equal to 0.");
            }
        }


        //constractors

        public bank()
        {
            FullName = "no name";
            nationalID = "no Id";
            phoneNumber = "no phone";
            address = "no address";
            balance = 0;
            _accountNumber++;
        }

        public bank(string ffullName, string nnationalID, string pphoneNumber, string aaddress, int bbalance)
        {

            FullName = ffullName;
            nationalID = nnationalID;
            phoneNumber = pphoneNumber;
            address = aaddress;
            balance = bbalance;
            _accountNumber++;
        }

        public bank(string ffullName, string nnationalID, string pphoneNumber, string aaddress)
        {

            FullName = ffullName;
            nationalID = nnationalID;
            phoneNumber = pphoneNumber;
            address = aaddress;
            balance = 0;
            _accountNumber++;
        }

        public void ShowAccountDetails()
        {
            Console.WriteLine($"fullName = {_FullName} ,nationalID = {_nationalID} ,phoneNumber = {_phoneNumber} ,_address = {_address} ,balance = {_balance}");

        }

        private bool IsValidNationalID(string nationalID)
        {
            if (nationalID.Length == 14)
                return true;


            return false;
        }

        public bool IsValidPhoneNumber(string phoneNumber)

        {
            if (phoneNumber.Length == 11 && phoneNumber.StartsWith("01"))
                return true;

            return false;
        }



    }

    class Program
    {
        static void Main(string[] args) {
        bank bank1 = new bank("Ahmed Elbalah","12345678765423","01065412312","london",400);
            bank1.ShowAccountDetails();

        bank bank2 = new bank("Mohamed Elbalah", "12345678765423", "01064512312", "america", 500);
            bank2.ShowAccountDetails();


        }


    }
}
