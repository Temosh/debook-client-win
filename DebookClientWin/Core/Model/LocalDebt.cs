using System.Runtime.Serialization;

namespace DebookClientWin.Core.Model
{
    [DataContract]
    public class LocalDebt
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int CurrencyId { get; set; }

        [DataMember]
        public int LocalUserId { get; set; }

        [DataMember]
        public decimal Value { get; set; }

        public override string ToString()
        {
            return $"UserId: {UserId}, CurrencyId: {CurrencyId}, LocalUserId: {LocalUserId}, Value: {Value}";
        }
    }
}
