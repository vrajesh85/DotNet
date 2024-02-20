using DotNetConsole.IO_Operations;
using DotNetConsole.Multithreading;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using Brotli.Bundle;
using NBomber;
using NBomber.Contracts;
using NBomber.CSharp;
using NBomber.Plugins.Http.CSharp;
using NBomber.Plugins.Network.Ping;
using NBomber.Configuration;
using Spectre.Console;
using System.Text.RegularExpressions;
using System.Reactive.Linq;
using System.Collections.Generic;
using System.Xml;
using DotNetConsole.Inheritance;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using DotNetConsole.Files;
using System.Text;
using System.Collections;
using System.Data;
//using Microsoft.Extensions.Logging;
using FileParser;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration.Attributes;
using Microsoft.Ajax.Utilities;
using CsvHelper.Configuration;
using static DotNetConsole.Pack;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Immutable;

namespace DotNetConsole
{
    internal class Program
    {
        static Thread thread1, thread2 = null;
        static void Main(string[] args)
        {


           var result = Directory.EnumerateFiles(@"C:\Learning\Azure", "terraform.docx").FirstOrDefault();
            decimal somevalue = new ClassB().Somevalue;
            decimal? decimalnullValue = somevalue;

            var fileOperations = new FileOperations();

           // fileOperations.ReadFromFileStream();
            //Random rnd = new Random();

            //Console.WriteLine("Generating 10 random numbers:");

            //for (uint ctr = 1; ctr <= 10; ctr++)
            //    Console.WriteLine($"{rnd.Next(100000000, 1000000000)}");

          //  System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

          //  watch.Start();

          //  var data = ReadCSVData("C:\\Users\\rvemula1\\Desktop\\EmisMapping-50 1.csv");

            

          //  var resultvalue = data.FirstOrDefault(x => x.Key == "LATA1620").Value ?? "RAJESH";

          //  watch.Stop();

          //  var streamReader = new StreamReader("C:\\Users\\rvemula1\\Desktop\\EmisMapping-504 1.csv");
          //  var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
          //  {
          //      HasHeaderRecord = true,
          //      HeaderValidated = null,
          //      MissingFieldFound = null,
          //      IgnoreBlankLines = true
          //  };
          //  var csvReader = new CsvReader(streamReader, configuration);
          //  // var dicresult = csvReader.GetRecords<IDictionary<string, string>>();

          //  Dictionary<string, string> dicvalue = new Dictionary<string, string>();
          //  var dicresult = csvReader.GetRecords<EmisSnomedMappingCsvHeaders>();

          //  var dicres = dicresult.ToDictionary(x => x.EmisId, y => y.SnomedId);

          //  var someresult = dicres.FirstOrDefault(x => x.Key == "LATA1620").Value ?? "LATA1620";

          //  string result = string.Empty;
          //  IEnumerable<Dictionary<string,string>> _emisMappings = GetValues();
             

          ////  var result1 = _emisMappings?.FirstOrDefault(x => x.TryGetValue("raj", out result));

          //  var objProduct = new Product();
          //  var objPacks = new List<Pack>();

          //  objProduct.Packs = objPacks;
          //  objProduct.PreferredPack = objPacks.SingleOrDefault(x => x.Id == -1);
          //  objProduct.Packs.ForEach(x => x.IsPreferredPack = x.Id == -1);


          //  var tr1 = new TextWriterTraceListener(Console.Out);
          //  Trace.Listeners.Add(tr1);
          //  Debug.AutoFlush = true;
          //  Debug.Indent();
          //  Debug.WriteLine("Entering Main");
          //  Console.WriteLine("Hello World.");
          //  Debug.WriteLine("Exiting Main");
          //  Debug.Unindent();


          //  int? a = null, b = null, c = 1;

          //  int? d = a ?? b ?? c; // null coalescing 

          //  string somevalue = d?.ToString(); // null conditional operator --> will not throw error
          //  Console.WriteLine($"the non null value is {somevalue}"); 

            
          //  dynamic strval = "Rajesh";

          //  Console.WriteLine(strval); Console.Write(strval.GetType().Name);
          //  strval = 10;

          //  Console.WriteLine(strval); Console.Write(strval.GetType().Name);

          //  ClassA objSafetyAlertDetail = new ClassA();

          // // List<SafetyAlertDetail> safetyAlertsToDisplay = Enumerable.Empty<SafetyAlertDetail>().ToList();

          ////  IEnumerable<ModuleStatuses> moduleStatuses = objSafetyAlertDetail.moduleStatuses;

          //  if (objSafetyAlertDetail.moduleStatuses.Any()) { }

          //  if(safetyAlertsToDisplay.Any()) { }
        }

