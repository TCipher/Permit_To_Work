namespace PermitToWorkSystem.Data.IServices
{
    public interface IEncryptDecryptService
    {
        public string EncryptID(int id);
        public string DecryptID(string encryptedID);

    }
}
