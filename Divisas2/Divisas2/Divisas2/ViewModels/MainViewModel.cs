using Divisas2.Models;
using Divisas2.Services;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Windows.Input;

namespace Divisas2.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        #region Attributes

        private ExchangeRates exchangeRatesTaxes;

        private ExchangeRates exchangeRatesNames;

        private decimal amount;

        private string sourceRateCode;

        private string targetRateCode;

        private bool isRunning;

        private bool isEnabled;

        private DataService dataService;

        private ApiService apiService;

        private string message;

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        public ICommand ChangeCommand
        {
            get { return new RelayCommand(Change); }
        }        

        public ICommand ConvertCommand { get { return new RelayCommand(ConvertMoney); } }

        public string Message
        {
            set
            {
                if (message != value)
                {
                    message = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Message"));
                }
            }
            get
            {
                return message;
            }
        }



        public ObservableCollection<Taxes> Rates { get; set; }


        public ObservableCollection<TaxesName> RatesName { get; set; }

        public decimal Amount
        {
            set
            {
                if (amount != value)
                {
                    amount = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Amount"));
                }
            }
            get
            {
                return amount;
            }
        }

        public string SourceRateCode
        {
            set
            {
                if (sourceRateCode != value)
                {
                    sourceRateCode = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SourceRateCode"));
                }
            }
            get
            {
                return sourceRateCode;
            }
        }

        public string TargetRateCode
        {
            set
            {
                if (targetRateCode != value)
                {
                    targetRateCode = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TargetRateCode"));
                }
            }
            get
            {
                return targetRateCode;
            }
        }

        public bool IsRunning
        {
            set
            {
                if (isRunning != value)
                {
                    isRunning = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning"));
                }
            }
            get
            {
                return isRunning;
            }
        }

        public bool IsEnabled
        {
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsEnabled"));
                }
            }
            get
            {
                return isEnabled;
            }
        }

        #endregion

        #region Constructors

        public MainViewModel()
        {
            apiService = new ApiService();
            dataService = new DataService();
            Message = "Ingrese la cantidad a convertir, la moneda orgien, la monda destino y presione el botón de 'Convertir'";
            Rates = new ObservableCollection<Taxes>();
            RatesName = new ObservableCollection<TaxesName>();
            IsEnabled = false;
            GetRates();
        }

        #endregion

        #region Methods

        private void Change()
        {
            var aux = SourceRateCode;
            SourceRateCode = TargetRateCode;
            TargetRateCode = aux;
        }

        private void LoadRates()
        {
            List<TaxesName> lista = new List<TaxesName>();
            var type = typeof(RatesName);
            var properties = type.GetRuntimeFields();
            foreach (var property in properties)
            {
                var code = property.Name.Substring(1, 3);
                lista.Add( new TaxesName
                {
                    Code = code,
                    Name = (string)property.GetValue(exchangeRatesNames.RatesName),
                });
            }

            Rates.Clear();
            type = typeof(Rates);
            properties = type.GetRuntimeFields();
            var cont = 0;

            foreach (var property in properties)
            {
                cont = cont + 1;
                var code = property.Name.Substring(1, 3);
                var name = code;

                foreach (var property2 in lista)
                {
                    if (property2.Code == code)
                    {
                        name = string.Format("({0}) {1}", code, property2.Name);
                    }
                }

                var rate = (double)property.GetValue(exchangeRatesTaxes.Rates);

                Rates.Add(new Taxes
                {
                    Code = code,
                    TaxRate = rate,
                    Name = name,
                });

                dataService.InsertOrUpdate(new Taxes
                {
                    TaxesId = cont,
                    Code = code,
                    TaxRate = rate,
                    Name = name,
                });
            }
        }

        private async void GetRates()
        {
            try
            {
                var checkConnetion = await apiService.CheckConnection();
                if (!checkConnetion.IsSuccess)
                {
                    IsRunning = true;
                    IsEnabled = false;

                    Rates.Clear();
                    var rates = dataService.Get<Taxes>(true);
                    foreach (var property in rates)
                    {
                        Rates.Add(new Taxes
                        {
                            Code = property.Code,
                            TaxRate = property.TaxRate,
                            Name = property.Name,
                        });
                    }

                    IsRunning = false;
                    IsEnabled = true;

                    return;
                }

                IsRunning = true;
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://openexchangerates.org");
                var url = "/api/latest.json?app_id=f490efbcd52d48ee98fd62cf33c47b9e";
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    await App.Current.MainPage.DisplayAlert("Error", response.StatusCode.ToString(), "Aceptar");
                    IsRunning = false;
                    IsEnabled = false;
                    return;
                }

                var result = await response.Content.ReadAsStringAsync();
                exchangeRatesTaxes = JsonConvert.DeserializeObject<ExchangeRates>(result);

                client.BaseAddress = new Uri("https://gist.githubusercontent.com");
                url = "/picodotdev/88512f73b61bc11a2da4/raw/9407514be22a2f1d569e75d6b5a58bd5f0ebbad8";
                response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    await App.Current.MainPage.DisplayAlert("Error", response.StatusCode.ToString(), "Aceptar");
                    IsRunning = false;
                    IsEnabled = false;
                    return;
                }
                result = string.Format("{{{1}RatesName{1}: {0}}}", await response.Content.ReadAsStringAsync(), "\"");
                exchangeRatesNames = JsonConvert.DeserializeObject<ExchangeRates>(result);
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Aceptar");
                IsRunning = false;
                IsEnabled = false;
                return;
            }

            LoadRates();
            IsRunning = false;
            IsEnabled = true;
        }

        #endregion

        #region Commands
        

        private async void ConvertMoney()
        {
            

            if (Amount <= 0)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debes ingresar un valor a convertir", "Aceptar");
                return;
            }   

            if (string.IsNullOrEmpty(SourceRateCode))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debes seleccionar la moneda origen", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(TargetRateCode))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debes seleccionar la moneda destino", "Aceptar");
                return;
            }

            var sourceRate = 0.0;
            var targetRate = 0.0;

            foreach (var property in Rates)
            {
                if (property.Code == sourceRateCode)
                {
                    sourceRate = property.TaxRate;
                }

                if(property.Code == targetRateCode)
                {
                    targetRate = property.TaxRate;
                }
            }                     

            decimal amountConverted = amount / (decimal)sourceRate * (decimal)targetRate;

            Message = string.Format("{0:N2} = {1:N2}", amount, amountConverted);
        }
        #endregion

    }

}

