using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai3.Services
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, string key, Object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value)); 
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
