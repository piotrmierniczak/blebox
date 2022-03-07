using System;
using Newtonsoft.Json;

namespace blebox.library
{
    public class ControlState
    {
        public Rgbw Rgbw { get; set; } = new Rgbw();

        public ControlState(string jsonString = "")
        {
            if (!string.IsNullOrEmpty(jsonString))
            {
                SetValuesByJson(jsonString);
            }
        }

        private void SetValuesByJson(string jsonString)
        {
            try
            {
                ControlState item = JsonConvert.DeserializeObject<ControlState>(jsonString);
                if (item != null)
                {
                    Rgbw = item.Rgbw;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
