namespace OVB.Services.CrossCutting.DesignPatterns.Abstractions.Cryptography;

public interface ICryptographyService
{
    public string CreateEncryptedInformation(string information);
    public bool VerifyEncryptedInformationAccordingTo(string encryptedInformation, string information);
}
