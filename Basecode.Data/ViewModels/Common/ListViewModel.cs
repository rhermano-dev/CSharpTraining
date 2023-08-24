﻿using Newtonsoft.Json;

namespace Basecode.Data.ViewModels.Common
{
    public class ListViewModel
    {
        [JsonProperty(PropertyName = "pagination")]
        public object Pagination { get; set; }

        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }
    }
}
