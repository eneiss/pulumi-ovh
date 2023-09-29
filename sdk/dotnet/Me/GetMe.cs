// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Ovh.Me
{
    public static class GetMe
    {
        /// <summary>
        /// Use this data source to get information about the current OVHcloud account.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Ovh = Pulumi.Ovh;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var myaccount = Ovh.Me.GetMe.Invoke();
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetMeResult> InvokeAsync(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetMeResult>("ovh:Me/getMe:getMe", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// Use this data source to get information about the current OVHcloud account.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Ovh = Pulumi.Ovh;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var myaccount = Ovh.Me.GetMe.Invoke();
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetMeResult> Invoke(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetMeResult>("ovh:Me/getMe:getMe", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetMeResult
    {
        /// <summary>
        /// The resource URN of the account, to be used when writing IAM policies
        /// </summary>
        public readonly string AccountURN;
        /// <summary>
        /// Postal address of the account
        /// </summary>
        public readonly string Address;
        /// <summary>
        /// Area of the account
        /// </summary>
        public readonly string Area;
        /// <summary>
        /// City of birth
        /// </summary>
        public readonly string BirthCity;
        /// <summary>
        /// Birth date
        /// </summary>
        public readonly string BirthDay;
        /// <summary>
        /// City of the account
        /// </summary>
        public readonly string City;
        /// <summary>
        /// This is the national identification number of the company that possess this account
        /// </summary>
        public readonly string CompanyNationalIdentificationNumber;
        /// <summary>
        /// Type of corporation
        /// </summary>
        public readonly string CorporationType;
        /// <summary>
        /// Country of the account
        /// </summary>
        public readonly string Country;
        public readonly ImmutableArray<Outputs.GetMeCurrencyResult> Currencies;
        /// <summary>
        /// The customer code of this account (a numerical value used for identification when contacting support via phone call)
        /// </summary>
        public readonly string CustomerCode;
        /// <summary>
        /// Email address
        /// </summary>
        public readonly string Email;
        /// <summary>
        /// Fax number
        /// </summary>
        public readonly string Fax;
        /// <summary>
        /// First name
        /// </summary>
        public readonly string Firstname;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Italian SDI
        /// </summary>
        public readonly string ItalianSdi;
        /// <summary>
        /// Preferred language for this account
        /// </summary>
        public readonly string Language;
        /// <summary>
        /// Legal form of the account
        /// </summary>
        public readonly string Legalform;
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// National Identification Number of this account
        /// </summary>
        public readonly string NationalIdentificationNumber;
        /// <summary>
        /// Nic handle / customer identifier
        /// </summary>
        public readonly string Nichandle;
        /// <summary>
        /// Name of the organisation for this account
        /// </summary>
        public readonly string Organisation;
        /// <summary>
        /// OVHcloud subsidiary
        /// </summary>
        public readonly string OvhCompany;
        /// <summary>
        /// OVHcloud subsidiary
        /// </summary>
        public readonly string OvhSubsidiary;
        /// <summary>
        /// Phone number
        /// </summary>
        public readonly string Phone;
        /// <summary>
        /// Country code of the phone number
        /// </summary>
        public readonly string PhoneCountry;
        /// <summary>
        /// Gender of the account holder
        /// </summary>
        public readonly string Sex;
        /// <summary>
        /// Backup email address
        /// </summary>
        public readonly string SpareEmail;
        /// <summary>
        /// State of the postal address
        /// </summary>
        public readonly string State;
        /// <summary>
        /// VAT number
        /// </summary>
        public readonly string Vat;
        /// <summary>
        /// Zipcode of the address
        /// </summary>
        public readonly string Zip;

        [OutputConstructor]
        private GetMeResult(
            string AccountURN,

            string address,

            string area,

            string birthCity,

            string birthDay,

            string city,

            string companyNationalIdentificationNumber,

            string corporationType,

            string country,

            ImmutableArray<Outputs.GetMeCurrencyResult> currencies,

            string customerCode,

            string email,

            string fax,

            string firstname,

            string id,

            string italianSdi,

            string language,

            string legalform,

            string name,

            string nationalIdentificationNumber,

            string nichandle,

            string organisation,

            string ovhCompany,

            string ovhSubsidiary,

            string phone,

            string phoneCountry,

            string sex,

            string spareEmail,

            string state,

            string vat,

            string zip)
        {
            this.AccountURN = AccountURN;
            Address = address;
            Area = area;
            BirthCity = birthCity;
            BirthDay = birthDay;
            City = city;
            CompanyNationalIdentificationNumber = companyNationalIdentificationNumber;
            CorporationType = corporationType;
            Country = country;
            Currencies = currencies;
            CustomerCode = customerCode;
            Email = email;
            Fax = fax;
            Firstname = firstname;
            Id = id;
            ItalianSdi = italianSdi;
            Language = language;
            Legalform = legalform;
            Name = name;
            NationalIdentificationNumber = nationalIdentificationNumber;
            Nichandle = nichandle;
            Organisation = organisation;
            OvhCompany = ovhCompany;
            OvhSubsidiary = ovhSubsidiary;
            Phone = phone;
            PhoneCountry = phoneCountry;
            Sex = sex;
            SpareEmail = spareEmail;
            State = state;
            Vat = vat;
            Zip = zip;
        }
    }
}
