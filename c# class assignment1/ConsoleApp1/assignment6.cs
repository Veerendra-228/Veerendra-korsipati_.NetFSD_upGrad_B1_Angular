using System;

class Billing
{
    public string PatientName;
    public double ConsultationFee;
    public double TestCharges;

    public void CalculateTotalBill()
    {
        double total = ConsultationFee + TestCharges;

        Console.WriteLine("Patient Name: " + PatientName);
        Console.WriteLine("Total Bill: " + total);
    }
}

class assignment6
{
    static void Main()
    {
        Billing bill = new Billing();

        bill.PatientName = "Ramesh";
        bill.ConsultationFee = 500;
        bill.TestCharges = 1000;

        bill.CalculateTotalBill();
    }
}