using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisas2.Models
{
    public class ExchangeRates
    {
        [JsonProperty(PropertyName = "disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty(PropertyName = "license")]
        public string License { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public int TimeStamp { get; set; }

        [JsonProperty(PropertyName = "base")]
        public string Base { get; set; }

        [JsonProperty(PropertyName = "rates")]
        public Rates Rates { get; set; }

        [JsonProperty(PropertyName = "RatesName")]
        public RatesName RatesName { get; set; }

    }

    public class Rates
    {
        public double AED { get; set; }
        public double AFN { get; set; }
        public double ALL { get; set; }
        public double AMD { get; set; }
        public double ANG { get; set; }
        public double AOA { get; set; }
        public double ARS { get; set; }
        public double AUD { get; set; }
        public double AWG { get; set; }
        public double AZN { get; set; }
        public double BAM { get; set; }
        public double BBD { get; set; }
        public double BDT { get; set; }
        public double BGN { get; set; }
        public double BHD { get; set; }
        public double BIF { get; set; }
        public double BMD { get; set; }
        public double BND { get; set; }
        public double BOB { get; set; }
        public double BRL { get; set; }
        public double BSD { get; set; }
        public double BTC { get; set; }
        public double BTN { get; set; }
        public double BWP { get; set; }
        public double BYN { get; set; }
        public double BYR { get; set; }
        public double BZD { get; set; }
        public double CAD { get; set; }
        public double CDF { get; set; }
        public double CHF { get; set; }
        public double CLF { get; set; }
        public double CLP { get; set; }
        public double CNY { get; set; }
        public double COP { get; set; }
        public double CRC { get; set; }
        public double CUC { get; set; }
        public double CUP { get; set; }
        public double CVE { get; set; }
        public double CZK { get; set; }
        public double DJF { get; set; }
        public double DKK { get; set; }
        public double DOP { get; set; }
        public double DZD { get; set; }
        public double EEK { get; set; }
        public double EGP { get; set; }
        public double ERN { get; set; }
        public double ETB { get; set; }
        public double EUR { get; set; }
        public double FJD { get; set; }
        public double FKP { get; set; }
        public double GBP { get; set; }
        public double GEL { get; set; }
        public double GGP { get; set; }
        public double GHS { get; set; }
        public double GIP { get; set; }
        public double GMD { get; set; }
        public double GNF { get; set; }
        public double GTQ { get; set; }
        public double GYD { get; set; }
        public double HKD { get; set; }
        public double HNL { get; set; }
        public double HRK { get; set; }
        public double HTG { get; set; }
        public double HUF { get; set; }
        public double IDR { get; set; }
        public double ILS { get; set; }
        public double IMP { get; set; }
        public double INR { get; set; }
        public double IQD { get; set; }
        public double IRR { get; set; }
        public double ISK { get; set; }
        public double JEP { get; set; }
        public double JMD { get; set; }
        public double JOD { get; set; }
        public double JPY { get; set; }
        public double KES { get; set; }
        public double KGS { get; set; }
        public double KHR { get; set; }
        public double KMF { get; set; }
        public double KPW { get; set; }
        public double KRW { get; set; }
        public double KWD { get; set; }
        public double KYD { get; set; }
        public double KZT { get; set; }
        public double LAK { get; set; }
        public double LBP { get; set; }
        public double LKR { get; set; }
        public double LRD { get; set; }
        public double LSL { get; set; }
        public double LTL { get; set; }
        public double LVL { get; set; }
        public double LYD { get; set; }
        public double MAD { get; set; }
        public double MDL { get; set; }
        public double MGA { get; set; }
        public double MKD { get; set; }
        public double MMK { get; set; }
        public double MNT { get; set; }
        public double MOP { get; set; }
        public double MRO { get; set; }
        public double MTL { get; set; }
        public double MUR { get; set; }
        public double MVR { get; set; }
        public double MWK { get; set; }
        public double MXN { get; set; }
        public double MYR { get; set; }
        public double MZN { get; set; }
        public double NAD { get; set; }
        public double NGN { get; set; }
        public double NIO { get; set; }
        public double NOK { get; set; }
        public double NPR { get; set; }
        public double NZD { get; set; }
        public double OMR { get; set; }
        public double PAB { get; set; }
        public double PEN { get; set; }
        public double PGK { get; set; }
        public double PHP { get; set; }
        public double PKR { get; set; }
        public double PLN { get; set; }
        public double PYG { get; set; }
        public double QAR { get; set; }
        public double RON { get; set; }
        public double RSD { get; set; }
        public double RUB { get; set; }
        public double RWF { get; set; }
        public double SAR { get; set; }
        public double SBD { get; set; }
        public double SCR { get; set; }
        public double SDG { get; set; }
        public double SEK { get; set; }
        public double SGD { get; set; }
        public double SHP { get; set; }
        public double SLL { get; set; }
        public double SOS { get; set; }
        public double SRD { get; set; }
        public double STD { get; set; }
        public double SVC { get; set; }
        public double SYP { get; set; }
        public double SZL { get; set; }
        public double THB { get; set; }
        public double TJS { get; set; }
        public double TMT { get; set; }
        public double TND { get; set; }
        public double TOP { get; set; }
        public double TRY { get; set; }
        public double TTD { get; set; }
        public double TWD { get; set; }
        public double TZS { get; set; }
        public double UAH { get; set; }
        public double UGX { get; set; }
        public double USD { get; set; }
        public double UYU { get; set; }
        public double UZS { get; set; }
        public double VEF { get; set; }
        public double VND { get; set; }
        public double VUV { get; set; }
        public double WST { get; set; }
        public double XAF { get; set; }
        public double XAG { get; set; }
        public double XAU { get; set; }
        public double XCD { get; set; }
        public double XDR { get; set; }
        public double XOF { get; set; }
        public double XPD { get; set; }
        public double XPF { get; set; }
        public double XPT { get; set; }
        public double YER { get; set; }
        public double ZAR { get; set; }
        public double ZMK { get; set; }
        public double ZMW { get; set; }
        public double ZWL { get; set; }
    }

    public class RatesName
    {
        public string AED { get; set; }
        public string AFN { get; set; }
        public string ALL { get; set; }
        public string AMD { get; set; }
        public string ANG { get; set; }
        public string AOA { get; set; }
        public string ARS { get; set; }
        public string AUD { get; set; }
        public string AWG { get; set; }
        public string AZN { get; set; }
        public string BAM { get; set; }
        public string BBD { get; set; }
        public string BDT { get; set; }
        public string BGN { get; set; }
        public string BHD { get; set; }
        public string BIF { get; set; }
        public string BMD { get; set; }
        public string BND { get; set; }
        public string BOB { get; set; }
        public string BRL { get; set; }
        public string BSD { get; set; }
        public string BTC { get; set; }
        public string BTN { get; set; }
        public string BWP { get; set; }
        public string BYR { get; set; }
        public string BZD { get; set; }
        public string CAD { get; set; }
        public string CDF { get; set; }
        public string CHF { get; set; }
        public string CLF { get; set; }
        public string CLP { get; set; }
        public string CNY { get; set; }
        public string COP { get; set; }
        public string CRC { get; set; }
        public string CUC { get; set; }
        public string CUP { get; set; }
        public string CVE { get; set; }
        public string CZK { get; set; }
        public string DJF { get; set; }
        public string DKK { get; set; }
        public string DOP { get; set; }
        public string DZD { get; set; }
        public string EEK { get; set; }
        public string EGP { get; set; }
        public string ERN { get; set; }
        public string ETB { get; set; }
        public string EUR { get; set; }
        public string FJD { get; set; }
        public string FKP { get; set; }
        public string GBP { get; set; }
        public string GEL { get; set; }
        public string GGP { get; set; }
        public string GHS { get; set; }
        public string GIP { get; set; }
        public string GMD { get; set; }
        public string GNF { get; set; }
        public string GTQ { get; set; }
        public string GYD { get; set; }
        public string HKD { get; set; }
        public string HNL { get; set; }
        public string HRK { get; set; }
        public string HTG { get; set; }
        public string HUF { get; set; }
        public string IDR { get; set; }
        public string ILS { get; set; }
        public string IMP { get; set; }
        public string INR { get; set; }
        public string IQD { get; set; }
        public string IRR { get; set; }
        public string ISK { get; set; }
        public string JEP { get; set; }
        public string JMD { get; set; }
        public string JOD { get; set; }
        public string JPY { get; set; }
        public string KES { get; set; }
        public string KGS { get; set; }
        public string KHR { get; set; }
        public string KMF { get; set; }
        public string KPW { get; set; }
        public string KRW { get; set; }
        public string KWD { get; set; }
        public string KYD { get; set; }
        public string KZT { get; set; }
        public string LAK { get; set; }
        public string LBP { get; set; }
        public string LKR { get; set; }
        public string LRD { get; set; }
        public string LSL { get; set; }
        public string LTL { get; set; }
        public string LVL { get; set; }
        public string LYD { get; set; }
        public string MAD { get; set; }
        public string MDL { get; set; }
        public string MGA { get; set; }
        public string MKD { get; set; }
        public string MMK { get; set; }
        public string MNT { get; set; }
        public string MOP { get; set; }
        public string MRO { get; set; }
        public string MTL { get; set; }
        public string MUR { get; set; }
        public string MVR { get; set; }
        public string MWK { get; set; }
        public string MXN { get; set; }
        public string MYR { get; set; }
        public string MZN { get; set; }
        public string NAD { get; set; }
        public string NGN { get; set; }
        public string NIO { get; set; }
        public string NOK { get; set; }
        public string NPR { get; set; }
        public string NZD { get; set; }
        public string OMR { get; set; }
        public string PAB { get; set; }
        public string PEN { get; set; }
        public string PGK { get; set; }
        public string PHP { get; set; }
        public string PKR { get; set; }
        public string PLN { get; set; }
        public string PYG { get; set; }
        public string QAR { get; set; }
        public string RON { get; set; }
        public string RSD { get; set; }
        public string RUB { get; set; }
        public string RWF { get; set; }
        public string SAR { get; set; }
        public string SBD { get; set; }
        public string SCR { get; set; }
        public string SDG { get; set; }
        public string SEK { get; set; }
        public string SGD { get; set; }
        public string SHP { get; set; }
        public string SLL { get; set; }
        public string SOS { get; set; }
        public string SRD { get; set; }
        public string STD { get; set; }
        public string SVC { get; set; }
        public string SYP { get; set; }
        public string SZL { get; set; }
        public string THB { get; set; }
        public string TJS { get; set; }
        public string TMT { get; set; }
        public string TND { get; set; }
        public string TOP { get; set; }
        public string TRY { get; set; }
        public string TTD { get; set; }
        public string TWD { get; set; }
        public string TZS { get; set; }
        public string UAH { get; set; }
        public string UGX { get; set; }
        public string USD { get; set; }
        public string UYU { get; set; }
        public string UZS { get; set; }
        public string VEF { get; set; }
        public string VND { get; set; }
        public string VUV { get; set; }
        public string WST { get; set; }
        public string XAF { get; set; }
        public string XAG { get; set; }
        public string XAU { get; set; }
        public string XCD { get; set; }
        public string XDR { get; set; }
        public string XOF { get; set; }
        public string XPF { get; set; }
        public string YER { get; set; }
        public string ZAR { get; set; }
        public string ZMK { get; set; }
        public string ZMW { get; set; }
        public string ZWL { get; set; }
    }

    public class TaxesRate
    {
        public double TaxRate { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

    }

    public class TaxesName
    {
        public string Code { get; set; }

        public string Name { get; set; }
    }

    public class Taxes
    {
        public string Code { get; set; }
        public double TaxRate { get; set; }
        public string Name { get; set; }
    }



}
