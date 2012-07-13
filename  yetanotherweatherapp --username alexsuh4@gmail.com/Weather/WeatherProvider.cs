using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Weather
{
    public class WeatherProvider
    {
        public string WeatherUrl = "http://www.ims.gov.il/ims/PublicXML/isr_cities.xml";
        public string WeatherOfflineFile = "isr_cities.xml";
        public int PollFrequencyHours = 3;
        public string WeatherXmlEncoding = "ISO-8859-8";

        XmlDocument currentDoc;
        public XmlDocument Retrieve()
        {
            WeatherUrl = Settings1.Default.WeatherUrl;
            WeatherOfflineFile = Settings1.Default.WeatherOfflineFile;
            PollFrequencyHours = Settings1.Default.PollFrequencyHours;
            WeatherXmlEncoding = Settings1.Default.WeatherXmlEncoding;


            string WeatherDefinition = "";
            if (


                !File.Exists(WeatherOfflineFile) || 
                
                DateTime.Now.Subtract(File.GetCreationTime(WeatherOfflineFile)).TotalHours>PollFrequencyHours
                
                )
                WeatherDefinition = Utils.GetFromWeb(WeatherUrl, WeatherOfflineFile);
            else
                WeatherDefinition = File.ReadAllText(WeatherOfflineFile, Encoding.GetEncoding(WeatherXmlEncoding));
            
            
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(WeatherDefinition);
            currentDoc = doc;
            return doc;
        }

        
        public WeatherInfo weatherInfo { get; set; }
        public void Parse()
        {
            weatherInfo = new WeatherInfo(currentDoc);

        }
    }
    public class WeatherInfo
    {
        public InedtificationInfo Inedtification { get; set; }
        public OriginatorInfo Originator { get; set; }
        public List<LocationInfo> Locations = new List<LocationInfo>();
        Dictionary<string, LocationInfo> locationNameToLocationInfoMapping;
        public Dictionary<string, LocationInfo> LocationNameToLocationInfoMapping
        {
            get
            {
                return locationNameToLocationInfoMapping;
            }
        }
        public WeatherInfo(XmlDocument doc)
        {
            Originator = new OriginatorInfo(doc.SelectSingleNode("//Originator"));
            Inedtification = new InedtificationInfo(doc.SelectSingleNode("//Identification"));
            locationNameToLocationInfoMapping = new Dictionary<string, LocationInfo>();
            XmlNodeList nodes = doc.SelectNodes("//Location");
            foreach (XmlNode someNode in nodes)
            {
                LocationInfo info = new LocationInfo(someNode);
                Locations.Add(info);

                if (!locationNameToLocationInfoMapping.ContainsKey(info.metaData.LocationNameHeb))
                    locationNameToLocationInfoMapping.Add(info.metaData.LocationNameHeb, info);
               
                
            }
           
        }
    }
    public class InedtificationInfo
    {
        public string Title { get; set; }
        public string IssueDateTime { get; set; }
        public InedtificationInfo(XmlNode node)
        {
            Title = node.SelectSingleNode("Title").InnerText;
            IssueDateTime = node.SelectSingleNode("IssueDateTime").InnerText;
        }
    }
    public class OriginatorInfo
    {
        public string Organization { get; set; }
        public string Generator { get; set; }
        public OriginatorInfo(XmlNode node)
        {
            Organization = node.SelectSingleNode("Organization").InnerText;
            Generator = node.SelectSingleNode("Generator").InnerText;
        }
    }

    public class LocationMetaData
    {
        public string LocationId { get; set; }
        public string LocationNameEng   { get; set; }
        public string LocationNameHeb { get; set; }
        public string DisplayLat { get; set; }
        public string DisplayLon { get; set; }
        public string RemarksEng { get; set; }
        public string RemarksHeb { get; set; }
        public string Remarks { get; set; }

        public LocationMetaData(XmlNode node)
        {
            LocationId = node.SelectSingleNode("LocationId").InnerText;
            LocationNameEng = node.SelectSingleNode("LocationNameEng").InnerText;
            LocationNameHeb = node.SelectSingleNode("LocationNameHeb").InnerText;
            DisplayLat = node.SelectSingleNode("DisplayLat").InnerText;
            DisplayLon = node.SelectSingleNode("DisplayLon").InnerText;
            RemarksEng = node.SelectSingleNode("RemarksEng").InnerText;
            RemarksHeb = node.SelectSingleNode("RemarksHeb").InnerText;
            Remarks = node.SelectSingleNode("Remarks").InnerText;
        }
    }
    public class LocationInfo
    {
        public List<TimeUnitData> LocationData = new List<TimeUnitData>();
        public LocationMetaData metaData { get; set; }

        public LocationInfo(XmlNode node)
        {
            metaData = new LocationMetaData(node.SelectSingleNode("LocationMetaData"));
            XmlNodeList nodes=node.SelectNodes("LocationData");
            foreach(XmlNode someOnde in nodes)
            {
                LocationData.Add(new TimeUnitData(someOnde));
            }
        }
    }
    public class TimeUnitData
    {
        DateTime Date { get; set; }
        public Dictionary<string, string> Elements { get; set; }

        public TimeUnitData(XmlNode element)
        {
            Date = Convert.ToDateTime(element.SelectSingleNode("TimeUnitData/Date").InnerText);
            XmlNodeList nodes = element.SelectNodes("TimeUnitData/Element");
            Elements = new Dictionary<string, string>();
            foreach(XmlNode node in nodes)
            {
                string key;
                string value;
                key = node.SelectSingleNode("ElementName").InnerText;
                value = node.SelectSingleNode("ElementValue").InnerText;
                if (!Elements.ContainsKey(key))
                    Elements.Add(key, value);
            }

        }
    }


    public class WeatherBindingSource
    {
        public string MaximumRelativeHumidity { get; set; }
        public string MaximumTemperature { get; set; }
        public string MinimumRelativeHumidity { get; set; }
        public string MinimumTemperature { get; set; }
        public string WeatherCode { get; set; }
        public string WindDirection { get; set; }
        public string WindSpeed { get; set; }
        public float WindSpeedAvg { get; set; }
        public float WindSpeedMax { get; set; }
        public float WindSpeedMin { get; set; }
        public WeatherBindingSource()
        {

        }
        public WeatherBindingSource(TimeUnitData createFrom)
        {
            try
            {
                MaximumRelativeHumidity = createFrom.Elements["Maximum relative humidity"];
                MaximumTemperature = createFrom.Elements["Maximum temperature"];
                MinimumRelativeHumidity = createFrom.Elements["Minimum relative humidity"];
                MinimumTemperature = createFrom.Elements["Minimum temperature"];
                WeatherCode = createFrom.Elements["Weather code"];
                string[] dirAndSpeed = createFrom.Elements["Wind direction and speed"].Split('/');
                WindDirection = dirAndSpeed[0];
                WindSpeed = dirAndSpeed[1];
                string []WindSpeeds = WindSpeed.Split('-');
                WindSpeedMin = float.Parse(WindSpeeds[0]);
                WindSpeedMax = float.Parse(WindSpeeds[1]);
                WindSpeedAvg = (WindSpeedMax + WindSpeedMin) / 2;
            }
            catch (Exception) { }

        }
    }
    public class WeatherLocationsBindingSource
    {
        List<string> locations = new List<string>();
        public List<string> Locations { get { return locations; } }
        public WeatherLocationsBindingSource()
        {
        }
        public WeatherLocationsBindingSource(WeatherInfo info)
        {
            locations = info.LocationNameToLocationInfoMapping.Keys.ToList();
        }

    }
}
