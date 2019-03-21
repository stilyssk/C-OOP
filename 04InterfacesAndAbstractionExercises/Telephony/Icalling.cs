namespace Telephony
{
    public interface ICalling
    {
        string PhoneNumber { get; set; }

        string Call();
    }
}
