using System;
using System.IO;
using System.Net;
using System.Text;

namespace VP_15_Base_Project
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

   
    class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string postData { get; set; }

        public string authToken { get; set; }
        public string clientID { get; set; }
        public string clientSecret { get; set; }


        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();


            switch (endPoint)
            {
                case "https://tapi.telstra.com/v2/oauth/token":
                    request.ContentType = "application/x-www-form-urlencoded";
                    postData = "grant_type=client_credentials&scope=NSMS&client_id=" + clientID + "&client_secret=" + clientSecret;
                    break;
                case "https://tapi.telstra.com/v2/messages/provisioning/subscriptions":
                    request.ContentType = "application/json";
                    request.Accept = "application/json";
                    request.Headers.Add("Authorization: Bearer " + authToken);
                    postData = "{}";
                    break;
                case "https://tapi.telstra.com/v2/messages/sms":
                    request.ContentType = "application/json";
                    request.Accept = "application/json";
                    request.Headers.Add("Authorization: Bearer " + authToken);
                    break;

            }




            using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
            {
                swJSONPayload.Write(postData);

                swJSONPayload.Close();
            }
            


            HttpWebResponse response = null;

            try 
            {
                response = (HttpWebResponse)request.GetResponse();
                

                //Proecess the resppnse stream... (could be JSON, XML or HTML etc..._

                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if(response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

            return strResponseValue;
        }

    }
}
