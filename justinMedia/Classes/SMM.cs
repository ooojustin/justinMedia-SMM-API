// INFORMATION
// .NET API Wrapper for Social Media Panels
// Copyright Ⓒ 2018, Justin Garofolo, All Rights Reserved
using Newtonsoft.Json;
using System;
using System.Collections.Generic;   
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

public class SMM {

    // These are preset for SmmLite.com and must be changed for other APIs.
    public enum Service {
        YoutubeLikes = 718, // 50 - 5000
        YoutubeDislikes = 755, // 20 - 5000
        InstagramFollowers_Refill = 573, // 100 - 10000
        InstagramFollowers = 503, // 100 - 45000
        InstagramLikes = 719, // 50 - 15000
        TwitterFollowers = 715, // 20 - 1000000000
    }

    public int TwitterFollowers(string username, int quantity, int runs = -1, int interval = -1) {
        string link = "https://twitter.com/" + username;
        return AddOrder(Service.TwitterFollowers, link, quantity, runs, interval);
    }

    public int YoutubeLikes(string id, int quantity, bool dislike = false, int runs = -1, int interval = -1) {
        string link = "https://www.youtube.com/watch?v=" + id;
        Service service = dislike ? Service.YoutubeDislikes : Service.YoutubeLikes;
        return AddOrder(service, link, quantity, runs, interval);
    }

    public int InstagramLikes(string id, int quantity, int runs = -1, int interval = -1) {
        string link = "https://www.instagram.com/p/" + id;
        return AddOrder(Service.InstagramLikes, link, quantity, runs, interval);
    }

    public int InstagramFollowers(string username, int quantity, bool refill = false, int runs = -1, int interval = -1) {
        string link = "https://www.instagram.com/" + username;
        Service service = refill ? Service.InstagramFollowers_Refill : Service.InstagramFollowers;
        return AddOrder(service, link, quantity, runs, interval);
    }

    public class Order {

        private int id = -1;
        private string type = string.Empty;
        private decimal charge = -1;
        private int start_count = -1;
        private bool completed = false;
        private int remains = -1;
        private int last_update = -1;
        private int update_time = -1;

        public Order(int id, string type) {
            this.id = id;
            this.type = type;
        }

        public int GetID() { return id; }
        public string GetOrderType() { return type; }
        public decimal GetCharge() { return charge; }
        public int GetStartCount() { return start_count; }
        public bool IsCompleted() { return completed; }
        public int GetRemaining() { return remains; }
        public int GetLastUpdate() { return last_update; }
        public bool UpdateRequired() { return SMM.CurrentTimestamp() > update_time; }

        public bool UpdateData(SMM api) {
            try {
                NameValueCollection values = new NameValueCollection();
                values["order"] = Convert.ToString(id);
                string response = api.API_POST("status", values);
                dynamic data = JsonConvert.DeserializeObject(response);
                charge = Math.Round(Decimal.Parse(Convert.ToString(data.charge)), 2);
                start_count = Convert.ToInt32(Convert.ToString(data.start_count));
                completed = Convert.ToString(data.status) == "Completed";
                remains = Convert.ToInt32(Convert.ToString(data.remains));
                last_update = SMM.CurrentTimestamp();
                update_time = last_update + 60; // require update every minute
                return true;
            } catch (Exception) { return false; }
        }

    }

    internal class OrderList {

        List<Order> list;

        public OrderList(string stored) {
            list = new List<Order>();
            Regex regex = new Regex("{.*,.*}");
            MatchCollection matches = regex.Matches(stored);
            foreach (Match m in matches) {
                string matchData = m.ToString();
                matchData = matchData.Substring(1);
                matchData = matchData.Substring(0, matchData.Length - 1);
                string[] data = matchData.Split(new char[] { ',' });
                int orderID = Convert.ToInt32(data[0]);
                string orderType = data[1];
                Order order = new Order(orderID, orderType);
                list.Add(order);
            }
        }

        public void AddOrder(Order order) { list.Add(order); }
        public List<Order> GetList() { return list; }

        public string GetOrders() {
            string save = string.Empty;
            foreach (Order order in list) {
                int id = order.GetID();
                string type = order.GetOrderType();
                save += "{" + id + "," + type + "}" + Environment.NewLine;
            }
            return save;
        }

        public void SaveOrders() {
            string save = GetOrders();
            justinMedia.Properties.Settings.Default.ORDER_LIST = save;
            justinMedia.Properties.Settings.Default.Save();
        }

    }

    private string apiURL;
    private string apiKey;

    public SMM(string apiURL, string apiKey) {
        this.apiURL = apiURL;
        this.apiKey = apiKey;
    }
    
    public static int CurrentTimestamp() {
      return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
    }

    public decimal GetBalance() {
       try {
            string response = API_POST("balance", new NameValueCollection());
            dynamic data = JsonConvert.DeserializeObject(response);
            decimal balance = Decimal.Parse(Convert.ToString(data.balance));
            return Math.Round(balance, 2);
       } catch (Exception) { return -1; }
    }

    public int AddOrder(Service service, string link, int quantity, int runs = -1, int interval = -1) {
        try {
            NameValueCollection values = new NameValueCollection();
            values["service"] = Convert.ToString((int) service);
            values["link"] = link;
            values["quantity"] = Convert.ToString(quantity);
            if (runs > -1) values["runs"] = Convert.ToString(runs);
            if (interval > -1) values["interval"] = Convert.ToString(interval);
            string response = API_POST("add", values);
            Console.WriteLine(response);
            dynamic data = JsonConvert.DeserializeObject(response);
            return Convert.ToInt32(data.order);
        } catch (Exception) { return -1; }
    }

    private string API_POST(string action, NameValueCollection values) {
       try {
            using (WebClient web = new WebClient()) {
                web.Headers.Add("user-agent", "justinMedia");
                values["key"] = apiKey;
                values["action"] = action;
                byte[] response = web.UploadValues(apiURL, values);
                return Encoding.Default.GetString(response);
            }
       } catch (Exception) { return null; }
    }

}
