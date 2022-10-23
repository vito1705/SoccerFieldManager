using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerFieldManager.DataAccess
{
    public static class Constants
    {
        public static readonly string DatabaseFileName = @"..\..\..\..\..\..\Database\NetBankDB.db";
        public static readonly string SelectReportedCards = "SELECT Id, FirstName, LastName, CellPhone, CellPhoneT, Email FROM Clients";
        public static readonly string SelectReportedCardByCardNumber = "SELECT Id, IssuingNetwork, CreditCardNumber, FirstName, LastName, StatusCard, ReportedDate, LastUpdatedDate FROM ReportedCards WHERE CreditCardNumber = $CreditCardNumber";
        public static readonly string UpdateReportedCards = "UPDATE ReportedCards SET StatusCard = $StatusCard  , LastUpdatedDate = $LastUpdatedDate WHERE CreditCardNumber = $CreditCardNumber";
        public static readonly string LETTERSCONTAINS = @"[A-Za-z]";
    }
}
