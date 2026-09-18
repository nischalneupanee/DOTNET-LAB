using System;

// 1. Interface
interface IAppointment
{
    void BookAppointment(string patientName);
    void CancelAppointment(string patientName);
}

// 2. Abstract Class
abstract class Hospital
{
    public string HospitalName { get; set; }

    // Constructor
    public Hospital(string hospitalName)
    {
        HospitalName = hospitalName;
    }

    // Method to be overridden
    public abstract void DisplayDetails();
}

// 3. Inheritance & Interface Implementation
class Doctor : Hospital, IAppointment
{
    public string DoctorName { get; set; }
    public string Department { get; set; }

    // Constructor calling base constructor
    public Doctor(string hospitalName, string doctorName, string department)
        : base(hospitalName)
    {
        DoctorName = doctorName;
        Department = department;
    }

    // 4. Method Overriding
    public override void DisplayDetails()
    {
        Console.WriteLine($"\n[Hospital: {HospitalName}] Dr. {DoctorName} - Department: {Department}");
    }

    // Interface methods
    public virtual void BookAppointment(string patientName)
    {
        Console.WriteLine($"Appointment booked for {patientName} with Dr. {DoctorName}.");
    }

    public virtual void CancelAppointment(string patientName)
    {
        Console.WriteLine($"Appointment cancelled for {patientName} with Dr. {DoctorName}.");
    }

    // 5. Method Overloading (CalculateBill)
    public double CalculateBill(double consultationFee)
    {
        return consultationFee;
    }

    public double CalculateBill(double consultationFee, double serviceTax)
    {
        return consultationFee + serviceTax;
    }
}

// Derived class extending Doctor
class SpecialistDoctor : Doctor
{
    public string Specialization { get; set; }

    public SpecialistDoctor(string hospitalName, string doctorName, string department, string specialization)
        : base(hospitalName, doctorName, department)
    {
        Specialization = specialization;
    }

    // Overriding DisplayDetails again
    public override void DisplayDetails()
    {
        Console.WriteLine($"\n[Hospital: {HospitalName}] Specialist Dr. {DoctorName} - Spec: {Specialization} ({Department})");
    }

    // Overloaded CalculateBill for surgery/procedure
    public double CalculateBill(double consultationFee, double treatmentFee, double tax)
    {
        return consultationFee + treatmentFee + tax;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Hospital Management System (OOP Demonstration) ===");

        Doctor doc = new Doctor("City Hospital", "Sanjiv Joshi", "General Medicine");
        SpecialistDoctor specDoc = new SpecialistDoctor("City Hospital", "Priya Sharma", "Cardiology", "Heart Surgeon");

        // Polymorphic display (Method Overriding)
        Hospital h1 = doc;
        Hospital h2 = specDoc;
        h1.DisplayDetails();
        h2.DisplayDetails();

        // Interface methods
        Console.WriteLine("\n--- Appointments ---");
        doc.BookAppointment("Ramesh Gupta");
        specDoc.BookAppointment("Sunita Shrestha");
        doc.CancelAppointment("Ramesh Gupta");

        // Method Overloading
        Console.WriteLine("\n--- Billing (Method Overloading) ---");
        Console.WriteLine($"Standard consultation: ${doc.CalculateBill(500):F2}");
        Console.WriteLine($"Consultation with tax: ${doc.CalculateBill(500, 65):F2}");
        Console.WriteLine($"Specialist treatment total: ${specDoc.CalculateBill(1000, 4500, 250):F2}");
    }
}
