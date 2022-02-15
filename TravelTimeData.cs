using System;
using System.Text.Json.Serialization;

public class TravelTimeData
{
    public string startAddress { get; set; }
    public string endAdress { get; set; }
    public int? duration { get; set; }
    public DateTime date { get; set; }

    public TravelTimeData(string p1, string p2, int? duration)
    {

        this.startAddress = p1;
        this.endAdress = p2;
        this.duration = duration;
        this.date = DateTime.Now;
    }


}