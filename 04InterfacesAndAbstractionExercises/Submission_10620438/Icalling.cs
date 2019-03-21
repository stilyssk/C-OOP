namespace Telephony
{
    public interface Icalling
    {
        string PhoneNumber { get; set; }

        string Call();
    }
}
