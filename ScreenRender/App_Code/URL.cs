﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

/// <summary>
/// Summary description for URL
/// </summary>
public class URL
{
    [JsonProperty("u")]
    public string url { get; set; }

    [JsonProperty("e")]
    public DateTime expiration { get; set; }

    [JsonProperty("s")]
    public string grade { get; set; }

    [JsonProperty("sha1")]
    public Boolean sha1Signature { get; set; }
}

public class URLCollection
{
    [JsonProperty("Data")]
    public List<URL> urls { get; set; }
}