using SQLite;
using System.ComponentModel;

namespace WaterBillingMobileAppAPi.Models
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string? CUSTNAME { get; set; }

        public string? CUSTCLAS { get; set; }

        public string? CPRCSTNM { get; set; }

        public string? CNTCPRSN { get; set; }

        public string? STMTNAME { get; set; }

        public string? SHRTNAME { get; set; }

        public string? ADRSCODE { get; set; }

        public string? UPSZONE { get; set; }

        public string? SHIPMTHD { get; set; }

        public string? TAXSCHID { get; set; }

        public string? ADDRESS1 { get; set; }

        public string? ADDRESS2 { get; set; }

        public string? ADDRESS3 { get; set; }

        public string? COUNTRY { get; set; }

        public string? CITY { get; set; }

        public string? STATE { get; set; }

        public string? ZIP { get; set; }

        public string? PHONE1 { get; set; }

        public string? PHONE2 { get; set; }

        public string? PHONE3 { get; set; }

        public string? FAX { get; set; }

        public string? PRBTADCD { get; set; }

        public string? PRSTADCD { get; set; }

        public string? STADDRCD { get; set; }

        public string? SLPRSNID { get; set; }

        public string? CHEKBKID { get; set; }

        public string? PYMTRMID { get; set; }

        public int CRLMTTYP { get; set; }

        public double CRLMTAMT { get; set; }

        public int CRLMTPER { get; set; }

        public double CRLMTPAM { get; set; }

        public string? CURNCYID { get; set; }

        public string? RATETPID { get; set; }

        public int CUSTDISC { get; set; }

        public string? PRCLEVEL { get; set; }

        public int MINPYTYP { get; set; }

        public double MINPYDLR { get; set; }

        public int MINPYPCT { get; set; }

        public int FNCHATYP { get; set; }

        public int FNCHPCNT { get; set; }

        public double FINCHDLR { get; set; }

        public int MXWOFTYP { get; set; }

        public double MXWROFAM { get; set; }

        public string? COMMENT1 { get; set; }

        public string? COMMENT2 { get; set; }

        public string? USERDEF1 { get; set; }

        public string? USERDEF2 { get; set; }

        public string? TAXEXMT1 { get; set; }

        public string? TAXEXMT2 { get; set; }

        public string? TXRGNNUM { get; set; }

        public int BALNCTYP { get; set; }

        public int STMTCYCL { get; set; }

        public string? BANKNAME { get; set; }

        public string? BNKBRNCH { get; set; }

        public string? SALSTERR { get; set; }
        public int DEFCACTY { get; set; }

        public int RMCSHACC { get; set; }

        public int RMARACC { get; set; }

        public int RMSLSACC { get; set; }

        public int RMIVACC { get; set; }

        public int RMCOSACC { get; set; }

        public int RMTAKACC { get; set; }

        public int RMAVACC { get; set; }

        public int RMFCGACC { get; set; }

        public int RMWRACC { get; set; }

        public int RMSORACC { get; set; }

        public DateTime FRSTINDT { get; set; }

        public int INACTIVE { get; set; }

        public int HOLD { get; set; }

        public string? CRCARDID { get; set; }

        public string? CRCRDNUM { get; set; }

        public DateTime CCRDXPDT { get; set; }

        public int KPDSTHST { get; set; }

        public int KPCALHST { get; set; }

        public int KPERHIST { get; set; }

        public int KPTRXHST { get; set; }

        public double NOTEINDX { get; set; }

        public DateTime CREATDDT { get; set; }

        public DateTime MODIFDT { get; set; }

        public int Revalue_Customer { get; set; }

        public int Post_Results_To { get; set; }

        public string? FINCHID { get; set; }

        public string? GOVCRPID { get; set; }

        public string? GOVINDID { get; set; }

        public int DISGRPER { get; set; }

        public int DUEGRPER { get; set; }

        public string? DOCFMTID { get; set; }

        public int Send_Email_Statements { get; set; }

        public int USERLANG { get; set; }

        public string? GPSFOINTEGRATIONID { get; set; }

        public int INTEGRATIONSOURCE { get; set; }

        public string? INTEGRATIONID { get; set; }

        public int ORDERFULFILLDEFAULT { get; set; }

        public int CUSTPRIORITY { get; set; }

        public string? CCode { get; set; }

        public string? DECLID { get; set; }

        public int RMOvrpymtWrtoffAcctIdx { get; set; }

        public int SHIPCOMPLETE { get; set; }

        public int CBVAT { get; set; }

        public int INCLUDEINDP { get; set; }

        public DateTime DEX_ROW_TS { get; set; }

        public int DEX_ROW_ID { get; set; }

        public double GEO_LATITUTE { get; set; }

        public double GEO_LONGITUDE { get; set; }
    }
}
