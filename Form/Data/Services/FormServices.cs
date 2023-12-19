using Form.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form.Data.Services;

public class FormServices
{
    public static void SaveDataInJson(FormModel model)
    {
        string filePath = Utils.Utils.ApplicationFilePath();
        string formJsonData = JsonConvert.SerializeObject(model, Formatting.Indented);
        File.WriteAllText(filePath, formJsonData);
    }
}
