using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace RoadTime
{
    static class GoogleMapsDirectionApi
    {
        private const string url = "https://maps.googleapis.com/maps/api/directions/json?";
        private const string key = "AIzaSyBLc2EiY4VMw3wtLFvPsI49pLq9z7uquYA";

        private static string? ApiResponse(string start, string end)
        {
            string request = url + "origin=" + start +
                "&destination=" + end +
                "&key=" + key;
            string response = Request(request);
            return response;
        }

        public static int? GetRoadDuration(string start, string end)
        {
            var response = ApiResponse(start, end);
            int? duration = JsonConvert.DeserializeObject<Root>(response)?.Routes.FirstOrDefault()?.Legs?.FirstOrDefault()?.Duration?.Value;
            return duration;
        }


        private static string Request(string request)
        {
            HttpClient client = new();
            var response = client.GetStringAsync(request).Result;
            return response;
        }


        #region Классы для сериализации и десериализации ответа Direction Api
        private class GeocodedWaypoint
        {
            [JsonPropertyName("geocoder_status")]
            public string? GeocoderStatus;

            [JsonPropertyName("place_id")]
            public string? PlaceId;

            [JsonPropertyName("types")]
            public List<string>? Types;
        }

        private class Northeast
        {
            [JsonPropertyName("lat")]
            public double? Lat;

            [JsonPropertyName("lng")]
            public double? Lng;
        }

        private class Southwest
        {
            [JsonPropertyName("lat")]
            public double? Lat;

            [JsonPropertyName("lng")]
            public double? Lng;
        }

        private class Bounds
        {
            [JsonPropertyName("northeast")]
            public Northeast? Northeast;

            [JsonPropertyName("southwest")]
            public Southwest? Southwest;
        }

        private class Distance
        {
            [JsonPropertyName("text")]
            public string? Text;

            [JsonPropertyName("value")]
            public int? Value;
        }

        private class Duration
        {
            [JsonPropertyName("text")]
            public string? Text;

            [JsonPropertyName("value")]
            public int? Value;
        }

        private class EndLocation
        {
            [JsonPropertyName("lat")]
            public double? Lat;

            [JsonPropertyName("lng")]
            public double? Lng;
        }

        private class StartLocation
        {
            [JsonPropertyName("lat")]
            public double? Lat;

            [JsonPropertyName("lng")]
            public double? Lng;
        }

        private class Polyline
        {
            [JsonPropertyName("points")]
            public string? Points;
        }

        private class Step
        {
            [JsonPropertyName("distance")]
            public Distance? Distance;

            [JsonPropertyName("duration")]
            public Duration? Duration;

            [JsonPropertyName("end_location")]
            public EndLocation? EndLocation;

            [JsonPropertyName("html_instructions")]
            public string? HtmlInstructions;

            [JsonPropertyName("polyline")]
            public Polyline? Polyline;

            [JsonPropertyName("start_location")]
            public StartLocation? StartLocation;

            [JsonPropertyName("travel_mode")]
            public string? TravelMode;

            [JsonPropertyName("maneuver")]
            public string? Maneuver;
        }

        private class Leg
        {
            [JsonPropertyName("distance")]
            public Distance? Distance;

            [JsonPropertyName("duration")]
            public Duration? Duration;

            [JsonPropertyName("end_address")]
            public string? EndAddress;

            [JsonPropertyName("end_location")]
            public EndLocation? EndLocation;

            [JsonPropertyName("start_address")]
            public string? StartAddress;

            [JsonPropertyName("start_location")]
            public StartLocation? StartLocation;

            [JsonPropertyName("steps")]
            public List<Step>? Steps;

            [JsonPropertyName("traffic_speed_entry")]
            public List<object>? TrafficSpeedEntry;

            [JsonPropertyName("via_waypoint")]
            public List<object>? ViaWaypoint;
        }
            
        private class OverviewPolyline
        {
            [JsonPropertyName("points")]
            public string? Points;
        }

        private class Route
        {
            [JsonPropertyName("bounds")]
            public Bounds? Bounds;

            [JsonPropertyName("copyrights")]
            public string? Copyrights;

            [JsonPropertyName("legs")]
            public List<Leg> Legs;

            [JsonPropertyName("overview_polyline")]
            public OverviewPolyline OverviewPolyline;

            [JsonPropertyName("summary")]
            public string? Summary;

            [JsonPropertyName("warnings")]
            public List<object> Warnings;

            [JsonPropertyName("waypoint_order")]
            public List<object> WaypointOrder;
        }

        private class Root
        {
            [JsonPropertyName("geocoded_waypoints")]
            public List<GeocodedWaypoint> GeocodedWaypoints;

            [JsonPropertyName("routes")]
            public List<Route> Routes;

            [JsonPropertyName("status")]
            public string? Status;
        }


    }
}
#endregion