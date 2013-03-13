using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestGCM
{
    public class Common
    {
        public static Dictionary<Guid, string> _devices = null;
        public static Dictionary<Guid, string> Devices
        {
            get 
            {
                if (_devices == null)
                    _devices = new Dictionary<Guid, string>();
                return _devices;
            }
        }

        public static Guid AppendDevice(string regId)
        {
            if (!Devices.Values.Contains(regId))
                Devices.Add(Guid.NewGuid(), regId);

            return Devices.Single(kv => kv.Value == regId).Key;
        }

        public static void RemoveDevice(string regId)
        {
            if (Devices.Values.Contains(regId))
                Devices.Remove(_devices.Single(kv => kv.Value == regId).Key);
        }

        public static IEnumerable<Guid> GetAllDevices()
        {
            return Devices.Keys;
        }

        public static string GetDevice(Guid id)
        {
            if (!_devices.ContainsKey(id))
                throw new KeyNotFoundException("device not exist");

            return _devices[id];
        }
    }
}