        static IEnumerable<Dictionary<string,string>> GetValues() => null;

        public class EmisMappingCodesHeaders
        {
            [Name("FromId")] public string EmisCode { get; set; }
            [Name("ToId")] public string SnomedCode { get; set; }
        }
        public class ClassB
        {
            public bool IsDemographicEnabled { get; set; }
            public bool IsSafetyAlertEnabled { get; set; }
            public bool IsWithHeldEnabled { get; set; }
            public bool IsTargetedSwitchEnabled { get; set; }

            public decimal Somevalue { get; set; }
        }

        public class ClassA
        {
            public string AlertType { get; set; }
            public string AlertTitle { get; set; }
            public string RuleId { get; set; }
            public string AlertLevel { get; set; }
            public int Count { get; set; }
            public ClassB[] moduleStatuses { get; set; } = Array.Empty<ClassB>();  
        }

        static IEnumerable<string> GetElements() { return null; }

       
        static Dictionary<string,string> ReadCSVData(string filePath)
        {
            Dictionary<string, string> csvData = Enumerable.Empty<string>().ToDictionary(_ => string.Empty);
            if (File.Exists(filePath))
            {
                 
                //string line = string.Empty;
                //using (StreamReader reader = new StreamReader(filePath))
                //{
                //    while ((line = reader.ReadLine()) != null)
                //    {
                //        string[] emisCodesArray = line.Split(',');
                //        if (emisCodesArray.Length == 2 && !string.IsNullOrEmpty(emisCodesArray[0]) && !string.IsNullOrEmpty(emisCodesArray[1]))
                //            csvData.Add(emisCodesArray[0], emisCodesArray[1]);
                //    }
                //}              
            }
            return csvData;
        }
        
        static void MultipleThreads()
        {
            var objThreadingClass = new ThreadingClass();

            Thread firstThread = new Thread(objThreadingClass.FirstThread);
            Thread secThread = new Thread(objThreadingClass.SecondThread);

           
            firstThread.Start();
            
            Console.WriteLine("When First thread started it is alive -->" + firstThread.IsAlive);

            secThread.Start();
            Console.WriteLine("When First thread joined it is alive -->" + firstThread.IsAlive);

            Console.WriteLine("Is Second thread alive --> " + secThread.IsAlive);
        }

        static void JoiningThreads()
        {
            thread1 = new Thread(ThreadProcForJoining);
            thread1.Name = "Thread 1";
            thread1.Start();

            thread2 = new Thread(ThreadProcForJoining);
            thread2.Name = "Thread 2";
            thread2.Start();

            Console.WriteLine(" Thread 2 state is " + thread2.ThreadState);
        }

        static void ThreadProcForJoining()
        {
            Console.WriteLine(" Current Thread is " + Thread.CurrentThread.Name);
            if (Thread.CurrentThread.Name == "Thread 1" && thread2.ThreadState != System.Threading.ThreadState.Unstarted)
                thread2.Join();

            Thread.Sleep(4000);

            Console.WriteLine(" Current Thread is " + Thread.CurrentThread.Name);
            Console.WriteLine(" Thread 1 state " + thread1.ThreadState);
            Console.WriteLine(" Thread 2 state " + thread2.ThreadState);
        }

