namespace SingleResponsabilityPrinciple.ImplementedPrincipleExemple
{
    class SendEmail
    {
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }

        public void Send()
        {
            //send email
        }
    }
}
