var medicalAppointment = new MedicalAppointment(" Natalia Kowalska", new DateTime(2023, 8, 22, 16, 30, 00));
var medicalAppointment2 = new MedicalAppointment("Kamil Kowalski");

Console.WriteLine(medicalAppointment2.ShowDate());
Console.WriteLine(medicalAppointment.ShowDate());

medicalAppointment.OverwriteDateAndTime(2023, 9, 20, 17, 30, 00);
Console.WriteLine(medicalAppointment.ShowDate());

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;


    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }
    public MedicalAppointment(string patientName) :
        this(patientName, 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(7);

    }

    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);

    }

    public DateTime ShowDate()
    {
        return _date;

    }

    public void OverwriteDateAndTime(int year, int month, int day, int hour, int min, int sec)
    {
        _date = new DateTime(year, month, day, hour, min, sec);
    }
    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
    }
}