        static void FileOperations()
        {
            var obj = new FileOperations();

            Stopwatch sw = new Stopwatch();

            sw.Start();

            var databyteArray = obj.ReadDataIntoByteArray();

            var azureBase64 = Convert.ToBase64String(databyteArray);

            var azureBaseBytes = Convert.FromBase64String(azureBase64);

            using (var exeFile = new FileStream(@"C:\Learning\Test.exe", FileMode.Create))
            {
                exeFile.Write(azureBaseBytes, 0, azureBaseBytes.Length);
                exeFile.Flush();
            }

            sw.Stop();

            TimeSpan ts = sw.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",ts.Hours, ts.Minutes, ts.Seconds);

            Console.WriteLine("The total time is --> " + elapsedTime);
        }

        static void FileIOWebClient()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/string"); //Content-Type  
                client.Headers.Add("Accept:application/string");
                var downloadFile = Path.Combine(@"C:\Learning\Test", "OptumScriptSwitchWithByteArray.exe");
                if (Uri.TryCreate(new Uri("https://localhost:44329/"), "installer/rajesh", out var installerUri))
                {
                     var databyteArray = client.DownloadData(installerUri);

                   // var data = client.DownloadString(installerUri);
                   // var azureBaseBytes = Convert.FromBase64String(data);
                   // if (azureBaseBytes == null)
                     if (databyteArray == null)
                    {
                        return;
                    }
                    using (var exeFile = new FileStream(downloadFile, FileMode.Create))
                    {
                        //exeFile.Write(azureBaseBytes, 0, azureBaseBytes.Length);
                        exeFile.Write(databyteArray, 0, databyteArray.Length);
                        exeFile.Flush();
                    }
                    return;
                }
            }
        }

        static void FileIOHttpClient()
        {
            using (var client = new HttpClient())
            {

                var downloadFile = Path.Combine(@"C:\Learning\Test", "OptumScriptSwitch.exe");
                if (Uri.TryCreate(new Uri("https://localhost:44329/"), "installer/rajesh", out var installerUri))
                {
                    var bytearray = client.GetByteArrayAsync(installerUri.ToString());
                    if (bytearray.Result == null)
                    {
                        return;
                    }
                    //using (var exeFile = new FileStream(downloadFile, FileMode.Create))
                    //{
                    //    exeFile.Write(bytearray.Result, 0, bytearray.Result.Length);
                    //    exeFile.Flush();
                    //}

                    File.WriteAllBytes(downloadFile, bytearray.Result); // write to temp file for converting to file from byte array       

                    return;
                }
            }
        }

        static void NBomberTestGetVersion()
        {
            /* https://localhost:44329/ */
            using var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://secureq01.scriptswitch.com/scriptswitch.api/"), 
                Timeout = TimeSpan.FromMilliseconds(1750)
            };

            var step = Step.Create("fetch_version", async context =>
            {
                try
                {
                    var response = await httpClient.GetAsync("installer/ALIUNTKKHOSI/version");

                    return response.IsSuccessStatusCode
                        ? Response.Ok()
                        : Response.Fail();

                }
                catch (Exception ex)
                {
                    return Response.Fail();
                }
            });

            var scenario = ScenarioBuilder.CreateScenario("fetch_version_scenario", step)
                            .WithWarmUpDuration(TimeSpan.FromSeconds(60))
                            .WithLoadSimulations(
                             Simulation.InjectPerSec(rate: 1, during: TimeSpan.FromMinutes(10))
                                                );

            NBomberRunner
              .RegisterScenarios(scenario)
              .WithReportFileName("fetch_verison_report")
              .WithReportFolder("fetch_version_reports")
              .WithReportFormats(ReportFormat.Txt, ReportFormat.Csv, ReportFormat.Html, ReportFormat.Md)
              .Run();
        }

        static void NBomberTestCheckLicence()
        {
            using var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://secureq01.scriptswitch.com/scriptswitch.api/"),
                Timeout = TimeSpan.FromMilliseconds(1750)
            };

            var step = Step.Create("check_licence", async context =>
            {
                try
                {
                    var response = await httpClient.GetAsync("installer/12345/NVIBJTPZICQJ");

                    return response.IsSuccessStatusCode
                        ? Response.Ok()
                        : Response.Fail();

                }
                catch (Exception ex)
                {
                    return Response.Fail();
                }
            });

            var scenario = ScenarioBuilder.CreateScenario("check_licence_scenario", step)
                            .WithWarmUpDuration(TimeSpan.FromSeconds(60))
                            .WithLoadSimulations(
                             Simulation.InjectPerSec(rate: 600, during: TimeSpan.FromMinutes(1))
                                                );

            NBomberRunner
              .RegisterScenarios(scenario)
              .WithReportFileName("check_licence_report")
              .WithReportFolder("check_licence_reports")
              .WithReportFormats(ReportFormat.Txt, ReportFormat.Csv, ReportFormat.Html, ReportFormat.Md)
              .Run();
        }

        static void BasicRegularExpressions()
        {
            #region Quantifier
            // ? is called quantifier, it matches any string with it's 0 or {0,1} indexes before '?' symbol , so both colour & color are selected
            Match m1 = Regex.Match("Which colour you like color or colour", @"colou?r");
            Console.WriteLine(m1.ToString()); // Colour
            if (m1.Success)
            {
                Match m2 = m1.NextMatch();  // color
                Console.WriteLine(m2.ToString());
            }

            // Matches method returns all the matches in the array

            foreach (Match m in Regex.Matches("One color? There are two colours in my head!", @"colou?rs?"))
                Console.WriteLine(m);

            #endregion

            //#region Alternator

            //#region
        }
    }

    public class Product
    {

        public Product()
        {
            PreferredPack = new Pack();
        }

        public string Code { get; set; }
        public string Formula { get; set; }
        public string Strength { get; set; }
        public string Name { get; set; }
        public Pack PreferredPack { get; set; }
        public List<Pack> Packs { get; set; } = new List<Pack>();
        public int BnfChapter { get; set; }
        public int BnfSection { get; set; }
        public int BnfParagraph { get; set; }
        public int BnfSubParagraph { get; set; }
        public string PackSizeUnit { get; set; } // Doesn't seem to be used.  Let's remove this later.  Sean Kearon, Jan 2020.
        public string InternalCode { get; set; } // Doesn't seem to be used.  Let's remove this later.  Sean Kearon, Jan 2020.

        public int DmdVersionId { get; set; }
        public long DmdId { get; set; }

    }


    public class Pack
    {
        public double Packsize { get; set; }
        public string PackSizeUnits { get; set; }
        public double Basesize { get; set; }
        public string BaseSizeUnits { get; set; }
        public decimal Cost { get; set; }
        public bool IsPreferredPack { get; set; } // I think this can be removed and Product.PreferredPack used in its place.  Sean Kearon, Jan 2020'
        public bool IsSpecialContainer { get; set; }
        public int? PackStatusId { get; set; }
        public double? SubPackSize { get; set; }
        public int? NoOfSubPacks { get; set; }
        public string SubPackSizeUnits { get; set; }
        public bool? IsSubPackSpecialContainer { get; set; }
        public bool? IsDrugTariff { get; set; }
        public long? DrugTariffCd { get; set; }
        /// <summary> This is the pack ID in the database. </summary>
        public int PackIdentifier { get; set; }

        public bool? IsScottishDrugTariff { get; set; } // Added in ServiceBus.  Sean Kearon, Jan 2020
        public int DmdVersionId { get; set; }
        public long DmdId { get; set; }

        /// <summary>  Price is the term most often used so let's allow it to be used!  Sean Kearon Jan 2020  </summary>
        public decimal Price
        {
            get { return Cost; }
            set { Cost = value; }
        }

        /// <summary> The <see cref="PackIdentifier"/> is the database ID for the pack record. </summary>
        public int Id
        {
            get { return PackIdentifier; }
            set { PackIdentifier = value; }
        }

        public sealed class EmisSnomedMappingCsvHeaders  
        {
            [Name("FromId")]
            public string EmisId { get; set; }

            [Name("ToId")]
            public string SnomedId { get; set; }
             
        }



    }

}

