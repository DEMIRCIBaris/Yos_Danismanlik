namespace MyProject.Bussiness.Abstract
{
    public interface IMailService
    {
        public void SendMail(string ToMailAddress, string mailBody,string subject);
        
    }
}
