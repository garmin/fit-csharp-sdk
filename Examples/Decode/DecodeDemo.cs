/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using Dynastream.Fit;

namespace DecodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIT Decode Example Application - Protocol {0}.{0} Profile {0}.{0}", Fit.ProtocolMajorVersion.ToString(), Fit.ProtocolMinorVersion.ToString(), Fit.ProfileMajorVersion.ToString(), Fit.ProfileMinorVersion.ToString());

            if (args.Length != 1)
            {
                Console.WriteLine("Usage: decode.exe <filename>");
                return;
            }

            FileStream fitSource = null;
            try
            {
                // Attempt to open .FIT file
                fitSource = new FileStream(args[0], FileMode.Open);
                Console.WriteLine("Opening {0}", args[0]);

                Decode decodeDemo = new Decode();

                // Use a FitListener to capture all decoded messages in a FitMessages object
                FitListener fitListener = new FitListener();
                decodeDemo.MesgEvent += fitListener.OnMesg;

                // Use a custom event handlers to process messages as they are being decoded, and to
                // capture message definitions and developer field definitions
                decodeDemo.MesgEvent += OnMesgCustom;
                decodeDemo.MesgDefinitionEvent += OnMesgDefinitionCustom;
                decodeDemo.DeveloperFieldDescriptionEvent += OnDeveloperFieldDescriptionCustom;

                // Use a MesgBroadcaster for easy integration with existing projects
                //MesgBroadcaster mesgBroadcaster = new MesgBroadcaster();
                //mesgBroadcaster.MesgEvent += OnMesgCustom;
                //mesgBroadcaster.MesgDefinitionEvent += OnMesgDefinitionCustom;
                //decodeDemo.MesgEvent += mesgBroadcaster.OnMesg;
                //decodeDemo.MesgDefinitionEvent += mesgBroadcaster.OnMesgDefinition;

                Console.WriteLine("Decoding...");
                decodeDemo.Read(fitSource);

                FitMessages fitMessages = fitListener.FitMessages;

                foreach (FileIdMesg mesg in fitMessages.FileIdMesgs)
                {
                    PrintFileIdMesg(mesg);
                }
                foreach (UserProfileMesg mesg in fitMessages.UserProfileMesgs)
                {
                    PrintUserProfileMesg(mesg);
                }
                foreach (DeviceInfoMesg mesg in fitMessages.DeviceInfoMesgs)
                {
                    PrintDeviceInfoMesg(mesg);
                }
                foreach (MonitoringMesg mesg in fitMessages.MonitoringMesgs)
                {
                    PrintMonitoringMesg(mesg);
                }
                foreach (RecordMesg mesg in fitMessages.RecordMesgs)
                {
                    PrintRecordMesg(mesg);
                }
                Console.WriteLine("Decoded FIT file {0}", args[0]);

                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
            catch (FitException ex)
            {
                Console.WriteLine("A FitException occurred when trying to decode the FIT file. Message: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred when trying to decode the FIT file. Message: " + ex.Message);
            }
            finally
            {
                fitSource?.Close();
            }
        }

        static void OnMesgDefinitionCustom(object sender, MesgDefinitionEventArgs e)
        {
            Console.WriteLine("OnMesgDef: Received Defn for local message #{0}, global num {1}", e.mesgDef.LocalMesgNum, e.mesgDef.GlobalMesgNum);
            Console.WriteLine("\tIt has {0} fields {1} developer fields and is {2} bytes long",
                e.mesgDef.NumFields,
                e.mesgDef.NumDevFields,
                e.mesgDef.GetMesgSize());
        }

        static void OnMesgCustom(object sender, MesgEventArgs e)
        {
            // TODO - Implement a custom Mesg handler for use with a decoder
            //switch (e.mesg.Num)
            //{
            //    case MesgNum.FileId:
            //        break;
            //    default:
            //        break;
            //}
        }

        private static void OnDeveloperFieldDescriptionCustom(object sender, DeveloperFieldDescriptionEventArgs args)
        {
            Console.WriteLine("New Developer Field Description");
            Console.WriteLine("   App Id: {0}", args.Description.ApplicationId);
            Console.WriteLine("   App Version: {0}", args.Description.ApplicationVersion);
            Console.WriteLine("   Field Number: {0}", args.Description.FieldDefinitionNumber);
        }

        public static void PrintFileIdMesg(FileIdMesg mesg)
        {
            Console.WriteLine("File ID:");

            if (mesg.GetType() != null)
            {
                Console.Write("   Type: ");
                Console.WriteLine(mesg.GetType().Value);
            }

            if (mesg.GetManufacturer() != null)
            {
                Console.Write("   Manufacturer: ");
                Console.WriteLine(mesg.GetManufacturer());
            }

            if (mesg.GetProduct() != null)
            {
                Console.Write("   Product: ");
                Console.WriteLine(mesg.GetProduct());
            }

            if (mesg.GetSerialNumber() != null)
            {
                Console.Write("   Serial Number: ");
                Console.WriteLine(mesg.GetSerialNumber());
            }

            if (mesg.GetNumber() != null)
            {
                Console.Write("   Number: ");
                Console.WriteLine(mesg.GetNumber());
            }
        }

        public static void PrintUserProfileMesg(UserProfileMesg mesg)
        {
            Console.WriteLine("User profile:");

            if (mesg.GetFriendlyNameAsString() != null)
            {
                Console.WriteLine("\tFriendlyName: \"{0}\"", mesg.GetFriendlyNameAsString());
            }

            if (mesg.GetGender() != null)
            {
                Console.WriteLine("\tGender: {0}", mesg.GetGender().ToString());
            }

            if (mesg.GetAge() != null)
            {
                Console.WriteLine("\tAge: {0}", mesg.GetAge());

            }

            if (mesg.GetWeight() != null)
            {
                Console.WriteLine("\tWeight:  {0}", mesg.GetWeight());

            }
        }

        public static void PrintDeviceInfoMesg(DeviceInfoMesg mesg)
        {
            Console.WriteLine("Device info:");
            if (mesg.GetTimestamp() != null)
            {
                Console.WriteLine("\tTimestamp: {0}", mesg.GetTimestamp().ToString());
            }

            if (mesg.GetBatteryStatus() != null)
            {
                Console.Write("\tBattery Status: ");

                switch (mesg.GetBatteryStatus())
                {
                    case BatteryStatus.Critical:
                        Console.WriteLine("Critical");
                        break;
                    case BatteryStatus.Good:
                        Console.WriteLine("Good");
                        break;
                    case BatteryStatus.Low:
                        Console.WriteLine("Low");
                        break;
                    case BatteryStatus.New:
                        Console.WriteLine("New");
                        break;
                    case BatteryStatus.Ok:
                        Console.WriteLine("OK");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }

        public static void PrintMonitoringMesg(MonitoringMesg mesg)
        {
            Console.WriteLine("Monitoring:");
            if (mesg.GetTimestamp() != null)
            {
                Console.WriteLine("\tTimestamp: {0}", mesg.GetTimestamp().ToString());
            }

            if (mesg.GetActivityType() != null)
            {
                Console.WriteLine("\tActivityType: {0}", mesg.GetActivityType());
                switch (mesg.GetActivityType()) // Cycles is a dynamic field
                {
                    case ActivityType.Walking:
                    case ActivityType.Running:
                        Console.WriteLine("\tSteps: {0}", mesg.GetSteps());
                        break;
                    case ActivityType.Cycling:
                    case ActivityType.Swimming:
                        Console.WriteLine("\tStrokes: {0}", mesg.GetStrokes());
                        break;
                    default:
                        Console.WriteLine("\tCycles: {0}", mesg.GetCycles());
                        break;
                }
            }
        }

        public static void PrintRecordMesg(RecordMesg mesg)
        {
            Console.WriteLine("Record:");

            PrintFieldWithOverrides(mesg, RecordMesg.FieldDefNum.HeartRate);
            PrintFieldWithOverrides(mesg, RecordMesg.FieldDefNum.Cadence);
            PrintFieldWithOverrides(mesg, RecordMesg.FieldDefNum.Speed);
            PrintFieldWithOverrides(mesg, RecordMesg.FieldDefNum.Distance);
            PrintFieldWithOverrides(mesg, RecordMesg.FieldDefNum.EnhancedAltitude);

            PrintDeveloperFields(mesg);
        }

        private static void PrintDeveloperFields(Mesg mesg)
        {
            foreach (var devField in mesg.DeveloperFields)
            {
                if (devField.GetNumValues() <= 0)
                {
                    continue;
                }

                if (devField.IsDefined)
                {
                    Console.Write("\t{0}", devField.Name);

                    if (devField.Units != null)
                    {
                        Console.Write(" [{0}]", devField.Units);
                    }
                    Console.Write(": ");
                }
                else
                {
                    Console.Write("\tUndefined Field: ");
                }

                Console.Write("{0}", devField.GetValue(0));
                for (int i = 1; i < devField.GetNumValues(); i++)
                {
                    Console.Write(",{0}", devField.GetValue(i));
                }

                Console.WriteLine();
            }
        }

        private static void PrintFieldWithOverrides(Mesg mesg, byte fieldNumber)
        {
            Field profileField = Profile.GetField(mesg.Num, fieldNumber);
            bool nameWritten = false;

            if (null == profileField)
            {
                return;
            }

            IEnumerable<FieldBase> fields = mesg.GetOverrideField(fieldNumber);

            foreach (FieldBase field in fields)
            {
                if (!nameWritten)
                {
                    Console.WriteLine("   {0}", profileField.GetName());
                    nameWritten = true;
                }

                if (field is Field)
                {
                    Console.WriteLine("      native: {0}", field.GetValue());
                }
                else
                {
                    Console.WriteLine("      override: {0}", field.GetValue());
                }
            }
        }
    }
}
